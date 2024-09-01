<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuddiesHub
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("FIFA 23", 2)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("CupHead", 4)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("NBA 2K 23", 6)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Slither.IO", 5)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("WWE 2K 23", 7)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuddiesHub))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FirefoxH11 = New Benessere.FirefoxH1()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pts = New System.Windows.Forms.Label()
        Me.MaterialExpansionPanel1 = New MaterialSkin.Controls.MaterialExpansionPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.FirefoxButton1 = New Benessere.FirefoxButton()
        Me.FirefoxH12 = New Benessere.FirefoxH1()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MaterialExpansionPanel2 = New MaterialSkin.Controls.MaterialExpansionPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FirefoxButton2 = New Benessere.FirefoxButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MaterialExpansionPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialExpansionPanel2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 398)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Giochi perfetti per giocare insieme"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListView1.HideSelection = False
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10})
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(3, 21)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(388, 374)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.StateImageList = Me.ImageList1
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "nba")
        Me.ImageList1.Images.SetKeyName(1, "fifa")
        Me.ImageList1.Images.SetKeyName(2, "icons8-fifa-64.png")
        Me.ImageList1.Images.SetKeyName(3, "icons8-portal-50.png")
        Me.ImageList1.Images.SetKeyName(4, "icons8-cuphead-100.png")
        Me.ImageList1.Images.SetKeyName(5, "icons8-slither-io-100.png")
        Me.ImageList1.Images.SetKeyName(6, "icons8-2k-logo-48.png")
        Me.ImageList1.Images.SetKeyName(7, "icons8-wwe-64.png")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Benessere.My.Resources.Resources.buddies
        Me.PictureBox1.Location = New System.Drawing.Point(12, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'FirefoxH11
        '
        Me.FirefoxH11.AutoSize = True
        Me.FirefoxH11.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FirefoxH11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.FirefoxH11.Location = New System.Drawing.Point(111, 18)
        Me.FirefoxH11.Name = "FirefoxH11"
        Me.FirefoxH11.Size = New System.Drawing.Size(189, 37)
        Me.FirefoxH11.TabIndex = 2
        Me.FirefoxH11.Text = "BuddiesHub :)"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Pts)
        Me.Panel1.Location = New System.Drawing.Point(728, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(117, 54)
        Me.Panel1.TabIndex = 4
        '
        'Pts
        '
        Me.Pts.AutoSize = True
        Me.Pts.Font = New System.Drawing.Font("Candara Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Pts.Location = New System.Drawing.Point(3, 6)
        Me.Pts.Name = "Pts"
        Me.Pts.Size = New System.Drawing.Size(69, 26)
        Me.Pts.TabIndex = 5
        Me.Pts.Text = "PUNTI"
        '
        'MaterialExpansionPanel1
        '
        Me.MaterialExpansionPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialExpansionPanel1.CancelButtonText = ""
        Me.MaterialExpansionPanel1.Controls.Add(Me.Label3)
        Me.MaterialExpansionPanel1.Controls.Add(Me.Label2)
        Me.MaterialExpansionPanel1.Controls.Add(Me.PictureBox2)
        Me.MaterialExpansionPanel1.Depth = 0
        Me.MaterialExpansionPanel1.Description = "Ecco cosa puoi fare"
        Me.MaterialExpansionPanel1.ExpandHeight = 294
        Me.MaterialExpansionPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialExpansionPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialExpansionPanel1.Location = New System.Drawing.Point(870, 71)
        Me.MaterialExpansionPanel1.Margin = New System.Windows.Forms.Padding(3, 16, 3, 16)
        Me.MaterialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialExpansionPanel1.Name = "MaterialExpansionPanel1"
        Me.MaterialExpansionPanel1.Padding = New System.Windows.Forms.Padding(24, 64, 24, 16)
        Me.MaterialExpansionPanel1.Size = New System.Drawing.Size(548, 294)
        Me.MaterialExpansionPanel1.TabIndex = 5
        Me.MaterialExpansionPanel1.Title = "GameBuddies"
        Me.MaterialExpansionPanel1.ValidationButtonEnable = True
        Me.MaterialExpansionPanel1.ValidationButtonText = "Ho capito!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(4, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(293, 52)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "*Per giocare ai giochi consigliati è necessario averli comprati " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "e scaricati sul" &
    " proprio PC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "**Il meccanismo di attribuzione dei punti li ripartisce " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "l'account" &
    " di questo PC e quello del tuo amico" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 136)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Benessere.My.Resources.Resources.icons8_fidget_spinner
        Me.PictureBox2.Location = New System.Drawing.Point(38, 101)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.FirefoxButton1)
        Me.GroupBox2.Controls.Add(Me.FirefoxH12)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.MaterialDivider1)
        Me.GroupBox2.Location = New System.Drawing.Point(447, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(398, 413)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Altre modalità"
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Image = Global.Benessere.My.Resources.Resources.icons8_amici_64
        Me.PictureBox4.Location = New System.Drawing.Point(88, 229)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(232, 98)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'FirefoxButton1
        '
        Me.FirefoxButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FirefoxButton1.Enabled_ = True
        Me.FirefoxButton1.EnabledCalc = True
        Me.FirefoxButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FirefoxButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FirefoxButton1.Location = New System.Drawing.Point(88, 333)
        Me.FirefoxButton1.Name = "FirefoxButton1"
        Me.FirefoxButton1.Size = New System.Drawing.Size(232, 57)
        Me.FirefoxButton1.TabIndex = 3
        Me.FirefoxButton1.Text = "Inizia sessione di gioco a tempo"
        '
        'FirefoxH12
        '
        Me.FirefoxH12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FirefoxH12.AutoSize = True
        Me.FirefoxH12.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FirefoxH12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.FirefoxH12.Location = New System.Drawing.Point(102, 166)
        Me.FirefoxH12.Name = "FirefoxH12"
        Me.FirefoxH12.Size = New System.Drawing.Size(203, 37)
        Me.FirefoxH12.TabIndex = 2
        Me.FirefoxH12.Text = "Store dei Premi"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = Global.Benessere.My.Resources.Resources.flat_design2
        Me.PictureBox3.Location = New System.Drawing.Point(6, 24)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(386, 143)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(0, 213)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(398, 10)
        Me.MaterialDivider1.TabIndex = 0
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.Image = Global.Benessere.My.Resources.Resources.icons8_trophy
        Me.PictureBox5.Location = New System.Drawing.Point(628, 1)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(94, 54)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(15, 476)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(114, 17)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Scopri altri giochi!"
        '
        'MaterialExpansionPanel2
        '
        Me.MaterialExpansionPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialExpansionPanel2.CancelButtonText = ""
        Me.MaterialExpansionPanel2.Controls.Add(Me.Label1)
        Me.MaterialExpansionPanel2.Controls.Add(Me.PictureBox6)
        Me.MaterialExpansionPanel2.Depth = 0
        Me.MaterialExpansionPanel2.Description = "Sessione di gioco iniziata"
        Me.MaterialExpansionPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialExpansionPanel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialExpansionPanel2.Location = New System.Drawing.Point(297, 9)
        Me.MaterialExpansionPanel2.Margin = New System.Windows.Forms.Padding(3, 16, 3, 16)
        Me.MaterialExpansionPanel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialExpansionPanel2.Name = "MaterialExpansionPanel2"
        Me.MaterialExpansionPanel2.Padding = New System.Windows.Forms.Padding(24, 64, 24, 16)
        Me.MaterialExpansionPanel2.Size = New System.Drawing.Size(480, 240)
        Me.MaterialExpansionPanel2.TabIndex = 9
        Me.MaterialExpansionPanel2.Title = "BuddiesHub"
        Me.MaterialExpansionPanel2.ValidationButtonEnable = True
        Me.MaterialExpansionPanel2.ValidationButtonText = "Continua"
        Me.MaterialExpansionPanel2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(143, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 85)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "La vostra sessione di gioco è" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "incominciata: divertitevi a giocare" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "insieme ai vo" &
    "stri giochi preferiti" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mentre guadagnate numerosi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "punti premio!"
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox6.Image = Global.Benessere.My.Resources.Resources.icons8_calcio_2
        Me.PictureBox6.Location = New System.Drawing.Point(27, 62)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(77, 68)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 600000
        '
        'FirefoxButton2
        '
        Me.FirefoxButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FirefoxButton2.Enabled_ = False
        Me.FirefoxButton2.EnabledCalc = False
        Me.FirefoxButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FirefoxButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.FirefoxButton2.Location = New System.Drawing.Point(628, 61)
        Me.FirefoxButton2.Name = "FirefoxButton2"
        Me.FirefoxButton2.Size = New System.Drawing.Size(217, 23)
        Me.FirefoxButton2.TabIndex = 9
        Me.FirefoxButton2.Text = "Visualizza Punti Ospite"
        '
        'BuddiesHub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 500)
        Me.Controls.Add(Me.MaterialExpansionPanel2)
        Me.Controls.Add(Me.FirefoxButton2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.MaterialExpansionPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.FirefoxH11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "BuddiesHub"
        Me.Text = "BuddiesHub"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MaterialExpansionPanel1.ResumeLayout(False)
        Me.MaterialExpansionPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialExpansionPanel2.ResumeLayout(False)
        Me.MaterialExpansionPanel2.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FirefoxH11 As FirefoxH1
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Pts As Label
    Friend WithEvents MaterialExpansionPanel1 As MaterialSkin.Controls.MaterialExpansionPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents FirefoxH12 As FirefoxH1
    Friend WithEvents FirefoxButton1 As FirefoxButton
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents MaterialExpansionPanel2 As MaterialSkin.Controls.MaterialExpansionPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FirefoxButton2 As FirefoxButton
End Class
