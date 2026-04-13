<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel4 = New Panel()
        txtSearch = New TextBox()
        Label6 = New Label()
        Panel3 = New Panel()
        DataGridView1 = New DataGridView()
        btnBatal = New Button()
        btnHapus = New Button()
        btnUbah = New Button()
        btnSimpan = New Button()
        Panel2 = New Panel()
        btnBuka = New Button()
        btnBrowse = New Button()
        txtFile = New TextBox()
        Label7 = New Label()
        txtTingkat = New TextBox()
        txtGenre = New TextBox()
        txtInstrumen = New TextBox()
        txtKomposer = New TextBox()
        txtJudul = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(167), CByte(216), CByte(245))
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(btnBatal)
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(btnUbah)
        Panel1.Controls.Add(btnSimpan)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-7, -8)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1966, 900)
        Panel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(246))
        Panel4.Controls.Add(txtSearch)
        Panel4.Controls.Add(Label6)
        Panel4.Location = New Point(805, 71)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1121, 112)
        Panel4.TabIndex = 0
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.Location = New Point(296, 41)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(322, 39)
        txtSearch.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(40, 41)
        Label6.Name = "Label6"
        Label6.Size = New Size(223, 35)
        Label6.TabIndex = 9
        Label6.Text = "Cari Partitur"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Silver
        Panel3.Controls.Add(DataGridView1)
        Panel3.Location = New Point(805, 68)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1117, 550)
        Panel3.TabIndex = 5
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(40, 153)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1038, 357)
        DataGridView1.TabIndex = 0
        ' 
        ' btnBatal
        ' 
        btnBatal.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBatal.Location = New Point(609, 638)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(150, 46)
        btnBatal.TabIndex = 4
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnHapus.Location = New Point(428, 638)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(150, 46)
        btnHapus.TabIndex = 3
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnUbah.Location = New Point(246, 638)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(150, 46)
        btnUbah.TabIndex = 2
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSimpan.Location = New Point(57, 638)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(150, 46)
        btnSimpan.TabIndex = 1
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(250), CByte(249), CByte(246))
        Panel2.Controls.Add(btnBuka)
        Panel2.Controls.Add(btnBrowse)
        Panel2.Controls.Add(txtFile)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(txtTingkat)
        Panel2.Controls.Add(txtGenre)
        Panel2.Controls.Add(txtInstrumen)
        Panel2.Controls.Add(txtKomposer)
        Panel2.Controls.Add(txtJudul)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(57, 68)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(702, 550)
        Panel2.TabIndex = 0
        ' 
        ' btnBuka
        ' 
        btnBuka.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBuka.Location = New Point(500, 464)
        btnBuka.Name = "btnBuka"
        btnBuka.Size = New Size(150, 46)
        btnBuka.TabIndex = 11
        btnBuka.Text = "Buka"
        btnBuka.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBrowse.Location = New Point(328, 464)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(150, 46)
        btnBrowse.TabIndex = 6
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' txtFile
        ' 
        txtFile.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFile.Location = New Point(328, 402)
        txtFile.Name = "txtFile"
        txtFile.Size = New Size(322, 39)
        txtFile.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(48, 402)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 35)
        Label7.TabIndex = 9
        Label7.Text = "File"
        ' 
        ' txtTingkat
        ' 
        txtTingkat.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTingkat.Location = New Point(328, 335)
        txtTingkat.Name = "txtTingkat"
        txtTingkat.Size = New Size(322, 39)
        txtTingkat.TabIndex = 8
        ' 
        ' txtGenre
        ' 
        txtGenre.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtGenre.Location = New Point(328, 269)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(322, 39)
        txtGenre.TabIndex = 7
        ' 
        ' txtInstrumen
        ' 
        txtInstrumen.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtInstrumen.Location = New Point(328, 204)
        txtInstrumen.Name = "txtInstrumen"
        txtInstrumen.Size = New Size(322, 39)
        txtInstrumen.TabIndex = 6
        ' 
        ' txtKomposer
        ' 
        txtKomposer.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtKomposer.Location = New Point(328, 137)
        txtKomposer.Name = "txtKomposer"
        txtKomposer.Size = New Size(322, 39)
        txtKomposer.TabIndex = 5
        ' 
        ' txtJudul
        ' 
        txtJudul.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJudul.Location = New Point(328, 76)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(322, 39)
        txtJudul.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(48, 335)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 35)
        Label5.TabIndex = 3
        Label5.Text = "Tingkat"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(48, 269)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 35)
        Label4.TabIndex = 2
        Label4.Text = "Genre"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(48, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(143, 35)
        Label3.TabIndex = 1
        Label3.Text = "Komposer"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(48, 204)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 35)
        Label2.TabIndex = 1
        Label2.Text = "Instrumen"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(48, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 35)
        Label1.TabIndex = 0
        Label1.Text = "Judul"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1956, 830)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtTingkat As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtInstrumen As TextBox
    Friend WithEvents txtKomposer As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtFile As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBuka As Button
    Friend WithEvents btnBrowse As Button

End Class
