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
        Label1 = New Label()
        TabControl = New TabControl()
        TabPage1 = New TabPage()
        Panel2 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        comboDivisi = New ComboBox()
        txtNama = New TextBox()
        rbPerempuan = New RadioButton()
        txtID = New TextBox()
        rbLaki = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        PictureBox2 = New PictureBox()
        TabPage2 = New TabPage()
        Panel4 = New Panel()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Panel5 = New Panel()
        txtAlamat = New TextBox()
        txtNoTelp = New MaskedTextBox()
        txtEmail = New TextBox()
        TabPage3 = New TabPage()
        Panel8 = New Panel()
        btnBrowse = New Button()
        PictureBox1 = New PictureBox()
        Panel6 = New Panel()
        grpAktivitas = New GroupBox()
        cbGaming = New CheckBox()
        cbMatch = New CheckBox()
        cbRunning = New CheckBox()
        cbGym = New CheckBox()
        cbStrategy = New CheckBox()
        cbFielding = New CheckBox()
        cbPitch = New CheckBox()
        cbBatting = New CheckBox()
        btnCetak = New Button()
        GroupBox1 = New GroupBox()
        rbStaff = New RadioButton()
        rbManager = New RadioButton()
        rbPelatih = New RadioButton()
        rbAnggota = New RadioButton()
        rbWakil = New RadioButton()
        rbKetua = New RadioButton()
        Panel1.SuspendLayout()
        TabControl.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        TabPage3.SuspendLayout()
        Panel8.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        grpAktivitas.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(177), CByte(18), CByte(38))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1160, 117)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(258, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(625, 56)
        Label1.TabIndex = 1
        Label1.Text = "SEIDOU BASEBALL CLUB"
        ' 
        ' TabControl
        ' 
        TabControl.Controls.Add(TabPage1)
        TabControl.Controls.Add(TabPage2)
        TabControl.Controls.Add(TabPage3)
        TabControl.Location = New Point(0, 141)
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(1160, 699)
        TabControl.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Panel2)
        TabPage1.Location = New Point(8, 46)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1144, 645)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Navy
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Location = New Point(-8, -10)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1160, 589)
        Panel2.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(93, 407)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 33)
        Label6.TabIndex = 4
        Label6.Text = "Divisi"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(93, 325)
        Label5.Name = "Label5"
        Label5.Size = New Size(198, 33)
        Label5.TabIndex = 3
        Label5.Text = "Jenis Kelamin"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(93, 245)
        Label4.Name = "Label4"
        Label4.Size = New Size(191, 33)
        Label4.TabIndex = 2
        Label4.Text = "Tanggal Lahir"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(93, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(156, 33)
        Label3.TabIndex = 1
        Label3.Text = "ID Anggota"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(93, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 33)
        Label2.TabIndex = 0
        Label2.Text = "Nama"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.WhiteSmoke
        Panel3.Controls.Add(comboDivisi)
        Panel3.Controls.Add(txtNama)
        Panel3.Controls.Add(rbPerempuan)
        Panel3.Controls.Add(txtID)
        Panel3.Controls.Add(rbLaki)
        Panel3.Controls.Add(DateTimePicker1)
        Panel3.Location = New Point(434, 50)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(612, 413)
        Panel3.TabIndex = 11
        ' 
        ' comboDivisi
        ' 
        comboDivisi.Font = New Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        comboDivisi.FormattingEnabled = True
        comboDivisi.Items.AddRange(New Object() {"Pitcher", "Catcher", "Fielder", "Coach", "Manager", "Support"})
        comboDivisi.Location = New Point(32, 350)
        comboDivisi.Name = "comboDivisi"
        comboDivisi.Size = New Size(491, 41)
        comboDivisi.TabIndex = 10
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNama.Location = New Point(32, 27)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(491, 41)
        txtNama.TabIndex = 5
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.BackColor = Color.Transparent
        rbPerempuan.Font = New Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbPerempuan.Location = New Point(224, 275)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(196, 37)
        rbPerempuan.TabIndex = 9
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = False
        ' 
        ' txtID
        ' 
        txtID.Font = New Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtID.Location = New Point(32, 114)
        txtID.Name = "txtID"
        txtID.Size = New Size(491, 41)
        txtID.TabIndex = 6
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.BackColor = Color.Transparent
        rbLaki.Font = New Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rbLaki.Location = New Point(32, 275)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(162, 37)
        rbLaki.TabIndex = 8
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(32, 195)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(491, 39)
        DateTimePicker1.TabIndex = 7
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.seido
        PictureBox2.Location = New Point(79, 38)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(306, 425)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Panel4)
        TabPage2.Location = New Point(8, 46)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1144, 645)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Navy
        Panel4.Controls.Add(Label9)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(Panel5)
        Panel4.Location = New Point(-8, -9)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1160, 589)
        Panel4.TabIndex = 1
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(93, 347)
        Label9.Name = "Label9"
        Label9.Size = New Size(106, 33)
        Label9.TabIndex = 2
        Label9.Text = "Alamat"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(93, 237)
        Label10.Name = "Label10"
        Label10.Size = New Size(89, 33)
        Label10.TabIndex = 1
        Label10.Text = "Email"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(93, 119)
        Label11.Name = "Label11"
        Label11.Size = New Size(170, 33)
        Label11.TabIndex = 0
        Label11.Text = "No. Telepon"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.WhiteSmoke
        Panel5.Controls.Add(txtAlamat)
        Panel5.Controls.Add(txtNoTelp)
        Panel5.Controls.Add(txtEmail)
        Panel5.Location = New Point(434, 50)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(612, 413)
        Panel5.TabIndex = 11
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Font = New Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAlamat.Location = New Point(32, 297)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(491, 41)
        txtAlamat.TabIndex = 12
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Font = New Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNoTelp.Location = New Point(32, 69)
        txtNoTelp.Mask = "0000-0000-0000-0000"
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(491, 41)
        txtNoTelp.TabIndex = 11
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(32, 187)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(491, 41)
        txtEmail.TabIndex = 6
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Panel8)
        TabPage3.Controls.Add(Panel6)
        TabPage3.Location = New Point(8, 46)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1144, 645)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.Controls.Add(btnBrowse)
        Panel8.Controls.Add(PictureBox1)
        Panel8.Location = New Point(-8, 0)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(409, 578)
        Panel8.TabIndex = 12
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Font = New Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBrowse.Location = New Point(129, 496)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(150, 46)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(28, 30)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(343, 443)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Navy
        Panel6.Controls.Add(grpAktivitas)
        Panel6.Controls.Add(btnCetak)
        Panel6.Controls.Add(GroupBox1)
        Panel6.Location = New Point(389, -8)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(763, 589)
        Panel6.TabIndex = 2
        ' 
        ' grpAktivitas
        ' 
        grpAktivitas.Controls.Add(cbGaming)
        grpAktivitas.Controls.Add(cbMatch)
        grpAktivitas.Controls.Add(cbRunning)
        grpAktivitas.Controls.Add(cbGym)
        grpAktivitas.Controls.Add(cbStrategy)
        grpAktivitas.Controls.Add(cbFielding)
        grpAktivitas.Controls.Add(cbPitch)
        grpAktivitas.Controls.Add(cbBatting)
        grpAktivitas.Font = New Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpAktivitas.ForeColor = Color.White
        grpAktivitas.Location = New Point(45, 255)
        grpAktivitas.Name = "grpAktivitas"
        grpAktivitas.Size = New Size(674, 226)
        grpAktivitas.TabIndex = 12
        grpAktivitas.TabStop = False
        grpAktivitas.Text = "Aktivitas"
        ' 
        ' cbGaming
        ' 
        cbGaming.AutoSize = True
        cbGaming.Font = New Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbGaming.ForeColor = Color.White
        cbGaming.Location = New Point(394, 168)
        cbGaming.Name = "cbGaming"
        cbGaming.Size = New Size(140, 36)
        cbGaming.TabIndex = 19
        cbGaming.Text = "Gaming"
        cbGaming.UseVisualStyleBackColor = True
        ' 
        ' cbMatch
        ' 
        cbMatch.AutoSize = True
        cbMatch.Font = New Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbMatch.ForeColor = Color.White
        cbMatch.Location = New Point(394, 126)
        cbMatch.Name = "cbMatch"
        cbMatch.Size = New Size(230, 36)
        cbMatch.TabIndex = 18
        cbMatch.Text = "Match Analysis"
        cbMatch.UseVisualStyleBackColor = True
        ' 
        ' cbRunning
        ' 
        cbRunning.AutoSize = True
        cbRunning.Font = New Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbRunning.ForeColor = Color.White
        cbRunning.Location = New Point(394, 84)
        cbRunning.Name = "cbRunning"
        cbRunning.Size = New Size(147, 36)
        cbRunning.TabIndex = 17
        cbRunning.Text = "Running"
        cbRunning.UseVisualStyleBackColor = True
        ' 
        ' cbGym
        ' 
        cbGym.AutoSize = True
        cbGym.Font = New Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbGym.ForeColor = Color.White
        cbGym.Location = New Point(394, 42)
        cbGym.Name = "cbGym"
        cbGym.Size = New Size(207, 36)
        cbGym.TabIndex = 16
        cbGym.Text = "Gym Training"
        cbGym.UseVisualStyleBackColor = True
        ' 
        ' cbStrategy
        ' 
        cbStrategy.AutoSize = True
        cbStrategy.Font = New Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbStrategy.ForeColor = Color.White
        cbStrategy.Location = New Point(28, 168)
        cbStrategy.Name = "cbStrategy"
        cbStrategy.Size = New Size(257, 36)
        cbStrategy.TabIndex = 15
        cbStrategy.Text = "Strategy Analysis"
        cbStrategy.UseVisualStyleBackColor = True
        ' 
        ' cbFielding
        ' 
        cbFielding.AutoSize = True
        cbFielding.Font = New Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbFielding.ForeColor = Color.White
        cbFielding.Location = New Point(28, 126)
        cbFielding.Name = "cbFielding"
        cbFielding.Size = New Size(247, 36)
        cbFielding.TabIndex = 14
        cbFielding.Text = "Fielding Practice"
        cbFielding.UseVisualStyleBackColor = True
        ' 
        ' cbPitch
        ' 
        cbPitch.AutoSize = True
        cbPitch.Font = New Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbPitch.ForeColor = Color.White
        cbPitch.Location = New Point(28, 84)
        cbPitch.Name = "cbPitch"
        cbPitch.Size = New Size(210, 36)
        cbPitch.TabIndex = 13
        cbPitch.Text = "Pitch Training"
        cbPitch.UseVisualStyleBackColor = True
        ' 
        ' cbBatting
        ' 
        cbBatting.AutoSize = True
        cbBatting.Font = New Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbBatting.ForeColor = Color.White
        cbBatting.Location = New Point(28, 42)
        cbBatting.Name = "cbBatting"
        cbBatting.Size = New Size(200, 36)
        cbBatting.TabIndex = 12
        cbBatting.Text = "Batting Drills"
        cbBatting.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.Font = New Font("Arial", 10.125F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCetak.Location = New Point(45, 504)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(674, 46)
        btnCetak.TabIndex = 2
        btnCetak.Text = "Simpan dan Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbStaff)
        GroupBox1.Controls.Add(rbManager)
        GroupBox1.Controls.Add(rbPelatih)
        GroupBox1.Controls.Add(rbAnggota)
        GroupBox1.Controls.Add(rbWakil)
        GroupBox1.Controls.Add(rbKetua)
        GroupBox1.Font = New Font("Arial", 10.875F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(45, 38)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(674, 200)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Peran"
        ' 
        ' rbStaff
        ' 
        rbStaff.AutoSize = True
        rbStaff.Location = New Point(394, 143)
        rbStaff.Name = "rbStaff"
        rbStaff.Size = New Size(104, 37)
        rbStaff.TabIndex = 9
        rbStaff.TabStop = True
        rbStaff.Text = "Staff"
        rbStaff.UseVisualStyleBackColor = True
        ' 
        ' rbManager
        ' 
        rbManager.AutoSize = True
        rbManager.Location = New Point(394, 96)
        rbManager.Name = "rbManager"
        rbManager.Size = New Size(159, 37)
        rbManager.TabIndex = 8
        rbManager.TabStop = True
        rbManager.Text = "Manager"
        rbManager.UseVisualStyleBackColor = True
        ' 
        ' rbPelatih
        ' 
        rbPelatih.AutoSize = True
        rbPelatih.Location = New Point(394, 48)
        rbPelatih.Name = "rbPelatih"
        rbPelatih.Size = New Size(135, 37)
        rbPelatih.TabIndex = 7
        rbPelatih.TabStop = True
        rbPelatih.Text = "Pelatih"
        rbPelatih.UseVisualStyleBackColor = True
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(28, 143)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(153, 37)
        rbAnggota.TabIndex = 6
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbWakil
        ' 
        rbWakil.AutoSize = True
        rbWakil.Location = New Point(28, 96)
        rbWakil.Name = "rbWakil"
        rbWakil.Size = New Size(202, 37)
        rbWakil.TabIndex = 5
        rbWakil.TabStop = True
        rbWakil.Text = "Wakil Ketua"
        rbWakil.UseVisualStyleBackColor = True
        ' 
        ' rbKetua
        ' 
        rbKetua.AutoSize = True
        rbKetua.Location = New Point(28, 48)
        rbKetua.Name = "rbKetua"
        rbKetua.Size = New Size(121, 37)
        rbKetua.TabIndex = 4
        rbKetua.TabStop = True
        rbKetua.Text = "Ketua"
        rbKetua.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1160, 741)
        Controls.Add(TabControl)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabControl.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        TabPage3.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        grpAktivitas.ResumeLayout(False)
        grpAktivitas.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents comboDivisi As ComboBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNoTelp As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnBrowse As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbManager As RadioButton
    Friend WithEvents rbPelatih As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbWakil As RadioButton
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents btnCetak As Button
    Friend WithEvents rbStaff As RadioButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents grpAktivitas As GroupBox
    Friend WithEvents cbGaming As CheckBox
    Friend WithEvents cbMatch As CheckBox
    Friend WithEvents cbRunning As CheckBox
    Friend WithEvents cbGym As CheckBox
    Friend WithEvents cbStrategy As CheckBox
    Friend WithEvents cbFielding As CheckBox
    Friend WithEvents cbPitch As CheckBox
    Friend WithEvents cbBatting As CheckBox

End Class
