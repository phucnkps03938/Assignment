<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmhoadon
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
        Me.txtmahd = New System.Windows.Forms.TextBox()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.txtngaylap = New System.Windows.Forms.TextBox()
        Me.dgvhoadon = New System.Windows.Forms.DataGridView()
        Me.bttimkiem = New System.Windows.Forms.Button()
        Me.btthem = New System.Windows.Forms.Button()
        Me.btcapnhat = New System.Windows.Forms.Button()
        Me.btxoa = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvhoadon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã hóa đơn :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(187, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã khách hàng :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(372, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ngày lập :"
        '
        'txtmahd
        '
        Me.txtmahd.Location = New System.Drawing.Point(95, 24)
        Me.txtmahd.Name = "txtmahd"
        Me.txtmahd.Size = New System.Drawing.Size(81, 23)
        Me.txtmahd.TabIndex = 1
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(288, 24)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(81, 23)
        Me.txtmakh.TabIndex = 1
        '
        'txtngaylap
        '
        Me.txtngaylap.Location = New System.Drawing.Point(438, 24)
        Me.txtngaylap.Name = "txtngaylap"
        Me.txtngaylap.Size = New System.Drawing.Size(81, 23)
        Me.txtngaylap.TabIndex = 1
        '
        'dgvhoadon
        '
        Me.dgvhoadon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvhoadon.Location = New System.Drawing.Point(94, 107)
        Me.dgvhoadon.Name = "dgvhoadon"
        Me.dgvhoadon.Size = New System.Drawing.Size(361, 128)
        Me.dgvhoadon.TabIndex = 2
        '
        'bttimkiem
        '
        Me.bttimkiem.Location = New System.Drawing.Point(115, 64)
        Me.bttimkiem.Name = "bttimkiem"
        Me.bttimkiem.Size = New System.Drawing.Size(75, 23)
        Me.bttimkiem.TabIndex = 3
        Me.bttimkiem.Text = "Tìm kiếm"
        Me.bttimkiem.UseVisualStyleBackColor = True
        '
        'btthem
        '
        Me.btthem.Location = New System.Drawing.Point(196, 64)
        Me.btthem.Name = "btthem"
        Me.btthem.Size = New System.Drawing.Size(75, 23)
        Me.btthem.TabIndex = 4
        Me.btthem.Text = "Thêm"
        Me.btthem.UseVisualStyleBackColor = True
        '
        'btcapnhat
        '
        Me.btcapnhat.Location = New System.Drawing.Point(277, 64)
        Me.btcapnhat.Name = "btcapnhat"
        Me.btcapnhat.Size = New System.Drawing.Size(75, 23)
        Me.btcapnhat.TabIndex = 6
        Me.btcapnhat.Text = "Cập nhật"
        Me.btcapnhat.UseVisualStyleBackColor = True
        '
        'btxoa
        '
        Me.btxoa.Location = New System.Drawing.Point(358, 64)
        Me.btxoa.Name = "btxoa"
        Me.btxoa.Size = New System.Drawing.Size(75, 23)
        Me.btxoa.TabIndex = 7
        Me.btxoa.Text = "Xóa"
        Me.btxoa.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(437, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "(mm/dd/yyyy)"
        '
        'fmhoadon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(537, 260)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btxoa)
        Me.Controls.Add(Me.btcapnhat)
        Me.Controls.Add(Me.btthem)
        Me.Controls.Add(Me.bttimkiem)
        Me.Controls.Add(Me.dgvhoadon)
        Me.Controls.Add(Me.txtngaylap)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.txtmahd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "fmhoadon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hóa đơn"
        CType(Me.dgvhoadon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmahd As System.Windows.Forms.TextBox
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents txtngaylap As System.Windows.Forms.TextBox
    Friend WithEvents dgvhoadon As System.Windows.Forms.DataGridView
    Friend WithEvents bttimkiem As System.Windows.Forms.Button
    Friend WithEvents btthem As System.Windows.Forms.Button
    Friend WithEvents btcapnhat As System.Windows.Forms.Button
    Friend WithEvents btxoa As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
