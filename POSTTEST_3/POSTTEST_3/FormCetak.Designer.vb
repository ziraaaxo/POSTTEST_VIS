<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formCetak
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
        panelHeader = New Panel()
        Label1 = New Label()
        picLogo = New PictureBox()
        panelMain = New Panel()
        panelData = New Panel()
        btnCetak = New Button()
        grpHobby = New GroupBox()
        cbOlahraga = New CheckBox()
        cbMenari = New CheckBox()
        cbTravel = New CheckBox()
        cbMemasak = New CheckBox()
        cbBerenang = New CheckBox()
        cbSeni = New CheckBox()
        cbMusik = New CheckBox()
        cbGaming = New CheckBox()
        cbMembaca = New CheckBox()
        cbBaseball = New CheckBox()
        grpGender = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        tanggalLahir = New DateTimePicker()
        txtAlamat = New TextBox()
        txtTlp = New TextBox()
        txtUmur = New TextBox()
        txtNama = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        btnBrowse = New Button()
        panelFoto = New Panel()
        picFoto = New PictureBox()
        panelHeader.SuspendLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        panelMain.SuspendLayout()
        panelData.SuspendLayout()
        grpHobby.SuspendLayout()
        grpGender.SuspendLayout()
        panelFoto.SuspendLayout()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' panelHeader
        ' 
        panelHeader.BackColor = Color.Red
        panelHeader.Controls.Add(Label1)
        panelHeader.Dock = DockStyle.Top
        panelHeader.Location = New Point(0, 0)
        panelHeader.Name = "panelHeader"
        panelHeader.Size = New Size(1124, 98)
        panelHeader.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(313, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(559, 56)
        Label1.TabIndex = 1
        Label1.Text = "SEIDOU HIGH SCHOOL"
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.Image = My.Resources.Resources.seido
        picLogo.Location = New Point(516, 0)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(302, 310)
        picLogo.SizeMode = PictureBoxSizeMode.StretchImage
        picLogo.TabIndex = 1
        picLogo.TabStop = False
        ' 
        ' panelMain
        ' 
        panelMain.BackColor = Color.White
        panelMain.Controls.Add(panelData)
        panelMain.Location = New Point(-9, 86)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(1181, 560)
        panelMain.TabIndex = 1
        ' 
        ' panelData
        ' 
        panelData.BackColor = Color.Navy
        panelData.Controls.Add(btnCetak)
        panelData.Controls.Add(grpHobby)
        panelData.Controls.Add(grpGender)
        panelData.Controls.Add(tanggalLahir)
        panelData.Controls.Add(txtAlamat)
        panelData.Controls.Add(txtTlp)
        panelData.Controls.Add(txtUmur)
        panelData.Controls.Add(txtNama)
        panelData.Controls.Add(picLogo)
        panelData.Controls.Add(Label6)
        panelData.Controls.Add(Label5)
        panelData.Controls.Add(Label4)
        panelData.Controls.Add(Label3)
        panelData.Controls.Add(Label2)
        panelData.Location = New Point(326, 0)
        panelData.Name = "panelData"
        panelData.Size = New Size(846, 560)
        panelData.TabIndex = 0
        ' 
        ' btnCetak
        ' 
        btnCetak.Location = New Point(35, 485)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(750, 46)
        btnCetak.TabIndex = 3
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' grpHobby
        ' 
        grpHobby.Controls.Add(cbOlahraga)
        grpHobby.Controls.Add(cbMenari)
        grpHobby.Controls.Add(cbTravel)
        grpHobby.Controls.Add(cbMemasak)
        grpHobby.Controls.Add(cbBerenang)
        grpHobby.Controls.Add(cbSeni)
        grpHobby.Controls.Add(cbMusik)
        grpHobby.Controls.Add(cbGaming)
        grpHobby.Controls.Add(cbMembaca)
        grpHobby.Controls.Add(cbBaseball)
        grpHobby.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpHobby.ForeColor = Color.White
        grpHobby.Location = New Point(271, 267)
        grpHobby.Name = "grpHobby"
        grpHobby.Size = New Size(514, 186)
        grpHobby.TabIndex = 12
        grpHobby.TabStop = False
        grpHobby.Text = "Hobby"
        ' 
        ' cbOlahraga
        ' 
        cbOlahraga.AutoSize = True
        cbOlahraga.Location = New Point(353, 71)
        cbOlahraga.Name = "cbOlahraga"
        cbOlahraga.Size = New Size(148, 33)
        cbOlahraga.TabIndex = 9
        cbOlahraga.Text = "Olahraga"
        cbOlahraga.UseVisualStyleBackColor = True
        ' 
        ' cbMenari
        ' 
        cbMenari.AutoSize = True
        cbMenari.Location = New Point(353, 38)
        cbMenari.Name = "cbMenari"
        cbMenari.Size = New Size(123, 33)
        cbMenari.TabIndex = 8
        cbMenari.Text = "Menari"
        cbMenari.UseVisualStyleBackColor = True
        ' 
        ' cbTravel
        ' 
        cbTravel.AutoSize = True
        cbTravel.Location = New Point(184, 135)
        cbTravel.Name = "cbTravel"
        cbTravel.Size = New Size(114, 33)
        cbTravel.TabIndex = 7
        cbTravel.Text = "Travel"
        cbTravel.UseVisualStyleBackColor = True
        ' 
        ' cbMemasak
        ' 
        cbMemasak.AutoSize = True
        cbMemasak.Location = New Point(184, 103)
        cbMemasak.Name = "cbMemasak"
        cbMemasak.Size = New Size(152, 33)
        cbMemasak.TabIndex = 6
        cbMemasak.Text = "Memasak"
        cbMemasak.UseVisualStyleBackColor = True
        ' 
        ' cbBerenang
        ' 
        cbBerenang.AutoSize = True
        cbBerenang.Location = New Point(184, 71)
        cbBerenang.Name = "cbBerenang"
        cbBerenang.Size = New Size(155, 33)
        cbBerenang.TabIndex = 5
        cbBerenang.Text = "Berenang"
        cbBerenang.UseVisualStyleBackColor = True
        ' 
        ' cbSeni
        ' 
        cbSeni.AutoSize = True
        cbSeni.Location = New Point(184, 38)
        cbSeni.Name = "cbSeni"
        cbSeni.Size = New Size(96, 33)
        cbSeni.TabIndex = 4
        cbSeni.Text = "Seni"
        cbSeni.UseVisualStyleBackColor = True
        ' 
        ' cbMusik
        ' 
        cbMusik.AutoSize = True
        cbMusik.Location = New Point(15, 135)
        cbMusik.Name = "cbMusik"
        cbMusik.Size = New Size(114, 33)
        cbMusik.TabIndex = 3
        cbMusik.Text = "Musik"
        cbMusik.UseVisualStyleBackColor = True
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Location = New Point(15, 103)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(135, 33)
        cbGaming.TabIndex = 2
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' cbMembaca
        ' 
        cbMembaca.AutoSize = True
        cbMembaca.Location = New Point(15, 71)
        cbMembaca.Name = "cbMembaca"
        cbMembaca.Size = New Size(154, 33)
        cbMembaca.TabIndex = 1
        cbMembaca.Text = "Membaca"
        cbMembaca.UseVisualStyleBackColor = True
        ' 
        ' cbBaseball
        ' 
        cbBaseball.AutoSize = True
        cbBaseball.Location = New Point(15, 38)
        cbBaseball.Name = "cbBaseball"
        cbBaseball.Size = New Size(143, 33)
        cbBaseball.TabIndex = 0
        cbBaseball.Text = "Baseball"
        cbBaseball.UseVisualStyleBackColor = True
        ' 
        ' grpGender
        ' 
        grpGender.Controls.Add(rbPerempuan)
        grpGender.Controls.Add(rbLaki)
        grpGender.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpGender.ForeColor = Color.White
        grpGender.Location = New Point(39, 267)
        grpGender.Name = "grpGender"
        grpGender.Size = New Size(210, 186)
        grpGender.TabIndex = 11
        grpGender.TabStop = False
        grpGender.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(23, 114)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(174, 33)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(23, 59)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(140, 33)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' tanggalLahir
        ' 
        tanggalLahir.Location = New Point(212, 118)
        tanggalLahir.Name = "tanggalLahir"
        tanggalLahir.Size = New Size(392, 39)
        tanggalLahir.TabIndex = 10
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(213, 217)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(391, 39)
        txtAlamat.TabIndex = 9
        ' 
        ' txtTlp
        ' 
        txtTlp.Location = New Point(213, 168)
        txtTlp.Name = "txtTlp"
        txtTlp.Size = New Size(391, 39)
        txtTlp.TabIndex = 8
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(212, 69)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(392, 39)
        txtUmur.TabIndex = 6
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(212, 18)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(393, 39)
        txtNama.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(39, 217)
        Label6.Name = "Label6"
        Label6.Size = New Size(92, 29)
        Label6.TabIndex = 4
        Label6.Text = "Alamat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(39, 168)
        Label5.Name = "Label5"
        Label5.Size = New Size(150, 29)
        Label5.TabIndex = 3
        Label5.Text = "No. Telepon"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(39, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(170, 29)
        Label4.TabIndex = 2
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(39, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 29)
        Label3.TabIndex = 1
        Label3.Text = "Umur"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Navy
        Label2.Font = New Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(39, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 29)
        Label2.TabIndex = 0
        Label2.Text = "Nama"
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(98, 485)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(150, 46)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' panelFoto
        ' 
        panelFoto.BackColor = Color.WhiteSmoke
        panelFoto.Controls.Add(btnBrowse)
        panelFoto.Controls.Add(picFoto)
        panelFoto.Location = New Point(-12, 86)
        panelFoto.Name = "panelFoto"
        panelFoto.Size = New Size(330, 560)
        panelFoto.TabIndex = 2
        ' 
        ' picFoto
        ' 
        picFoto.BackColor = Color.White
        picFoto.Location = New Point(35, 68)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(268, 338)
        picFoto.SizeMode = PictureBoxSizeMode.Zoom
        picFoto.TabIndex = 0
        picFoto.TabStop = False
        ' 
        ' formCetak
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1124, 629)
        Controls.Add(panelFoto)
        Controls.Add(panelMain)
        Controls.Add(panelHeader)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "formCetak"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormCetak"
        panelHeader.ResumeLayout(False)
        panelHeader.PerformLayout()
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        panelMain.ResumeLayout(False)
        panelData.ResumeLayout(False)
        panelData.PerformLayout()
        grpHobby.ResumeLayout(False)
        grpHobby.PerformLayout()
        grpGender.ResumeLayout(False)
        grpGender.PerformLayout()
        panelFoto.ResumeLayout(False)
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents panelMain As Panel
    Friend WithEvents panelFoto As Panel
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents panelData As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtTlp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents tanggalLahir As DateTimePicker
    Friend WithEvents grpGender As GroupBox
    Friend WithEvents grpHobby As GroupBox
    Friend WithEvents cbTravel As CheckBox
    Friend WithEvents cbMemasak As CheckBox
    Friend WithEvents cbBerenang As CheckBox
    Friend WithEvents cbSeni As CheckBox
    Friend WithEvents cbMusik As CheckBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbMembaca As CheckBox
    Friend WithEvents cbBaseball As CheckBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents cbOlahraga As CheckBox
    Friend WithEvents cbMenari As CheckBox

End Class
