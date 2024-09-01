<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActvitiesChart
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
        Me.FirefoxH11 = New Benessere.FirefoxH1()
        Me.FormsPlot1 = New ScottPlot.FormsPlot()
        Me.FirefoxH21 = New Benessere.FirefoxH2()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.SuspendLayout()
        '
        'FirefoxH11
        '
        Me.FirefoxH11.AutoSize = True
        Me.FirefoxH11.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FirefoxH11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.FirefoxH11.Location = New System.Drawing.Point(12, 9)
        Me.FirefoxH11.Name = "FirefoxH11"
        Me.FirefoxH11.Size = New System.Drawing.Size(304, 37)
        Me.FirefoxH11.TabIndex = 0
        Me.FirefoxH11.Text = "Ore di gioco giornaliere"
        '
        'FormsPlot1
        '
        Me.FormsPlot1.Location = New System.Drawing.Point(12, 153)
        Me.FormsPlot1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.FormsPlot1.Name = "FormsPlot1"
        Me.FormsPlot1.Size = New System.Drawing.Size(600, 512)
        Me.FormsPlot1.TabIndex = 2
        '
        'FirefoxH21
        '
        Me.FirefoxH21.AutoSize = True
        Me.FirefoxH21.BackColor = System.Drawing.Color.Transparent
        Me.FirefoxH21.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FirefoxH21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.FirefoxH21.Location = New System.Drawing.Point(12, 115)
        Me.FirefoxH21.Name = "FirefoxH21"
        Me.FirefoxH21.Size = New System.Drawing.Size(83, 19)
        Me.FirefoxH21.TabIndex = 3
        Me.FirefoxH21.Text = "FirefoxH21"
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(12, 49)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(996, 10)
        Me.MaterialDivider1.TabIndex = 21
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'ActvitiesChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 697)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.FirefoxH21)
        Me.Controls.Add(Me.FormsPlot1)
        Me.Controls.Add(Me.FirefoxH11)
        Me.Name = "ActvitiesChart"
        Me.Text = "ActvitiesChart"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FirefoxH11 As FirefoxH1
    Friend WithEvents FormsPlot1 As ScottPlot.FormsPlot
    Friend WithEvents FirefoxH21 As FirefoxH2
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
End Class
