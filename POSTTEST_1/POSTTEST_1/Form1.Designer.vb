<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblIPS = New System.Windows.Forms.Label()
        Me.lblIPK = New System.Windows.Forms.Label()
        Me.lblPredikat = New System.Windows.Forms.Label()
        Me.txtIPS = New System.Windows.Forms.TextBox()
        Me.txtIPK = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIPS
        '
        Me.lblIPS.AutoSize = True
        Me.lblIPS.Location = New System.Drawing.Point(240, 222)
        Me.lblIPS.Name = "lblIPS"
        Me.lblIPS.Size = New System.Drawing.Size(128, 25)
        Me.lblIPS.TabIndex = 0
        Me.lblIPS.Text = "IP Semester"
        '
        'lblIPK
        '
        Me.lblIPK.AutoSize = True
        Me.lblIPK.Location = New System.Drawing.Point(240, 327)
        Me.lblIPK.Name = "lblIPK"
        Me.lblIPK.Size = New System.Drawing.Size(126, 25)
        Me.lblIPK.TabIndex = 1
        Me.lblIPK.Text = "IP Kumulatif"
        '
        'lblPredikat
        '
        Me.lblPredikat.AutoSize = True
        Me.lblPredikat.Location = New System.Drawing.Point(491, 383)
        Me.lblPredikat.Name = "lblPredikat"
        Me.lblPredikat.Size = New System.Drawing.Size(19, 25)
        Me.lblPredikat.TabIndex = 2
        Me.lblPredikat.Text = "-"
        '
        'txtIPS
        '
        Me.txtIPS.Location = New System.Drawing.Point(496, 222)
        Me.txtIPS.Name = "txtIPS"
        Me.txtIPS.Size = New System.Drawing.Size(246, 31)
        Me.txtIPS.TabIndex = 3
        '
        'txtIPK
        '
        Me.txtIPK.BackColor = System.Drawing.Color.White
        Me.txtIPK.Location = New System.Drawing.Point(496, 327)
        Me.txtIPK.Name = "txtIPK"
        Me.txtIPK.ReadOnly = True
        Me.txtIPK.Size = New System.Drawing.Size(246, 31)
        Me.txtIPK.TabIndex = 4
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(496, 269)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(115, 41)
        Me.btnTambah.TabIndex = 5
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.IndianRed
        Me.btnReset.Location = New System.Drawing.Point(628, 269)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(114, 41)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1656, 1059)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtIPK)
        Me.Controls.Add(Me.txtIPS)
        Me.Controls.Add(Me.lblPredikat)
        Me.Controls.Add(Me.lblIPK)
        Me.Controls.Add(Me.lblIPS)
        Me.Name = "Form1"
        Me.Text = "Kalkulator IP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIPS As System.Windows.Forms.Label
    Friend WithEvents lblIPK As System.Windows.Forms.Label
    Friend WithEvents lblPredikat As System.Windows.Forms.Label
    Friend WithEvents txtIPS As System.Windows.Forms.TextBox
    Friend WithEvents txtIPK As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
