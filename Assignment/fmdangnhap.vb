Public Class fmdangnhap

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btdangnhap.Click
        'kiểm tra mật khẩu và id
        If txtdangnhap.Text = "admin" And txtpass.Text = "admin" Then
            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            fmtrangchu.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("Vui lòng nhập đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btpass_Click(sender As Object, e As EventArgs) Handles btpass.Click
        Me.Close()
    End Sub

    Private Sub fmdangnhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class