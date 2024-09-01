Imports System.IO
Imports Shell32
Public Class BuddiesHub
    Private Sub BuddiesHub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaterialExpansionPanel1.Visible = True
        MaterialExpansionPanel1.Location = New Point(ClientSize.Width / 2 - MaterialExpansionPanel1.Width / 2, ClientSize.Height / 2 - MaterialExpansionPanel1.Height / 2)
        GroupBox2.Location = New Point(GroupBox1.Location.X + GroupBox1.Width + 5, GroupBox1.Location.Y)
        MaterialExpansionPanel2.Visible = False
        MaterialExpansionPanel2.Location = New Point(-999999, -999999)
    End Sub

    Private Sub MaterialExpansionPanel1_Paint(sender As Object, e As PaintEventArgs) Handles MaterialExpansionPanel1.Paint

    End Sub

    Private Sub MaterialExpansionPanel1_SaveClick(sender As Object, e As EventArgs) Handles MaterialExpansionPanel1.SaveClick
        MaterialExpansionPanel1.Visible = False
        MaterialExpansionPanel1.Location = New Point(999999, 99999999)
    End Sub

    Private Sub BuddiesHub_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        GroupBox1.Width = ClientSize.Width / 2 - 10
        GroupBox2.Width = ClientSize.Width / 2 - 10
        GroupBox2.Location = New Point(GroupBox1.Location.X + GroupBox1.Width + 5, GroupBox1.Location.Y)
        GroupBox2.SendToBack()
        MaterialDivider1.Width = GroupBox2.Width
        MaterialDivider1.BringToFront()
        FirefoxH12.Location = New Point(PictureBox3.Location.X + PictureBox3.Width / 2 - FirefoxH12.Width / 2, FirefoxH12.Location.Y)
        FirefoxH12.BringToFront()
        FirefoxButton1.Location = New Point(FirefoxH12.Location.X - 10, FirefoxButton1.Location.Y)
        PictureBox4.Location = New Point(FirefoxButton1.Location.X, PictureBox4.Location.Y)
        'MaterialDivider1.Location = New Point(GroupBox2.Location.X, GroupBox2.Location.Y - GroupBox2.Height / 2 - MaterialDivider1.Height / 2)
        Pts.Text = loadPunti()
        removeWhite()
    End Sub

    Private Function loadPunti() As String
        Dim r As New StreamReader(My.Application.PtsFile)
        Dim ptsr As String = r.ReadLine()
        r.Close()
        Return ptsr
    End Function

    Private Sub removeWhite()
        Dim image As Image = PictureBox1.Image

        ' Assicurati che l'immagine non sia nulla
        If image IsNot Nothing Then
            ' Converte l'immagine in un oggetto Bitmap
            Dim bitmap As New Bitmap(image)

            ' Scandisci tutti i pixel dell'immagine
            For x As Integer = 0 To bitmap.Width - 1
                For y As Integer = 0 To bitmap.Height - 1
                    ' Ottieni il colore del pixel corrente
                    Dim pixelColor As Color = bitmap.GetPixel(x, y)

                    ' Controlla se il colore è bianco
                    If pixelColor = Color.White Then
                        ' Imposta la trasparenza per il pixel corrente
                        bitmap.SetPixel(x, y, Color.Transparent)
                    End If
                Next
            Next

            ' Visualizza l'immagine modificata nella PictureBox
            PictureBox1.Image = bitmap
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim tabPage As New TabPage("Store Premi")

        Dim form2 As New Store()
        form2.TopLevel = False
        form2.FormBorderStyle = FormBorderStyle.None
        form2.Dock = DockStyle.Fill

        tabPage.Controls.Add(form2)
        Form1.FirefoxMainTabControl1.TabPages.Add(tabPage)
        Form1.FirefoxMainTabControl1.SelectedTab = tabPage
        form2.Show()
    End Sub
    Dim url As String = "https://store.steampowered.com/tags/en/Local%20Co-Op/?l=italian"
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

    End Sub
    Private gameOn = False
    Private Sub FirefoxButton1_Click(sender As Object, e As EventArgs) Handles FirefoxButton1.Click
        If Not gameOn Then
            gameOn = True
            MaterialExpansionPanel2.Tag = "alert2"
            FirefoxButton1.Text = "Termina sessione di gioco"
            FirefoxButton1.Update()
            FirefoxButton1.Invalidate()
            MaterialExpansionPanel2.Visible = True
            For Each control As Control In Me.Controls
                If control.Tag <> "alert2" Then control.SendToBack()
            Next
            MaterialExpansionPanel2.BringToFront()
            MaterialExpansionPanel2.Location = New Point(0, 0)
            MaterialExpansionPanel2.BringToFront()
            CenterControlInForm(MaterialExpansionPanel2)
            MaterialExpansionPanel2.Invalidate()
            Timer1.Start()
        End If
    End Sub

    Private Sub CenterControlInForm(control As Control)
        ' Calcola le coordinate del punto di inizio del form
        Dim formStartX As Integer = (Me.ClientSize.Width - control.Width) \ 2
        Dim formStartY As Integer = (Me.ClientSize.Height - control.Height) \ 2

        ' Centra il controllo all'interno del form
        control.Location = New Point(formStartX, formStartY)
    End Sub

    Private Sub MaterialExpansionPanel2_Paint(sender As Object, e As PaintEventArgs) Handles MaterialExpansionPanel2.Paint

    End Sub

    Private Sub MaterialExpansionPanel2_SaveClick(sender As Object, e As EventArgs) Handles MaterialExpansionPanel2.SaveClick
        MaterialExpansionPanel2.Visible = False
        MaterialExpansionPanel2.Location = New Point(99999, 99999)
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim currentValue As Integer = Integer.Parse(Label1.Text)
        currentValue += 1
        Label1.Text = currentValue.ToString()
    End Sub
End Class