Public Class Store
    Private pictureBox1 As PictureBox
    Private pictureBox2 As PictureBox
    Private pictureBox3 As PictureBox
    Dim label1 As New Label()
    Dim label2 As New Label()
    Dim label3 As New Label()
    Dim tableLayoutPanel1 As New FlowLayoutPanel()
    Private Sub Store_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'tableLayoutPanel1.Dock = DockStyle.Fill
        tableLayoutPanel1.Location = New Point((Me.ClientSize.Width - tableLayoutPanel1.Width) \ 2 + 100, 0)
        'tableLayoutPanel1.ColumnCount = 1
        tableLayoutPanel1.FlowDirection = FlowDirection.TopDown
        tableLayoutPanel1.WrapContents = False
        tableLayoutPanel1.AutoSize = True
        tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink

        AddApp("Steam Card 5 euro - 1000 punti premio", My.Resources.s5)
        AddApp("Steam Card 20 euro - 10000 punti premio", My.Resources.s20)
        AddApp("Steam Card 100 euro - 100000 punti premio", My.Resources.s100)

        Me.Controls.Add(tableLayoutPanel1)
    End Sub
    Private Sub AddApp(appName As String, imagePath As Bitmap)
        ' Crea i controlli per l'app
        Dim pictureBox As New PictureBox()
        pictureBox.Image = imagePath
        pictureBox.Size = New Size(150, 150)
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage

        Dim label As New Label()
        label.Text = appName
        label.AutoSize = True
        label.TextAlign = ContentAlignment.MiddleCenter

        ' Aggiungi i controlli al FlowLayoutPanel
        tableLayoutPanel1.Controls.Add(pictureBox)
        tableLayoutPanel1.Controls.Add(label)

        ' Imposta l'Anchor dei controlli per mantenere la posizione centrata
        pictureBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
    End Sub
    Private Sub Store_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

    End Sub
End Class