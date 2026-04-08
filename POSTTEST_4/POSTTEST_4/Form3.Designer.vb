<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        menuInput = New ToolStripMenuItem()
        menuLihat = New ToolStripMenuItem()
        menuSimpan = New ToolStripMenuItem()
        menuBuka = New ToolStripMenuItem()
        menuKeluar = New ToolStripMenuItem()
        Panel2 = New Panel()
        Panel3 = New Panel()
        MenuStrip2 = New MenuStrip()
        Me.menuInput = New ToolStripMenuItem()
        Me.menuLihat = New ToolStripMenuItem()
        Me.menuSimpan = New ToolStripMenuItem()
        Me.menuBuka = New ToolStripMenuItem()
        menuKeluar = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Panel1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        MenuStrip2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(177), CByte(18), CByte(38))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1158, 95)
        Panel1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(262, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(625, 56)
        Label1.TabIndex = 1
        Label1.Text = "SEIDOU BASEBALL CLUB"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.ImageScalingSize = New Size(32, 32)
        MenuStrip1.Items.AddRange(New ToolStripItem() {menuInput, menuLihat, menuSimpan, menuBuka, menuKeluar})
        MenuStrip1.Location = New Point(214, 46)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(715, 40)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        menuInput.Name = "InputDataToolStripMenuItem"
        menuInput.Size = New Size(146, 36)
        menuInput.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        menuLihat.Name = "LihatKartuToolStripMenuItem"
        menuLihat.Size = New Size(148, 36)
        menuLihat.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        menuSimpan.Name = "SimpanDataToolStripMenuItem"
        menuSimpan.Size = New Size(170, 36)
        menuSimpan.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        menuBuka.Name = "BukaDataToolStripMenuItem"
        menuBuka.Size = New Size(142, 36)
        menuBuka.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        menuKeluar.Name = "KeluarToolStripMenuItem"
        menuKeluar.Size = New Size(101, 36)
        menuKeluar.Text = "Keluar"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Navy
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(0, 224)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1158, 496)
        Panel2.TabIndex = 5
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Black
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(0, 89)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1161, 89)
        Panel3.TabIndex = 6
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.Dock = DockStyle.None
        MenuStrip2.ImageScalingSize = New Size(32, 32)
        MenuStrip2.Items.AddRange(New ToolStripItem() {Me.menuInput, Me.menuLihat, Me.menuSimpan, Me.menuBuka, menuKeluar})
        MenuStrip2.Location = New Point(227, 181)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(715, 40)
        MenuStrip2.TabIndex = 7
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' menuInput
        ' 
        Me.menuInput.Name = "menuInput"
        Me.menuInput.Size = New Size(146, 36)
        Me.menuInput.Text = "Input Data"
        ' 
        ' menuLihat
        ' 
        Me.menuLihat.Name = "menuLihat"
        Me.menuLihat.Size = New Size(148, 36)
        Me.menuLihat.Text = "Lihat Kartu"
        ' 
        ' menuSimpan
        ' 
        Me.menuSimpan.Name = "menuSimpan"
        Me.menuSimpan.Size = New Size(170, 36)
        Me.menuSimpan.Text = "Simpan Data"
        ' 
        ' menuBuka
        ' 
        Me.menuBuka.Name = "menuBuka"
        Me.menuBuka.Size = New Size(142, 36)
        Me.menuBuka.Text = "Buka Data"
        ' 
        ' menuKeluar
        ' 
        menuKeluar.Name = "menuKeluar"
        menuKeluar.Size = New Size(101, 36)
        menuKeluar.Text = "Keluar"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.seido
        PictureBox1.Location = New Point(314, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(540, 469)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 16.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Gold
        Label2.Location = New Point(397, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(352, 51)
        Label2.TabIndex = 0
        Label2.Text = "MEMBER CARD"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1158, 704)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        Controls.Add(MenuStrip2)
        Controls.Add(Panel3)
        MainMenuStrip = MenuStrip2
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menuInput As ToolStripMenuItem
    Friend WithEvents menuLihat As ToolStripMenuItem
    Friend WithEvents menuSimpan As ToolStripMenuItem
    Friend WithEvents menuBuka As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents menuKeluar As ToolStripMenuItem
End Class
