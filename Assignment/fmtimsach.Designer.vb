<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmtimsach
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
        Me.txttimma = New System.Windows.Forms.TextBox()
        Me.txttimten = New System.Windows.Forms.TextBox()
        Me.dgvtimsach = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btxem = New System.Windows.Forms.Button()
        Me.btdong = New System.Windows.Forms.Button()
        Me.btten = New System.Windows.Forms.Button()
        Me.bttmasach = New System.Windows.Forms.Button()
        CType(Me.dgvtimsach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(178, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nhập mã sách :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nhập tên sách"
        '
        'txttimma
        '
        Me.txttimma.Location = New System.Drawing.Point(273, 47)
        Me.txttimma.Name = "txttimma"
        Me.txttimma.Size = New System.Drawing.Size(120, 23)
        Me.txttimma.TabIndex = 3
        '
        'txttimten
        '
        Me.txttimten.Location = New System.Drawing.Point(273, 104)
        Me.txttimten.Name = "txttimten"
        Me.txttimten.Size = New System.Drawing.Size(120, 23)
        Me.txttimten.TabIndex = 3
        '
        'dgvtimsach
        '
        Me.dgvtimsach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvtimsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtimsach.Location = New System.Drawing.Point(24, 166)
        Me.dgvtimsach.Name = "dgvtimsach"
        Me.dgvtimsach.Size = New System.Drawing.Size(741, 150)
        Me.dgvtimsach.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.bia
        Me.PictureBox1.Location = New System.Drawing.Point(59, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btxem
        '
        Me.btxem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btxem.Image = Global.Assignment.My.Resources.Resources.accept
        Me.btxem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btxem.Location = New System.Drawing.Point(547, 99)
        Me.btxem.Name = "btxem"
        Me.btxem.Size = New System.Drawing.Size(91, 32)
        Me.btxem.TabIndex = 6
        Me.btxem.Text = "Xem all"
        Me.btxem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btxem.UseVisualStyleBackColor = True
        '
        'btdong
        '
        Me.btdong.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btdong.Image = Global.Assignment.My.Resources.Resources.remove
        Me.btdong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btdong.Location = New System.Drawing.Point(547, 41)
        Me.btdong.Name = "btdong"
        Me.btdong.Size = New System.Drawing.Size(91, 32)
        Me.btdong.TabIndex = 5
        Me.btdong.Text = "Đóng"
        Me.btdong.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btdong.UseVisualStyleBackColor = True
        '
        'btten
        '
        Me.btten.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btten.Image = Global.Assignment.My.Resources.Resources.themm
        Me.btten.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btten.Location = New System.Drawing.Point(421, 98)
        Me.btten.Name = "btten"
        Me.btten.Size = New System.Drawing.Size(111, 33)
        Me.btten.TabIndex = 2
        Me.btten.Text = "Tìm tên sách"
        Me.btten.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btten.UseVisualStyleBackColor = True
        '
        'bttmasach
        '
        Me.bttmasach.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttmasach.Image = Global.Assignment.My.Resources.Resources.timm
        Me.bttmasach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bttmasach.Location = New System.Drawing.Point(421, 41)
        Me.bttmasach.Name = "bttmasach"
        Me.bttmasach.Size = New System.Drawing.Size(111, 32)
        Me.bttmasach.TabIndex = 0
        Me.bttmasach.Text = "Tìm mã sách"
        Me.bttmasach.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.bttmasach.UseVisualStyleBackColor = True
        '
        'fmtimsach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(786, 340)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btxem)
        Me.Controls.Add(Me.btdong)
        Me.Controls.Add(Me.dgvtimsach)
        Me.Controls.Add(Me.txttimten)
        Me.Controls.Add(Me.txttimma)
        Me.Controls.Add(Me.btten)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bttmasach)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "fmtimsach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tìm kiếm sách"
        CType(Me.dgvtimsach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttmasach As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btten As System.Windows.Forms.Button
    Friend WithEvents txttimma As System.Windows.Forms.TextBox
    Friend WithEvents txttimten As System.Windows.Forms.TextBox
    Friend WithEvents dgvtimsach As System.Windows.Forms.DataGridView
    Friend WithEvents btdong As System.Windows.Forms.Button
    Friend WithEvents btxem As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
