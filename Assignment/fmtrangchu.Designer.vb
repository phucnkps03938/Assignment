<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmtrangchu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmtrangchu))
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.ThưViệnSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TìmKiếmSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CậpNhậtThôngTinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TìmKiếmKháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CậpNhậtThôngTinToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinHóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChiTiếtHóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Time = New System.Windows.Forms.Timer(Me.components)
        Me.lbtime = New System.Windows.Forms.Label()
        Me.lbthoigian = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Menu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Menu
        '
        Me.Menu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Menu.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThưViệnSáchToolStripMenuItem, Me.KháchHàngToolStripMenuItem, Me.HóaĐơnToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(463, 25)
        Me.Menu.TabIndex = 0
        Me.Menu.Text = "Menu"
        '
        'ThưViệnSáchToolStripMenuItem
        '
        Me.ThưViệnSáchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TìmKiếmSáchToolStripMenuItem, Me.CậpNhậtThôngTinToolStripMenuItem})
        Me.ThưViệnSáchToolStripMenuItem.Name = "ThưViệnSáchToolStripMenuItem"
        Me.ThưViệnSáchToolStripMenuItem.Size = New System.Drawing.Size(103, 21)
        Me.ThưViệnSáchToolStripMenuItem.Text = "Thư viện sách"
        '
        'TìmKiếmSáchToolStripMenuItem
        '
        Me.TìmKiếmSáchToolStripMenuItem.Name = "TìmKiếmSáchToolStripMenuItem"
        Me.TìmKiếmSáchToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.TìmKiếmSáchToolStripMenuItem.Text = "Tìm kiếm sách"
        '
        'CậpNhậtThôngTinToolStripMenuItem
        '
        Me.CậpNhậtThôngTinToolStripMenuItem.Name = "CậpNhậtThôngTinToolStripMenuItem"
        Me.CậpNhậtThôngTinToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CậpNhậtThôngTinToolStripMenuItem.Text = "Quản lý thông tin sách"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TìmKiếmKháchHàngToolStripMenuItem, Me.CậpNhậtThôngTinToolStripMenuItem1})
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(91, 21)
        Me.KháchHàngToolStripMenuItem.Text = "Khách hàng"
        '
        'TìmKiếmKháchHàngToolStripMenuItem
        '
        Me.TìmKiếmKháchHàngToolStripMenuItem.Name = "TìmKiếmKháchHàngToolStripMenuItem"
        Me.TìmKiếmKháchHàngToolStripMenuItem.Size = New System.Drawing.Size(254, 22)
        Me.TìmKiếmKháchHàngToolStripMenuItem.Text = "Tìm kiếm khách hàng"
        '
        'CậpNhậtThôngTinToolStripMenuItem1
        '
        Me.CậpNhậtThôngTinToolStripMenuItem1.Name = "CậpNhậtThôngTinToolStripMenuItem1"
        Me.CậpNhậtThôngTinToolStripMenuItem1.Size = New System.Drawing.Size(254, 22)
        Me.CậpNhậtThôngTinToolStripMenuItem1.Text = "Cập nhật thông tin khách hàng"
        '
        'HóaĐơnToolStripMenuItem
        '
        Me.HóaĐơnToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThôngTinHóaĐơnToolStripMenuItem, Me.ChiTiếtHóaĐơnToolStripMenuItem})
        Me.HóaĐơnToolStripMenuItem.Name = "HóaĐơnToolStripMenuItem"
        Me.HóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(72, 21)
        Me.HóaĐơnToolStripMenuItem.Text = "Hóa đơn"
        '
        'ThôngTinHóaĐơnToolStripMenuItem
        '
        Me.ThôngTinHóaĐơnToolStripMenuItem.Name = "ThôngTinHóaĐơnToolStripMenuItem"
        Me.ThôngTinHóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ThôngTinHóaĐơnToolStripMenuItem.Text = "Thông tin hóa đơn"
        '
        'ChiTiếtHóaĐơnToolStripMenuItem
        '
        Me.ChiTiếtHóaĐơnToolStripMenuItem.Name = "ChiTiếtHóaĐơnToolStripMenuItem"
        Me.ChiTiếtHóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ChiTiếtHóaĐơnToolStripMenuItem.Text = "Chi tiết hóa đơn"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(54, 21)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'Time
        '
        Me.Time.Enabled = True
        Me.Time.Interval = 1000
        '
        'lbtime
        '
        Me.lbtime.AutoSize = True
        Me.lbtime.Location = New System.Drawing.Point(300, 4)
        Me.lbtime.Name = "lbtime"
        Me.lbtime.Size = New System.Drawing.Size(0, 17)
        Me.lbtime.TabIndex = 1
        '
        'lbthoigian
        '
        Me.lbthoigian.AutoSize = True
        Me.lbthoigian.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lbthoigian.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbthoigian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbthoigian.Location = New System.Drawing.Point(346, 5)
        Me.lbthoigian.Name = "lbthoigian"
        Me.lbthoigian.Size = New System.Drawing.Size(58, 15)
        Me.lbthoigian.TabIndex = 2
        Me.lbthoigian.Text = "Thời gian"
        Me.lbthoigian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.timely
        Me.PictureBox1.Location = New System.Drawing.Point(324, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Snap ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(118, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SVF BOOK MANAGER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fmtrangchu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment.My.Resources.Resources.nen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(463, 242)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbthoigian)
        Me.Controls.Add(Me.lbtime)
        Me.Controls.Add(Me.Menu)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Menu
        Me.Name = "fmtrangchu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý bán hàng"
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Menu As System.Windows.Forms.MenuStrip
    Friend WithEvents ThưViệnSáchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TìmKiếmSáchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CậpNhậtThôngTinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TìmKiếmKháchHàngToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CậpNhậtThôngTinToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HóaĐơnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThôngTinHóaĐơnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChiTiếtHóaĐơnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Time As System.Windows.Forms.Timer
    Friend WithEvents lbtime As System.Windows.Forms.Label
    Friend WithEvents lbthoigian As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
