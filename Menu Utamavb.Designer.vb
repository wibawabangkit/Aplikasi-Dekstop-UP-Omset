<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_Utama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Utama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerhitunganLabaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBarangToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TargetPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KalkulatorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TargetPenjualamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PekembanganUsahaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GantiPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.OptionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1349, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FileToolStripMenuItem.Text = "Action"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.UserToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerhitunganLabaToolStripMenuItem, Me.DataBarangToolStripMenuItem1, Me.TargetPenjualanToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'PerhitunganLabaToolStripMenuItem
        '
        Me.PerhitunganLabaToolStripMenuItem.Name = "PerhitunganLabaToolStripMenuItem"
        Me.PerhitunganLabaToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.PerhitunganLabaToolStripMenuItem.Text = "Perhitungan Laba"
        '
        'DataBarangToolStripMenuItem1
        '
        Me.DataBarangToolStripMenuItem1.Name = "DataBarangToolStripMenuItem1"
        Me.DataBarangToolStripMenuItem1.Size = New System.Drawing.Size(167, 22)
        Me.DataBarangToolStripMenuItem1.Text = "Data Barang"
        '
        'TargetPenjualanToolStripMenuItem
        '
        Me.TargetPenjualanToolStripMenuItem.Name = "TargetPenjualanToolStripMenuItem"
        Me.TargetPenjualanToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.TargetPenjualanToolStripMenuItem.Text = "Target Penjualan"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputBarangToolStripMenuItem, Me.KalkulatorToolStripMenuItem1, Me.TargetPenjualamToolStripMenuItem})
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'InputBarangToolStripMenuItem
        '
        Me.InputBarangToolStripMenuItem.Name = "InputBarangToolStripMenuItem"
        Me.InputBarangToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InputBarangToolStripMenuItem.Text = "Input Data Barang"
        '
        'KalkulatorToolStripMenuItem1
        '
        Me.KalkulatorToolStripMenuItem1.Name = "KalkulatorToolStripMenuItem1"
        Me.KalkulatorToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.KalkulatorToolStripMenuItem1.Text = "Kalkulator"
        '
        'TargetPenjualamToolStripMenuItem
        '
        Me.TargetPenjualamToolStripMenuItem.Name = "TargetPenjualamToolStripMenuItem"
        Me.TargetPenjualamToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TargetPenjualamToolStripMenuItem.Text = "Target Penjualam"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PekembanganUsahaToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'PekembanganUsahaToolStripMenuItem
        '
        Me.PekembanganUsahaToolStripMenuItem.Name = "PekembanganUsahaToolStripMenuItem"
        Me.PekembanganUsahaToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.PekembanganUsahaToolStripMenuItem.Text = "Pekembangan Usaha"
        '
        'OptionToolStripMenuItem
        '
        Me.OptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GantiPasswordToolStripMenuItem})
        Me.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem"
        Me.OptionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionToolStripMenuItem.Text = "Option"
        '
        'GantiPasswordToolStripMenuItem
        '
        Me.GantiPasswordToolStripMenuItem.Name = "GantiPasswordToolStripMenuItem"
        Me.GantiPasswordToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.GantiPasswordToolStripMenuItem.Text = "Ganti Password"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1349, 100)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label1.ImageKey = "(none)"
        Me.Label1.Location = New System.Drawing.Point(366, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(611, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELAMAT DATANG DI UPOMSET"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.UPomset.My.Resources.Resources.Pengertian_Istilah_Omset_dan_Profit_Dalam_Bisnis
        Me.PictureBox1.Location = New System.Drawing.Point(0, 117)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1349, 584)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Menu_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1349, 701)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Menu_Utama"
        Me.Text = "Menu_Utamavb"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerhitunganLabaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InputBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PekembanganUsahaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GantiPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataBarangToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents KalkulatorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TargetPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TargetPenjualamToolStripMenuItem As ToolStripMenuItem
End Class
