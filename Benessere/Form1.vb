Imports System.IO
Imports System.Reflection
Imports System.Text
Imports NAudio.Wave
Imports Benessere.UniqueCodeGenerator
Public Class Form1
    Private Sub FirefoxRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles FirefoxRadioButton1.CheckedChanged
        If FirefoxRadioButton1.Checked And Not pinOK Then
            MaterialExpansionPanel2.Location = New Point(FirefoxMainTabControl1.TabPages(0).Width / 2 - MaterialExpansionPanel1.Width / 2,
                                                    FirefoxMainTabControl1.TabPages(0).Height / 2 - MaterialExpansionPanel1.Height / 2)
            MaterialExpansionPanel2.ValidationButtonEnable = True
            MaterialExpansionPanel2.ValidationButtonText = "Imposta PIN"
            MaterialExpansionPanel2.CancelButtonText = "Annulla"
            MaterialExpansionPanel2.Visible = True
            MaterialExpansionPanel2.Collapse = False
            Label6.ForeColor = Color.Black
            Label6.Text = "Immetti 4 cifre"
            MaterialMaskedTextBox1.Text = "PIN"
        End If
        If Not FirefoxRadioButton1.Checked Then
            pinOK = 0
            FirefoxRadioButton6.Checked = False
        End If
    End Sub

    Private Sub FirefoxRadioButton1_Click(sender As Object, e As EventArgs) Handles FirefoxRadioButton1.DoubleClick
        If FirefoxRadioButton1.Checked Then FirefoxRadioButton1.Checked = False Else FirefoxRadioButton1.Checked = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        LoadSettings()
        MaterialExpansionPanel1.Visible = False
        Dim form2 As New ActvitiesChart()
        form2.TopLevel = False
        form2.FormBorderStyle = FormBorderStyle.None
        form2.Dock = DockStyle.Fill

        FirefoxMainTabControl1.TabPages(1).Controls.Add(form2)
        form2.Show()

        Dim form3 As New Buddies()
        form3.TopLevel = False
        form3.FormBorderStyle = FormBorderStyle.None
        form3.Dock = DockStyle.Fill

        FirefoxMainTabControl1.TabPages(3).Controls.Add(form3)
        form3.Show()

        MaterialExpansionPanel2.Location = New Point(99999, 99999)
        MaterialExpansionPanel2.Visible = False
        MaterialMaskedTextBox1.UseSystemPasswordChar = False
        Label6.ForeColor = Color.Black
        Label6.Text = "Immetti 4 cifre"
        MaterialMaskedTextBox1.Text = "PIN"
        'genera codice univoco account utente
        If Not IO.File.Exists(My.Application.shaMacFile) Then
            generaAccount(My.Application.shaMacFile)
        End If
        BlockAlert.Visible = False
        BlockAlert.Location = New Point(999999, 999999)
    End Sub
    Private Sub generaAccount(ByVal path As String)
        Dim ID As String = GetUniqueCode() 'crittografia sha 256
        Dim writer As New StreamWriter(path)
        writer.WriteLine(ID)
        writer.Flush()
        writer.Close()
        SetHiddenAttribute(path) 'nascondi file all'utente
    End Sub
    Private Sub LoadSettings()
        If Not IO.File.Exists(My.Application.settingsFile) Then
            'errore ecc
            Application.Exit()
        End If
        Dim reader As New StreamReader(My.Application.settingsFile)
        Dim str, t, s As String
        While reader.EndOfStream = False
            str = reader.ReadLine
            t = str.Split(":")(0)
            s = str.Split(":")(1)
            For Each tp As TabPage In FirefoxMainTabControl1.TabPages
                If tp.Tag = "0" Then
                    For i As Integer = tp.Controls.Count - 1 To 0 Step -1
                        Dim ctrl As Control = tp.Controls(i)
                        If TypeOf ctrl Is Panel Then
                            For Each ctrl_ As Control In ctrl.Controls
                                If ctrl_.Tag = t And TypeOf ctrl_ Is FirefoxRadioButton Then
                                    DirectCast(ctrl_, FirefoxRadioButton).Checked = CInt(s)
                                End If
                            Next
                        End If
                    Next
                End If
            Next
        End While
        reader.Close()
    End Sub

    Public Sub SaveSettings()
        Dim writer As New StreamWriter(My.Application.settingsFile)
        Dim state As Integer
        For Each tp As TabPage In FirefoxMainTabControl1.TabPages
            If tp.Tag = "0" Then
                For i As Integer = tp.Controls.Count - 1 To 0 Step -1
                    Dim ctrl As Control = tp.Controls(i)
                    If TypeOf ctrl Is Panel Then
                        For Each ctrl_ As Control In ctrl.Controls
                            If TypeOf ctrl_ Is FirefoxRadioButton Then
                                If DirectCast(ctrl_, FirefoxRadioButton).Checked Then state = 1 Else state = 0
                                writer.WriteLine(ctrl_.Tag + ":" + state.ToString)
                            End If
                        Next
                    End If
                Next
            End If
        Next
        writer.Close()
    End Sub

    Private Sub FirefoxRadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles FirefoxRadioButton6.CheckedChanged
        If FirefoxRadioButton6.Checked Then FirefoxNumericUpDown1.Enabled_ = True Else FirefoxNumericUpDown1.Enabled_ = False
        If FirefoxRadioButton6.Checked And Not pinOK Then
            MaterialExpansionPanel2.Location = New Point(FirefoxMainTabControl1.TabPages(0).Width / 2 - MaterialExpansionPanel1.Width / 2,
                                                    FirefoxMainTabControl1.TabPages(0).Height / 2 - MaterialExpansionPanel1.Height / 2)
            MaterialExpansionPanel2.ValidationButtonEnable = True
            MaterialExpansionPanel2.ValidationButtonText = "Imposta PIN"
            MaterialExpansionPanel2.CancelButtonText = "Annulla"
            MaterialExpansionPanel2.Visible = True
            Label6.ForeColor = Color.Black
            MaterialExpansionPanel2.Collapse = False
            Label6.Text = "Immetti 4 cifre"
            MaterialMaskedTextBox1.Text = "PIN"
        End If
        If Not FirefoxRadioButton6.Checked Then
            FirefoxRadioButton1.Checked = False
            pinOK = 0
        End If
    End Sub

    Private Sub FirefoxRadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles FirefoxRadioButton2.CheckedChanged
        If FirefoxRadioButton2.Checked Then FirefoxNumericUpDown2.Enabled_ = True Else FirefoxNumericUpDown2.Enabled_ = False
    End Sub

    Private Sub FirefoxButton2_Click(sender As Object, e As EventArgs) Handles FirefoxButton2.Click
        SaveSettings()
    End Sub

    Private Sub FirefoxButton3_Click(sender As Object, e As EventArgs) Handles FirefoxButton3.Click
        LoadSettings()
    End Sub

    Private Sub FirefoxButton1_Click(sender As Object, e As EventArgs) Handles FirefoxButton1.Click
        Dim tabPage As New TabPage("Applica a...")

        Dim form2 As New games()
        form2.TopLevel = False
        form2.FormBorderStyle = FormBorderStyle.None
        form2.Dock = DockStyle.Fill

        tabPage.Controls.Add(form2)
        FirefoxMainTabControl1.TabPages.Add(tabPage)
        FirefoxMainTabControl1.SelectedTab = tabPage
        form2.Show()
    End Sub

    Private Sub MaterialExpansionPanel1_Paint(sender As Object, e As PaintEventArgs) Handles MaterialExpansionPanel1.Paint

    End Sub

    Private Sub MaterialExpansionPanel1_SaveClick(sender As Object, e As EventArgs) Handles MaterialExpansionPanel1.SaveClick
        MaterialExpansionPanel1.Visible = False
        MaterialExpansionPanel1.Location = New Point(999999, 999999)
        TimerBlock.Start()
    End Sub
    Public gamesList As New List(Of String)
    Public Sub mostraAlertAttivazione(ByVal dirs As List(Of String))
        Label3.Text = "I filtri di controllo parentale sono stati applicati a:" + vbCrLf
        For Each dir As String In dirs
            Label3.Text += dir + vbCrLf
        Next
        MaterialExpansionPanel1.Location = New Point(FirefoxMainTabControl1.TabPages(0).Width / 2 - MaterialExpansionPanel1.Width / 2,
                                                    FirefoxMainTabControl1.TabPages(0).Height / 2 - MaterialExpansionPanel1.Height / 2)
        MaterialExpansionPanel1.ValidationButtonEnable = True
        MaterialExpansionPanel1.ValidationButtonText = "Continua"
        MaterialExpansionPanel1.CancelButtonText = ""
        MaterialExpansionPanel1.Visible = True
        gamesList.Clear()
        For Each dir As String In dirs
            gamesList.Add(dir)
        Next
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click

    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click

    End Sub

    Private Sub MaterialMaskedTextBox1_Click(sender As Object, e As EventArgs) Handles MaterialMaskedTextBox1.Click
        If MaterialMaskedTextBox1.Text = "PIN" Then
            MaterialMaskedTextBox1.Clear()
            MaterialMaskedTextBox1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub MaterialMaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaterialMaskedTextBox1.TextChanged
        If MaterialMaskedTextBox1.Text.Length = 4 Then
            Dim safetylevel = CheckPinSafety(MaterialMaskedTextBox1.Text)
            If safetylevel Then
                Label6.Text = "ALTO"
                Label6.ForeColor = Color.Green
            Else
                Label6.Text = "BASSO"
                Label6.ForeColor = Color.Red
            End If
        End If

    End Sub

    Private Function isRepetitiveSequence_(pin As String) As Boolean
        ' Check if the PIN is a repetitive sequence like 1234 or 4444
        Dim firstDigit As Char = pin(0)

        For Each digit As Char In pin
            If digit <> firstDigit Then
                Return False
            End If
        Next

        Return True
    End Function

    Private Function isSimplePattern_(pin As String) As Boolean
        ' Check if the PIN is a simple pattern like 4321 or 2468
        Dim pattern As String = "1234567890"

        If pattern.Contains(pin) Then
            Return True
        End If

        Return False
    End Function

    Private Function isCommonCombination_(pin As String) As Boolean
        ' Check if the PIN is a common combination like 2580 or 0000
        Dim commonCombos As String() = {"2580", "0000", "1234", "4321"} ' Add more common combinations as needed

        If commonCombos.Contains(pin) Then
            Return True
        End If

        Return False
    End Function

    Private Function CheckPinSafety(pin As String) As Boolean
        ' Evaluate the safety of the PIN based on criteria
        ' This is just a simple example, you can customize it based on your criteria

        ' Criteria 1: PIN should not be a repetitive sequence like 1234 or 4444
        Dim isRepetitiveSequence As Boolean = isRepetitiveSequence_(pin)

        ' Criteria 2: PIN should not be a simple pattern like 4321 or 2468
        Dim isSimplePattern As Boolean = isSimplePattern_(pin)

        ' Criteria 3: PIN should not be a common combination like 2580 or 0000
        Dim isCommonCombination As Boolean = isCommonCombination_(pin)

        ' Combine the evaluation results based on your desired criteria
        Dim isSafe As Boolean = Not (isRepetitiveSequence Or isSimplePattern Or isCommonCombination)

        Return isSafe
    End Function
    Private Sub MaterialMaskedTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaterialMaskedTextBox1.KeyPress
        If MaterialMaskedTextBox1.Text.Length = 4 Then
            ' Verifica se il tasto premuto non è un tasto di cancellazione (Backspace o Delete)
            If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(127) Then
                ' Blocca l'input dell'utente impostando la proprietà Handled dell'evento su True
                e.Handled = True
            Else e.Handled = False

            End If
        Else
            If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ControlChars.Back) Then
                ' Blocca l'input dell'utente impostando la proprietà Handled dell'evento su True
                e.Handled = True
            Else e.Handled = False
            End If
        End If
    End Sub

    Private Sub MaterialExpansionPanel2_Paint(sender As Object, e As PaintEventArgs) Handles MaterialExpansionPanel2.Paint

    End Sub

    Private Sub MaterialExpansionPanel2_CancelClick(sender As Object, e As EventArgs) Handles MaterialExpansionPanel2.CancelClick
        FirefoxRadioButton1.Checked = False
        FirefoxRadioButton6.Checked = False
        MaterialExpansionPanel2.Location = New Point(99999, 99999)
        MaterialExpansionPanel2.Visible = False
    End Sub
    Private pinOK As Boolean = 0
    Private Sub MaterialExpansionPanel2_SaveClick(sender As Object, e As EventArgs) Handles MaterialExpansionPanel2.SaveClick
        MaterialExpansionPanel2.Location = New Point(99999, 99999)
        MaterialExpansionPanel2.Visible = False
        If MaterialMaskedTextBox1.Text.Length = 4 Then
            Dim writer As New StreamWriter(My.Application.pinFile)
            writer.WriteLine(MaterialMaskedTextBox1)
            writer.Flush()
            writer.Close()
            pinOK = 1
        End If
    End Sub

    Private Sub FirefoxButton4_Click(sender As Object, e As EventArgs) Handles FirefoxButton4.Click
        If FirefoxButton4.Text = "Mostra" Then
            FirefoxButton4.Text = "Nascondi"
            MaterialMaskedTextBox1.UseSystemPasswordChar = False
        Else
            FirefoxButton4.Text = "Mostra"
            MaterialMaskedTextBox1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        FirefoxRadioButton1.Checked = False
        FirefoxRadioButton6.Checked = False
        MaterialExpansionPanel2.Location = New Point(99999, 99999)
        MaterialExpansionPanel2.Visible = False
    End Sub
    Private Sub BringApplicationToFront()
        Me.WindowState = FormWindowState.Minimized ' Riduci la finestra all'icona nella taskbar
        Me.Show() ' Mostra la finestra
        Me.WindowState = FormWindowState.Normal ' Ripristina la finestra allo stato normale
        Me.Activate() ' Focalizza la finestra
    End Sub

    Private Sub TimerBlock_Tick(sender As Object, e As EventArgs) Handles TimerBlock.Tick
        ' Verifica se uno dei percorsi degli eseguibili bloccati è stato aperto
        For Each path As String In gamesList
            Dim processes As Process() = Process.GetProcessesByName(IO.Path.GetFileNameWithoutExtension(path))

            If processes.Any() Then
                ' Un eseguibile bloccato è stato aperto, blocca l'apertura e mostra un messaggio
                Dim alert As String = "L'apertura dell'eseguibile " & IO.Path.GetFileName(path) + vbCrLf + " è stata bloccata." + vbCrLf + "Il gioco non può essere sbloccato" + vbCrLf + "siccome è stato attivato il blocco della sua apertura."

                ' Termina tutti i processi corrispondenti all'eseguibile bloccato
                For Each proc As Process In processes
                    proc.Kill()
                Next
                If Not BlockAlert.Visible Then
                    BlockAlert.Location = New Point(ClientSize.Width / 2 - BlockAlert.Width / 2, ClientSize.Height / 2 - BlockAlert.Height / 2)
                    BlockAlert.BringToFront()
                    Label9.Text = "Attenzione!" + vbCrLf + alert
                    BlockAlert.Visible = True
                    BringApplicationToFront()
                    BlockAlert.ValidationButtonEnable = True
                    BlockAlert.ValidationButtonText = "Ho capito!"
                    Dim tempFilePath As String = IO.Path.GetTempFileName()

                    Try
                        Dim resourceStream As Stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(ConvertUnmanagedMemoryStreamToString(My.Resources.police_siren))
                        Using fileStream As New FileStream(tempFilePath, FileMode.Create)
                                resourceStream.CopyTo(fileStream)
                            End Using


                            ' Leggi il file audio WAV dal percorso temporaneo
                            Dim wavBytes As Byte() = File.ReadAllBytes(tempFilePath)

                        ' Crea un MemoryStream dal file audio WAV
                        Using stream As New MemoryStream(wavBytes)
                            ' Leggi il file audio WAV
                            Using reader As New WaveFileReader(stream)
                                ' Converti il formato in PCM
                                Dim pcmStream As New WaveFormatConversionStream(New WaveFormat(44100, 16, 2), reader)

                                ' Riproduci il suono PCM
                                Using player As New WaveOut()
                                    player.Init(pcmStream)
                                    player.Play()
                                End Using
                            End Using
                        End Using
                    Catch ex As Exception
                    Finally
                        ' Elimina il file temporaneo
                        File.Delete(tempFilePath)

                    End Try
                End If
            End If
        Next
    End Sub
    Private Function ConvertUnmanagedMemoryStreamToString(stream As UnmanagedMemoryStream) As String
        ' Leggi il contenuto del UnmanagedMemoryStream come array di byte
        Dim bytes As Byte() = New Byte(stream.Length - 1) {}
        stream.Read(bytes, 0, bytes.Length)

        ' Converti l'array di byte in una stringa utilizzando un'opzione di codifica appropriata
        Dim encoding As Encoding = encoding.UTF8 ' Sostituisci con la codifica desiderata
        Dim str As String = encoding.GetString(bytes)

        Return str
    End Function
    Private Sub BlockAlert_Paint(sender As Object, e As PaintEventArgs) Handles BlockAlert.Paint

    End Sub

    Private Sub BlockAlert_SaveClick(sender As Object, e As EventArgs) Handles BlockAlert.SaveClick
        BlockAlert.Visible = False
        BlockAlert.Location = New Point(999999, 99999)
        If Not TimerBlock.Enabled Then TimerBlock.Start()
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        BlockAlert.Visible = False
        BlockAlert.Location = New Point(999999, 99999)
        If Not TimerBlock.Enabled Then TimerBlock.Start()
    End Sub
End Class
