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
        PanelHeader = New Panel()
        Label1 = New Label()
        panelTambah = New Panel()
        btnTambah = New Button()
        txtGenre = New TextBox()
        txtJudul = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        listBuku = New ListBox()
        panelHapus = New Panel()
        btnHapus = New Button()
        txtHapus = New TextBox()
        Label6 = New Label()
        panelDaftar = New Panel()
        Label7 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label5 = New Label()
        PanelHeader.SuspendLayout()
        panelTambah.SuspendLayout()
        panelHapus.SuspendLayout()
        panelDaftar.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.DarkSlateBlue
        PanelHeader.Controls.Add(Label1)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(1140, 64)
        PanelHeader.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI Semibold", 16.125F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(257, 59)
        Label1.TabIndex = 0
        Label1.Text = "Library Mini"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' panelTambah
        ' 
        panelTambah.BackColor = Color.Lavender
        panelTambah.BorderStyle = BorderStyle.FixedSingle
        panelTambah.Controls.Add(btnTambah)
        panelTambah.Controls.Add(txtGenre)
        panelTambah.Controls.Add(txtJudul)
        panelTambah.Controls.Add(Label3)
        panelTambah.Controls.Add(Label2)
        panelTambah.Location = New Point(0, 116)
        panelTambah.Name = "panelTambah"
        panelTambah.Size = New Size(571, 272)
        panelTambah.TabIndex = 4
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(390, 201)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(150, 46)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(300, 131)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(200, 39)
        txtGenre.TabIndex = 3
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(300, 61)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(200, 39)
        txtJudul.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(80, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 32)
        Label3.TabIndex = 1
        Label3.Text = "Genre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(80, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 32)
        Label2.TabIndex = 0
        Label2.Text = "Judul Buku"
        ' 
        ' listBuku
        ' 
        listBuku.FormattingEnabled = True
        listBuku.Location = New Point(1, 440)
        listBuku.Name = "listBuku"
        listBuku.Size = New Size(1140, 228)
        listBuku.TabIndex = 7
        ' 
        ' panelHapus
        ' 
        panelHapus.BackColor = Color.MistyRose
        panelHapus.BorderStyle = BorderStyle.FixedSingle
        panelHapus.Controls.Add(btnHapus)
        panelHapus.Controls.Add(txtHapus)
        panelHapus.Controls.Add(Label6)
        panelHapus.Location = New Point(564, 116)
        panelHapus.Name = "panelHapus"
        panelHapus.Size = New Size(576, 272)
        panelHapus.TabIndex = 8
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(398, 201)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(150, 46)
        btnHapus.TabIndex = 2
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' txtHapus
        ' 
        txtHapus.Location = New Point(310, 61)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(200, 39)
        txtHapus.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(74, 61)
        Label6.Name = "Label6"
        Label6.RightToLeft = RightToLeft.No
        Label6.Size = New Size(132, 32)
        Label6.TabIndex = 0
        Label6.Text = "Judul Buku"
        ' 
        ' panelDaftar
        ' 
        panelDaftar.BackColor = Color.White
        panelDaftar.BorderStyle = BorderStyle.FixedSingle
        panelDaftar.Controls.Add(Label7)
        panelDaftar.Location = New Point(0, 386)
        panelDaftar.Name = "panelDaftar"
        panelDaftar.Size = New Size(1140, 58)
        panelDaftar.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(484, 11)
        Label7.Name = "Label7"
        Label7.Size = New Size(149, 32)
        Label7.TabIndex = 0
        Label7.Text = "Koleksi Buku"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(213, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(158, 32)
        Label4.TabIndex = 4
        Label4.Text = "Tambah Buku"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Lavender
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(0, 62)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(571, 54)
        Panel1.TabIndex = 10
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.MistyRose
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(564, 62)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(588, 54)
        Panel2.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(207, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(142, 32)
        Label5.TabIndex = 0
        Label5.Text = "Hapus Buku"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1140, 658)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(listBuku)
        Controls.Add(panelDaftar)
        Controls.Add(panelHapus)
        Controls.Add(panelTambah)
        Controls.Add(PanelHeader)
        Name = "Form1"
        Text = "Form1"
        PanelHeader.ResumeLayout(False)
        PanelHeader.PerformLayout()
        panelTambah.ResumeLayout(False)
        panelTambah.PerformLayout()
        panelHapus.ResumeLayout(False)
        panelHapus.PerformLayout()
        panelDaftar.ResumeLayout(False)
        panelDaftar.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents panelTambah As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents listBuku As ListBox
    Friend WithEvents panelHapus As Panel
    Friend WithEvents panelDaftar As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label7 As Label

End Class
