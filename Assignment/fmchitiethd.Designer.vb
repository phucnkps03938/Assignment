<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmchitiethd
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmahd = New System.Windows.Forms.TextBox()
        Me.txtmasach = New System.Windows.Forms.TextBox()
        Me.txtbgaymuon = New System.Windows.Forms.TextBox()
        Me.txtngaytra = New System.Windows.Forms.TextBox()
        Me.dgvcthd = New System.Windows.Forms.DataGridView()
        Me.bttimkiem = New System.Windows.Forms.Button()
        Me.btthem = New System.Windows.Forms.Button()
        Me.btcapnhat = New System.Windows.Forms.Button()
        Me.btxoa = New System.Windows.Forms.Button()
        CType(Me.dgvcthd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã hóa đơn :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã sách :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(265, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ngày mượn :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(265, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ngày trả :"
        '
        'txtmahd
        '
        Me.txtmahd.Location = New System.Drawing.Point(132, 23)
        Me.txtmahd.Name = "txtmahd"
        Me.txtmahd.Size = New System.Drawing.Size(100, 23)
        Me.txtmahd.TabIndex = 1
        '
        'txtmasach
        '
        Me.txtmasach.Location = New System.Drawing.Point(132, 64)
        Me.txtmasach.Name = "txtmasach"
        Me.txtmasach.Size = New System.Drawing.Size(100, 23)
        Me.txtmasach.TabIndex = 1
        '
        'txtbgaymuon
        '
        Me.txtbgaymuon.Location = New System.Drawing.Point(347, 23)
        Me.txtbgaymuon.Name = "txtbgaymuon"
        Me.txtbgaymuon.Size = New System.Drawing.Size(100, 23)
        Me.txtbgaymuon.TabIndex = 1
        '
        'txtngaytra
        '
        Me.txtngaytra.Location = New System.Drawing.Point(347, 64)
        Me.txtngaytra.Name = "txtngaytra"
        Me.txtngaytra.Size = New System.Drawing.Size(100, 23)
        Me.txtngaytra.TabIndex = 1
        '
        'dgvcthd
        '
        Me.dgvcthd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvcthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcthd.Location = New System.Drawing.Point(29, 142)
        Me.dgvcthd.Name = "dgvcthd"
        Me.dgvcthd.Size = New System.Drawing.Size(444, 131)
        Me.dgvcthd.TabIndex = 2
        '
        'bttimkiem
        '
        Me.bttimkiem.Location = New System.Drawing.Point(69, 101)
        Me.bttimkiem.Name = "bttimkiem"
        Me.bttimkiem.Size = New System.Drawing.Size(75, 23)
        Me.bttimkiem.TabIndex = 3
        Me.bttimkiem.Text = "Tìm kiếm"
        Me.bttimkiem.UseVisualStyleBackColor = True
        '
        'btthem
        '
        Me.btthem.Location = New System.Drawing.Point(169, 101)
        Me.btthem.Name = "btthem"
        Me.btthem.Size = New System.Drawing.Size(75, 23)
        Me.btthem.TabIndex = 3
        Me.btthem.Text = "Thêm"
        Me.btthem.UseVisualStyleBackColor = True
        '
        'btcapnhat
        '
        Me.btcapnhat.Location = New System.Drawing.Point(265, 101)
        Me.btcapnhat.Name = "btcapnhat"
        Me.btcapnhat.Size = New System.Drawing.Size(75, 23)
        Me.btcapnhat.TabIndex = 3
        Me.btcapnhat.Text = "Cập nhật"
        Me.btcapnhat.UseVisualStyleBackColor = True
        '
        'btxoa
        '
        Me.btxoa.Location = New System.Drawing.Point(364, 101)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(75, 23)
        Me.btxoa.TabIndex = 3
        Me.btxoa.Text = "Xóa"
        Me.btxoa.UseVisualStyleBackColor = True
        '
        'fmchitiethd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(501, 296)
        Me.Controls.Add(Me.btxoa)
        Me.Controls.Add(Me.btcapnhat)
        Me.Controls.Add(Me.btthem)
        Me.Controls.Add(Me.bttimkiem)
        Me.Controls.Add(Me.dgvcthd)
        Me.Controls.Add(Me.txtngaytra)
        Me.Controls.Add(Me.txtbgaymuon)
        Me.Controls.Add(Me.txtmasach)
        Me.Controls.Add(Me.txtmahd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "fmchitiethd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chi tiết hóa đơn"
        CType(Me.dgvcthd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmahd As System.Windows.Forms.TextBox
    Friend WithEvents txtmasach As System.Windows.Forms.TextBox
    Friend WithEvents txtbgaymuon As System.Windows.Forms.TextBox
    Friend WithEvents txtngaytra As System.Windows.Forms.TextBox
    Friend WithEvents dgvcthd As System.Windows.Forms.DataGridView
    Friend WithEvents bttimkiem As System.Windows.Forms.Button
    Friend WithEvents btthem As System.Windows.Forms.Button
    Friend WithEvents btcapnhat As System.Windows.Forms.Button
    Friend WithEvents btxoa As System.Windows.Forms.Button
End Class
