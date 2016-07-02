<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmtheloai
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmatl = New System.Windows.Forms.TextBox()
        Me.txttentl = New System.Windows.Forms.TextBox()
        Me.dgvtheloai = New System.Windows.Forms.DataGridView()
        Me.btthem = New System.Windows.Forms.Button()
        Me.btcapnhat = New System.Windows.Forms.Button()
        Me.bttimkiem = New System.Windows.Forms.Button()
        Me.btxoa = New System.Windows.Forms.Button()
        CType(Me.dgvtheloai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã thể loại:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tên thể loại:"
        '
        'txtmatl
        '
        Me.txtmatl.Location = New System.Drawing.Point(109, 22)
        Me.txtmatl.Name = "txtmatl"
        Me.txtmatl.Size = New System.Drawing.Size(100, 20)
        Me.txtmatl.TabIndex = 1
        '
        'txttentl
        '
        Me.txttentl.Location = New System.Drawing.Point(109, 65)
        Me.txttentl.Name = "txttentl"
        Me.txttentl.Size = New System.Drawing.Size(100, 20)
        Me.txttentl.TabIndex = 1
        '
        'dgvtheloai
        '
        Me.dgvtheloai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtheloai.Location = New System.Drawing.Point(32, 141)
        Me.dgvtheloai.Name = "dgvtheloai"
        Me.dgvtheloai.Size = New System.Drawing.Size(257, 150)
        Me.dgvtheloai.TabIndex = 2
        '
        'btthem
        '
        Me.btthem.Location = New System.Drawing.Point(28, 101)
        Me.btthem.Name = "btthem"
        Me.btthem.Size = New System.Drawing.Size(75, 23)
        Me.btthem.TabIndex = 3
        Me.btthem.Text = "Thêm"
        Me.btthem.UseVisualStyleBackColor = True
        '
        'btcapnhat
        '
        Me.btcapnhat.Location = New System.Drawing.Point(219, 63)
        Me.btcapnhat.Name = "btcapnhat"
        Me.btcapnhat.Size = New System.Drawing.Size(75, 23)
        Me.btcapnhat.TabIndex = 3
        Me.btcapnhat.Text = "Cập nhật"
        Me.btcapnhat.UseVisualStyleBackColor = True
        '
        'bttimkiem
        '
        Me.bttimkiem.Location = New System.Drawing.Point(219, 20)
        Me.bttimkiem.Name = "bttimkiem"
        Me.bttimkiem.Size = New System.Drawing.Size(75, 23)
        Me.bttimkiem.TabIndex = 3
        Me.bttimkiem.Text = "Tìm kiếm"
        Me.bttimkiem.UseVisualStyleBackColor = True
        '
        'btxoa
        '
        Me.btxoa.Location = New System.Drawing.Point(134, 101)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(75, 23)
        Me.btxoa.TabIndex = 3
        Me.btxoa.Text = "Xóa"
        Me.btxoa.UseVisualStyleBackColor = True
        '
        'fmtheloai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(326, 318)
        Me.Controls.Add(Me.btcapnhat)
        Me.Controls.Add(Me.btxoa)
        Me.Controls.Add(Me.bttimkiem)
        Me.Controls.Add(Me.btthem)
        Me.Controls.Add(Me.dgvtheloai)
        Me.Controls.Add(Me.txttentl)
        Me.Controls.Add(Me.txtmatl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fmtheloai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thể loại"
        CType(Me.dgvtheloai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtmatl As System.Windows.Forms.TextBox
    Friend WithEvents txttentl As System.Windows.Forms.TextBox
    Friend WithEvents dgvtheloai As System.Windows.Forms.DataGridView
    Friend WithEvents btthem As System.Windows.Forms.Button
    Friend WithEvents btcapnhat As System.Windows.Forms.Button
    Friend WithEvents bttimkiem As System.Windows.Forms.Button
    Friend WithEvents btxoa As System.Windows.Forms.Button
End Class
