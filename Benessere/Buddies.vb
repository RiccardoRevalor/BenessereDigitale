Public Class Buddies
    Private Sub MaterialExpansionPanel1_Paint(sender As Object, e As PaintEventArgs) Handles MaterialExpansionPanel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Buddies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaterialExpansionPanel1.Visible = True
        MaterialExpansionPanel1.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 10)
        MaterialExpansionPanel2.Visible = False
        MaterialExpansionPanel2.Location = New Point(999999, 999999)
        PictureBox9.Visible = False
    End Sub

    Private Sub MaterialExpansionPanel1_CancelClick(sender As Object, e As EventArgs) Handles MaterialExpansionPanel1.CancelClick
        MaterialExpansionPanel1.Visible = False
        MaterialExpansionPanel1.Location = New Point(999999, 999999)
        MaterialExpansionPanel2.Visible = True
        MaterialExpansionPanel2.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 10)
    End Sub

    Private Sub MaterialExpansionPanel1_SaveClick(sender As Object, e As EventArgs) Handles MaterialExpansionPanel1.SaveClick
        MaterialExpansionPanel1.Visible = False
        MaterialExpansionPanel1.Location = New Point(999999, 999999)
        MaterialExpansionPanel2.Visible = True
        MaterialExpansionPanel2.Location = New Point(PictureBox1.Location.X, PictureBox1.Location.Y + PictureBox1.Height + 10)
    End Sub

    Private Sub MaterialTextBox21_Click(sender As Object, e As EventArgs) Handles MaterialTextBox21.Click
        If MaterialTextBox21.Text = "Inserisci codice ID qui" Then MaterialTextBox21.Text = ""
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

    End Sub
    Private numChars As Integer = 79
    Private Function validateLink(ByVal txt As String) As Boolean
        If txt = "" Then Return False
        If txt.Length <> numChars Then Return False
        If Not (txt.StartsWith("$EnhPC")) Then Return False
        'aggiungi altri controlli di validazione
        Return True
    End Function
    Private Sub FirefoxButton1_Click(sender As Object, e As EventArgs) Handles FirefoxButton1.Click
        If FirefoxButton1.Text = "Entra in Hub!" Then
            Dim tabPage As New TabPage("BuddiesHub")

            Dim form2 As New BuddiesHub()
            form2.TopLevel = False
            form2.FormBorderStyle = FormBorderStyle.None
            form2.Dock = DockStyle.Fill

            tabPage.Controls.Add(form2)
            Form1.FirefoxMainTabControl1.TabPages.Add(tabPage)
            Form1.FirefoxMainTabControl1.TabPages.Remove(Form1.FirefoxMainTabControl1.SelectedTab)
            Form1.FirefoxMainTabControl1.SelectedTab = tabPage
            form2.Show()
            Me.Close()
        Else
            Dim link As String = MaterialTextBox21.Text
            If Not validateLink(link) Then
                MsgBox("Attenzione! ID amico non corretto!")
                Return
            End If
            MaterialLabel2.Location = New Point(ClientSize.Width / 2 - MaterialLabel2.Width / 2, ClientSize.Height / 2)
            MaterialLabel2.Show()
            PictureBox4.Show()
            Timer1.Start()
            TextBox1.Text = "Stato della connessione: Performing tasks:"
        End If
    End Sub
    Dim cntTimer As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cntTimer += 1
        Select Case cntTimer
            Case 1
                TextBox1.Text += vbCrLf + DateTime.Now.ToString + " - Trying to link w/: {domain:" + MaterialTextBox21.Text + "}"
            Case 2
                TextBox1.Text += vbCrLf + DateTime.Now.ToString + " - Fetching account info..."
            Case 4
                TextBox1.Text += vbCrLf + DateTime.Now.ToString + " - Testing network stability and safety..."
            Case 7
                TextBox1.Text += vbCrLf + DateTime.Now.ToString + " - CONNECTED w/ {domain:" + MaterialTextBox21.Text + "}"
                MaterialExpansionPanel1.ValidationButtonEnable = True
                PictureBox9.Visible = True
                FirefoxButton1.Text = "Entra in Hub!"
                FirefoxButton1.Invalidate()
                FirefoxButton1.Update()
                Timer1.Stop()
        End Select
    End Sub
End Class