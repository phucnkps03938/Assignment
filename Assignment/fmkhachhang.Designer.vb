<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmkhachhang
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
        Me.dgvkhachhang = New System.Windows.Forms.DataGridView()
        Me.makh = New System.Windows.Forms.Label()
        Me.hoten = New System.Windows.Forms.Label()
        Me.diachi = New System.Windows.Forms.Label()
        Me.tsdt = New System.Windows.Forms.Label()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.txthoten = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.btthem = New System.Windows.Forms.Button()
        Me.btcapnhat = New System.Windows.Forms.Button()
        Me.btxoa = New System.Windows.Forms.Button()
        CType(Me.dgvkhachhang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvkhachhang
        '
        Me.dgvkhachhang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkhachhang.Location = New System.Drawing.Point(74, 178)
        Me.dgvkhachhang.Name = "dgvkhachhang"
        Me.dgvkhachhang.Size = New System.Drawing.Size(452, 152)
        Me.dgvkhachhang.TabIndex = 1
        '
        'makh
        '
        Me.makh.AutoSize = True
        Me.makh.BackColor = System.Drawing.Color.OldLace
        Me.makh.Location = New System.Drawing.Point(74, 29)
        Me.makh.Name = "makh"
        Me.makh.Size = New System.Drawing.Size(85, 13)
        Me.makh.TabIndex = 2
        Me.makh.Text = "Mã khách hàng:"
        '
        'hoten
        '
        Me.hoten.AutoSize = True
        Me.hoten.BackColor = System.Drawing.Color.OldLace
        Me.hoten.Location = New System.Drawing.Point(335, 29)
        Me.hoten.Name = "hoten"
        Me.hoten.Size = New System.Drawing.Size(57, 13)
        Me.hoten.TabIndex = 3
        Me.hoten.Text = "Họ và tên:"
        '
        'diachi
        '
        Me.diachi.AutoSize = True
        Me.diachi.BackColor = System.Drawing.Color.OldLace
        Me.diachi.Location = New System.Drawing.Point(74, 73)
        Me.diachi.Name = "diachi"
        Me.diachi.Size = New System.Drawing.Size(43, 13)
        Me.diachi.TabIndex = 4
        Me.diachi.Text = "Địa chỉ:"
        '
        'tsdt
        '
        Me.tsdt.AutoSize = True
        Me.tsdt.BackColor = System.Drawing.Color.OldLace
        Me.tsdt.Location = New System.Drawing.Point(333, 75)
        Me.tsdt.Name = "tsdt"
        Me.tsdt.Size = New System.Drawing.Size(73, 13)
        Me.tsdt.TabIndex = 5
        Me.tsdt.Text = "Số điện thoại:"
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(199, 26)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(100, 20)
        Me.txtmakh.TabIndex = 6
        '
        'txthoten
        '
        Me.txthoten.Location = New System.Drawing.Point(426, 26)
        Me.txthoten.Name = "txthoten"
        Me.txthoten.Size = New System.Drawing.Size(100, 20)
        Me.txthoten.TabIndex = 6
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(199, 70)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(100, 20)
        Me.txtdiachi.TabIndex = 6
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(426, 70)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(100, 20)
        Me.txtsdt.TabIndex = 6
        '
        'btthem
        '
        Me.btthem.Location = New System.Drawing.Point(128, 120)
        Me.btthem.Name = "btthem"
        Me.btthem.Size = New System.Drawing.Size(75, 23)
        Me.btthem.TabIndex = 7
        Me.btthem.Text = "Thêm"
        Me.btthem.UseVisualStyleBackColor = True
        '
        'btcapnhat
        '
        Me.btcapnhat.Location = New System.Drawing.Point(252, 120)
        Me.btcapnhat.Name = "btcapnhat"
        Me.btcapnhat.Size = New System.Drawing.Size(75, 23)
        Me.btcapnhat.TabIndex = 8
        Me.btcapnhat.Text = "Cập nhật"
        Me.btcapnhat.UseVisualStyleBackColor = True
        '
        'btxoa
        '
        Me.btxoa.Location = New System.Drawing.Point(376, 120)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(75, 23)
        Me.btxoa.TabIndex = 9
        Me.btxoa.Text = "Xóa"
        Me.btxoa.UseVisualStyleBackColor = True
        '
        'fmkhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(598, 368)
        Me.Controls.Add(Me.btxoa)
        Me.Controls.Add(Me.btcapnhat)
        Me.Controls.Add(Me.btthem)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txthoten)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.tsdt)
        Me.Controls.Add(Me.diachi)
        Me.Controls.Add(Me.hoten)
        Me.Controls.Add(Me.makh)
        Me.Controls.Add(Me.dgvkhachhang)
        Me.Name = "fmkhachhang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý khách hàng"
        CType(Me.dgvkhachhang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvkhachhang As System.Windows.Forms.DataGridView
    Friend WithEvents makh As System.Windows.Forms.Label
    Friend WithEvents hoten As System.Windows.Forms.Label
    Friend WithEvents diachi As System.Windows.Forms.Label
    Friend WithEvents tsdt As System.Windows.Forms.Label
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents txthoten As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents btthem As System.Windows.Forms.Button
    Friend WithEvents btcapnhat As System.Windows.Forms.Button
    Friend WithEvents btxoa As System.Windows.Forms.Button
End Class
