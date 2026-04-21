<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label1 = New Label()
        DataGridView2 = New DataGridView()
        btnUbah = New Button()
        txtNamaInstrumen = New TextBox()
        btnHapus = New Button()
        btnSimpan = New Button()
        Label8 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(246))
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-7, -12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1138, 810)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(167), CByte(216), CByte(245))
        Panel2.Controls.Add(btnSimpan)
        Panel2.Controls.Add(btnHapus)
        Panel2.Controls.Add(DataGridView2)
        Panel2.Controls.Add(btnUbah)
        Panel2.Controls.Add(txtNamaInstrumen)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(112, 118)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(904, 548)
        Panel2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(69, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(271, 35)
        Label1.TabIndex = 1
        Label1.Text = "Tambah Instrumen"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(69, 223)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersWidth = 82
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.Size = New Size(760, 251)
        DataGridView2.TabIndex = 5
        ' 
        ' btnUbah
        ' 
        btnUbah.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUbah.Location = New Point(559, 128)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(132, 46)
        btnUbah.TabIndex = 6
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' txtNamaInstrumen
        ' 
        txtNamaInstrumen.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNamaInstrumen.Location = New Point(69, 130)
        txtNamaInstrumen.Name = "txtNamaInstrumen"
        txtNamaInstrumen.Size = New Size(340, 39)
        txtNamaInstrumen.TabIndex = 7
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnHapus.Location = New Point(697, 128)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(132, 46)
        btnHapus.TabIndex = 8
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimpan.Location = New Point(418, 128)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(132, 46)
        btnSimpan.TabIndex = 9
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(116, 69)
        Label8.Name = "Label8"
        Label8.Size = New Size(687, 35)
        Label8.TabIndex = 13
        Label8.Text = "Sistem Manajemen Inventaris Partitur Musik"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1120, 778)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnUbah As Button
    Friend WithEvents txtNamaInstrumen As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label8 As Label
End Class
