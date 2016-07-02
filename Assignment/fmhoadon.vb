Imports System.Data.SqlClient

Public Class fmhoadon
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=(local);database=phucnkps03938_QLBH;trusted_connection=false;uid=sa;pwd=666999"
    Dim chuoiketnoi As String = "workstation id=QL-Sach-PS03938.mssql.somee.com;packet size=4096;user id=kfpipu2_SQLLogin_2;pwd=8pa2cx55r7;data source=QL-Sach-PS03938.mssql.somee.com;persist security info=False;initial catalog=QL-Sach-PS03938"
    Dim hoadon As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub bttimkiem_Click(sender As Object, e As EventArgs) Handles bttimkiem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MA_HD as 'Mã hóa đơn', MA_KH as 'Mã khách hàng', NGAY_LAP as 'Ngày lập' from HOA_DON where MA_HD= '" & txtmahd.Text & "'", connect)
        Try
            If txtmahd.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã hóa đơn để tìm tiếm", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvhoadon.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvhoadon.DataSource = db.DefaultView
                    txtmahd.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtmahd.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click
        Dim hoadon As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into HOA_DON values(@MA_HD,@MA_KH,@NGAY_LAP)"
        Dim save As SqlCommand = New SqlCommand(query, hoadon)
        hoadon.Open()
        Try
            txtmahd.Focus()
            If txtmahd.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtmakh.Focus()
                If txtmakh.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtmahd.Focus()
                    If txtmakh.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập ngày lập hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        save.Parameters.AddWithValue("@MA_HD", txtmahd.Text)
                        save.Parameters.AddWithValue("@MA_KH", txtmakh.Text)
                        save.Parameters.AddWithValue("@NGAY_LAP", txtngaylap.Text)
                        save.ExecuteNonQuery()
                        MessageBox.Show("Thêm thành công")
                        'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                        txtmahd.Text = Nothing
                        txtmakh.Text = Nothing
                        txtngaylap.Text = Nothing
                    End If
                End If
            End If

        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã thể loại", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MA_HD as 'Mã hóa đơn', MA_KH as 'Mã Khách hàng', NGAY_LAP as 'Ngày lập' from HOA_DON", hoadon)
        db.Clear()
        refesh.Fill(db)
        dgvhoadon.DataSource = db.DefaultView
    End Sub

    Private Sub btcapnhat_Click(sender As Object, e As EventArgs) Handles btcapnhat.Click
        Dim hoadon As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update HOA_DON set MA_HD=@MA_HD, MA_KH=@MA_KH, NGAY_LAP=@NGAY_LAP where MA_HD=@MA_HD"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, hoadon)
        hoadon.Open()
        Try
            addupdate.Parameters.AddWithValue("@MA_HD", txtmahd.Text)
            addupdate.Parameters.AddWithValue("@MA_KH", txtmakh.Text)
            addupdate.Parameters.AddWithValue("@NGAY_LAP", txtngaylap.Text)
            addupdate.ExecuteNonQuery()
            hoadon.Close() 'đóng kết nối
            MessageBox.Show("Cập nhật thành công")
            txtmahd.Focus()
            txtmahd.Text = Nothing
            txtmakh.Text = Nothing
            txtngaylap.Text = Nothing
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvhoadon.DataSource = db
        dgvhoadon.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim hoadon As SqlConnection = New SqlConnection(chuoiketnoi)
        hoadon.Open()
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MA_HD as 'Mã hóa đơn', MA_KH as 'Mã Khách hàng', NGAY_LAP as 'Ngày lập' from HOA_DON", hoadon)
        db.Clear()
        load.Fill(db)
        dgvhoadon.DataSource = db.DefaultView
        hoadon.Close()
    End Sub


    Private Sub dgvhoadon_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvhoadon.CellContentClick
        Dim click As Integer = dgvhoadon.CurrentCell.RowIndex
        txtmahd.Text = dgvhoadon.Item(0, click).Value
        txtmakh.Text = dgvhoadon.Item(1, click).Value
        txtngaylap.Text = dgvhoadon.Item(2, click).Value
    End Sub

    Private Sub fmhoadon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        Dim delquery As String = "delete from HOA_DON where MA_HD=@MA_HD"
        Dim delete As SqlCommand = New SqlCommand(delquery, hoadon)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        hoadon.Open()
        Try
            If txtmahd.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtmahd.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MA_HD", txtmahd.Text)
                    delete.ExecuteNonQuery()
                    hoadon.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtmahd.Text = Nothing
                    txtmakh.Text = Nothing
                    txtngaylap.Text = Nothing
                    txtmahd.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã hóa đơn cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvhoadon.DataSource = db
        dgvhoadon.DataSource = Nothing
        LoadData()
    End Sub
End Class