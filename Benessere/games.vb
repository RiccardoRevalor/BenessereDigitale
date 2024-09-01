Imports Gameloop.Vdf
Imports Gameloop.Vdf.JsonConverter
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class games
    Private Sub games_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\Steam\steamapps\libraryfolders.vdf"
        deserializeVdf(filename)
    End Sub
    Private Sub deserializeVdf(FileName As String)
        Dim volvo = VdfConvert.Deserialize(File.ReadAllText(FileName))
        'File.WriteAllText("steamDirs.json", volvo.ToJson().ToString)
        Dim jsonString As String = "{" + volvo.ToJson().ToString + vbCrLf + "}"
        File.WriteAllText("steamDirs.json", jsonString)
        Dim jsonObject As JObject = JsonConvert.DeserializeObject(Of JObject)(jsonString)
        Dim SteamDirs As New List(Of String)
        Dim termination As String = "\steamapps\common"

        Dim SteamFolders As JObject = jsonObject("libraryfolders")
        For Each property_ As JProperty In jsonObject.Properties()
            Dim propertyName As String = property_.Name
            Dim propertyValue As JToken = property_.Value

            If TypeOf propertyValue Is JObject Then
                Dim jtk As JToken = propertyValue.First
                Dim num As Integer = propertyValue.Count
                Dim i As Integer = 0
                For i = 0 To num - 1
                    SteamDirs.Add(jtk.First.First.First.ToString + termination)
                    jtk = jtk.Next
                Next

            End If
        Next

        'scansiona giochi
        Dim subDirs As String()
        Dim executablePaths As New Dictionary(Of String, List(Of String))()
        For Each dir As String In SteamDirs
            If IO.Directory.Exists(dir) Then
                SearchForExecutables(dir, executablePaths)
            End If
        Next

        Dim imageList1 As New ImageList
        ListView1.GroupImageList = imageList1
        ListView1.LargeImageList = imageList1
        ListView1.SmallImageList = imageList1
        ListView1.StateImageList = imageList1
        ' Pulisci la ListView
        ListView1.Items.Clear()
        imageList1.Images.Clear()
        imageList1.ImageSize = New Size(64, 64)
        ListView1.MultiSelect = True
        For Each kvp As KeyValuePair(Of String, List(Of String)) In executablePaths
            Dim mainFolderPath As String = kvp.Key
            Dim executablePathsInFolder As List(Of String) = kvp.Value

            PopolaListView(executablePathsInFolder, imageList1)
        Next
    End Sub

    Private Sub PopolaListView(ByVal listaPercorsi As List(Of String), ByRef imagelist1 As ImageList)

        ' Itera attraverso la lista dei percorsi degli eseguibili
        For Each filePath As String In listaPercorsi
            Dim fileName As String = Path.GetFileNameWithoutExtension(filePath)
            ' Ottieni l'icona dell'eseguibile
            Dim exeIcon As Icon = GetExecutableIcon(filePath)
            If exeIcon Is Nothing Then Continue For
            ' Aggiungi l'icona e il nome senza estensione alla ListView
            Dim item As New ListViewItem()
            item.Text = fileName
            item.Tag = filePath
            If exeIcon IsNot Nothing Then
                item.ImageKey = fileName
                imagelist1.Images.Add(fileName, exeIcon)
            End If
            ListView1.Items.Add(item)
        Next
    End Sub

    Private Function GetExecutableIcon(path As String) As Icon
        Try
            Dim exeIcon As Icon = Icon.ExtractAssociatedIcon(path)
            Return exeIcon
        Catch ex As Exception
            ' Gestisci eventuali errori
            Return Nothing
        End Try
    End Function
    Private Sub SearchForExecutables(folderPath As String, ByRef executablePaths As Dictionary(Of String, List(Of String)), Optional trunc As Integer = 0)
        ' Ottiene tutti i file all'interno della cartella corrente
        Dim files As String() = Directory.GetFiles(folderPath)

        ' Crea una lista per i percorsi degli eseguibili nella cartella corrente
        Dim executablesInFolder As New List(Of String)()

        ' Scansiona i file per individuare gli eseguibili
        For Each filePath As String In files
            Dim fileExtension As String = Path.GetExtension(filePath)

            ' Aggiungi il percorso del file alla lista se l'estensione indica che è un eseguibile
            If IsExecutableExtension(fileExtension) Then
                executablesInFolder.Add(filePath)
                trunc = 1
            End If
        Next

        ' Aggiungi la lista dei percorsi degli eseguibili al dizionario utilizzando la cartella principale come chiave
        executablePaths.Add(folderPath, executablesInFolder)
        If trunc Then Return

        ' Recupera le sottocartelle della cartella corrente
        Dim subfolders As String() = Directory.GetDirectories(folderPath)

        ' Richiama la funzione ricorsiva per ciascuna sottocartella
        For Each subfolderPath As String In subfolders
            If subfolderPath.Contains("Steamworks Shared") Or subfolderPath.Contains("Steam Controller Configs") Then Continue For
            SearchForExecutables(subfolderPath, executablePaths, trunc)
            If trunc Then Exit For
        Next
    End Sub

    Private Function IsExecutableExtension(extension As String) As Boolean
        ' Definisci qui le estensioni che consideri come eseguibili
        Dim executableExtensions As String() = {".exe"}

        Return executableExtensions.Contains(extension.ToLower())
    End Function

    Private Sub FirefoxButton3_Click(sender As Object, e As EventArgs) Handles FirefoxButton3.Click
        applicaGiochi()
    End Sub
    Private Sub addGioco()
        Dim exe As String
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Title = "Seleziona l'eseguibile del gioco a cui applicare i filtri"
        openFileDialog1.Filter = "Eseguibile Windows (*.exe)|*.exe|Tutti i file (*.*)|*.*"
        openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        If openFileDialog1.ShowDialog() = DialogResult.OK Then

            exe = openFileDialog1.FileName
            If Not exe = "" Then
                Dim exel As String() = exe.Split("\")
                exe = exel(exel.Count - 1)
                Dim writer As New IO.StreamWriter(My.Application.gamesFile)
                Dim l As New List(Of String)
                writer.WriteLine(exe)
                l.Add(exe)
                writer.Flush()
                writer.Close()
                Form1.SaveSettings()
                Form1.FirefoxMainTabControl1.TabPages.Remove(Form1.FirefoxMainTabControl1.SelectedTab)
                Form1.FirefoxMainTabControl1.SelectedTab = Form1.FirefoxMainTabControl1.TabPages(0)
                Form1.mostraAlertAttivazione(l)
                Me.Close()
            End If
        End If
    End Sub
    Private Sub applicaGiochi()
        Dim writer As New IO.StreamWriter(My.Application.gamesFile)
        Dim l As New List(Of String)
        For Each selectedItem As ListViewItem In ListView1.SelectedItems
            writer.WriteLine(selectedItem.Tag)
            l.Add(selectedItem.Text)
        Next
        writer.Flush()
        writer.Close()
        Form1.SaveSettings()
        Form1.FirefoxMainTabControl1.TabPages.Remove(Form1.FirefoxMainTabControl1.SelectedTab)
        Form1.FirefoxMainTabControl1.SelectedTab = Form1.FirefoxMainTabControl1.TabPages(0)
        Form1.mostraAlertAttivazione(l)
        Me.Close()
    End Sub

    Private Sub FirefoxButton2_Click(sender As Object, e As EventArgs) Handles FirefoxButton2.Click
        addGioco()
    End Sub

    Private Sub FirefoxButton1_Click(sender As Object, e As EventArgs) Handles FirefoxButton1.Click
        Dim folderBrowserDialog1 As New FolderBrowserDialog()
        

        ' Imposta le proprietà desiderate per la finestra di dialogo
        folderBrowserDialog1.Description = "Seleziona un'unità disco"
        folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer


        ' Mostra la finestra di dialogo per selezionare l'unità disco
        If folderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            ' Ottieni il percorso completo dell'unità disco selezionata
            Dim drivePath As String = folderBrowserDialog1.SelectedPath

            ' Esegui l'azione desiderata con il percorso dell'unità disco
            Dim executablePaths As New Dictionary(Of String, List(Of String))()
            SearchForExecutables(drivePath, executablePaths)
            Dim imageList1 As New ImageList
            ListView1.GroupImageList = imageList1
            ListView1.LargeImageList = imageList1
            ListView1.SmallImageList = imageList1
            ListView1.StateImageList = imageList1
            ' Pulisci la ListView
            ListView1.Items.Clear()
            imageList1.Images.Clear()
            imageList1.ImageSize = New Size(64, 64)
            ListView1.MultiSelect = True
            For Each kvp As KeyValuePair(Of String, List(Of String)) In executablePaths
                Dim mainFolderPath As String = kvp.Key
                Dim executablePathsInFolder As List(Of String) = kvp.Value

                PopolaListView(executablePathsInFolder, imageList1)
            Next
        End If
    End Sub
End Class