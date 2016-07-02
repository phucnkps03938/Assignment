<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmtimkhachhang
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
        Me.txttimmakh = New System.Windows.Forms.TextBox()
        Me.txttimtenkh = New System.Windows.Forms.TextBox()
        Me.dgvtimkh = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btdong = New System.Windows.Forms.Button()
        Me.bttimtenkh = New System.Windows.Forms.Button()
        Me.tbtimmakh = New System.Windows.Forms.Button()
        CType(Me.dgvtimkh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nhập mã khách hàng :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nhập tên khách hàng :"
        '
        'txttimmakh
        '
        Me.txttimmakh.Location = New System.Drawing.Point(165, 29)
        Me.txttimmakh.Name = "txttimmakh"
        Me.txttimmakh.Size = New System.Drawing.Size(116, 23)
        Me.txttimmakh.TabIndex = 1
        '
        'txttimtenkh
        '
        Me.txttimtenkh.Location = New System.Drawing.Point(165, 81)
        Me.txttimtenkh.Name = "txttimtenkh"
        Me.txttimtenkh.Size = New System.Drawing.Size(116, 23)
        Me.txttimtenkh.TabIndex = 1
        '
        'dgvtimkh
        '
        Me.dgvtimkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtimkh.Location = New System.Drawing.Point(45, 126)
        Me.dgvtimkh.Name = "dgvtimkh"
        Me.dgvtimkh.Size = New System.Drawing.Size(448, 150)
        Me.dgvtimkh.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Assignment.My.Resources.Resources.accept
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(413, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Xem all"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btdong
        '
        Me.btdong.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdong.Image = Global.Assignment.My.Resources.Resources.remove
        Me.btdong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btdong.Location = New System.Drawing.Point(411, 23)
        Me.btdong.Name = "btdong"
        Me.btdong.Size = New System.Drawing.Size(94, 32)
        Me.btdong.TabIndex = 4
        Me.btdong.Text = "Đóng"
        Me.btdong.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btdong.UseVisualStyleBackColor = True
        '
        'bttimtenkh
        '
        Me.bttimtenkh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttimtenkh.Image = Global.Assignment.My.Resources.Resources.themm
        Me.bttimtenkh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttimtenkh.Location = New System.Drawing.Point(296, 74)
        Me.bttimtenkh.Name = "bttimtenkh"
        Me.bttimtenkh.Size = New System.Drawing.Size(107, 35)
        Me.bttimtenkh.TabIndex = 2
        Me.bttimtenkh.Text = "Tìm tên KH"
        Me.bttimtenkh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttimtenkh.UseVisualStyleBackColor = True
        '
        'tbtimmakh
        '
        Me.tbtimmakh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbtimmakh.Image = Global.Assignment.My.Resources.Resources.timm
        Me.tbtimmakh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tbtimmakh.Location = New System.Drawing.Point(295, 23)
        Me.tbtimmakh.Name = "tbtimmakh"
        Me.tbtimmakh.Size = New System.Drawing.Size(108, 32)
        Me.tbtimmakh.TabIndex = 2
        Me.tbtimmakh.Text = "Tìm mã KH"
        Me.tbtimmakh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.tbtimmakh.UseVisualStyleBackColor = True
        '
        'fmtimkhachhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(525, 295)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btdong)
        Me.Controls.Add(Me.dgvtimkh)
        Me.Controls.Add(Me.bttimtenkh)
        Me.Controls.Add(Me.tbtimmakh)
        Me.Controls.Add(Me.txttimtenkh)
        Me.Controls.Add(Me.txttimmakh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "fmtimkhachhang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tìm kiếm khách hàng"
        CType(Me.dgvtimkh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttimmakh As System.Windows.Forms.TextBox
    Friend WithEvents txttimtenkh As System.Windows.Forms.TextBox
    Friend WithEvents tbtimmakh As System.Windows.Forms.Button
    Friend WithEvents bttimtenkh As System.Windows.Forms.Button
    Friend WithEvents dgvtimkh As System.Windows.Forms.DataGridView
    Friend WithEvents btdong As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
