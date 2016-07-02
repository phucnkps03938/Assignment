Imports System.Data.SqlClient

Public Class fmchitiethd
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=(local);database=phucnkps03938_QLBH;trusted_connection=false;uid=sa;pwd=666999"
    Dim chuoiketnoi As String = "workstation id=QL-Sach-PS03938.mssql.somee.com;packet size=4096;user id=kfpipu2_SQLLogin_2;pwd=8pa2cx55r7;data source=QL-Sach-PS03938.mssql.somee.com;persist security info=False;initial catalog=QL-Sach-PS03938"
    Dim cthd As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub bttimkiem_Click(sender As Object, e As EventArgs) Handles bttimkiem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MA_HD as 'Mã hóa đơn', MA_SACH as 'Mã sách', NGAY_MUON as 'Ngày mượn', NGAY_TRA as 'Ngày trả' from CHI_TIET_HD where MA_HD= '" & txtmahd.Text & "'", connect)
        Try
            If txtmahd.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã hóa đơn để tìm tiếm", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvcthd.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvcthd.DataSource = db.DefaultView
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
        Dim cthd As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into CHI_TIET_HD values(@MA_HD,@MA_SACH,@NGAY_MUON,@NGAY_TRA)"
        Dim save As SqlCommand = New SqlCommand(query, cthd)
        cthd.Open()
        Try
            txtmahd.Focus()
            If txtmahd.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtmahd.Focus()
                If txtmasach.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập mã sách", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtmasach.Focus()
                    If txtbgaymuon.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập mã sách", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtmahd.Focus()
                        If txtngaytra.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập mã sách", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            save.Parameters.AddWithValue("@MA_HD", txtmahd.Text)
                            save.Parameters.AddWithValue("@MA_SACH", txtmasach.Text)
                            save.Parameters.AddWithValue("@NGAY_MUON", txtbgaymuon.Text)
                            save.Parameters.AddWithValue("@NGAY_TRA", txtngaytra.Text)
                            save.ExecuteNonQuery()
                            MessageBox.Show("Thêm thành công")
                            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                            txtmahd.Text = Nothing
                            txtmasach.Text = Nothing
                            txtbgaymuon.Text = Nothing
                            txtngaytra.Text = Nothing
                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã hóa đơn", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MA_HD as 'Mã hóa đơn', MA_SACH as 'Mã sách', NGAY_MUON as 'Ngày mượn', NGAY_TRA as 'Ngày trả' from CHI_TIET_HD", cthd)
        db.Clear()
        refesh.Fill(db)
        dgvcthd.DataSource = db.DefaultView
    End Sub

    Private Sub btcapnhat_Click(sender As Object, e As EventArgs) Handles btcapnhat.Click
        Dim cthd As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update CHI_TIET_HD set MA_HD=@MA_HD, MA_SACH=@MA_SACH, NGAY_MUON=@NGAY_MUON, NGAY_TRA=@NGAY_TRA where MA_HD=@MA_HD"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, cthd)
        cthd.Open()
        Try
            addupdate.Parameters.AddWithValue("@MA_HD", txtmahd.Text)
            addupdate.Parameters.AddWithValue("@MA_SACH", txtmasach.Text)
            addupdate.Parameters.AddWithValue("@NGAY_MUON", txtbgaymuon.Text)
            addupdate.Parameters.AddWithValue("@NGAY_TRA", txtngaytra.Text)
            addupdate.ExecuteNonQuery()
            cthd.Close() 'đóng kết nối
            MessageBox.Show("Cập nhật thành công")
            txtmahd.Focus()
            txtmahd.Text = Nothing
            txtmasach.Text = Nothing
            txtbgaymuon.Text = Nothing
            txtngaytra.Text = Nothing
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvcthd.DataSource = db
        dgvcthd.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim cthd As SqlConnection = New SqlConnection(chuoiketnoi)
        cthd.Open()
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MA_HD as 'Mã hóa đơn', MA_SACH as 'Mã sách', NGAY_MUON as 'Ngày mượn', NGAY_TRA as 'Ngày trả' from CHI_TIET_HD", cthd)
        db.Clear()
        load.Fill(db)
        dgvcthd.DataSource = db.DefaultView
        cthd.Close()
    End Sub

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        Dim delquery As String = "delete from CHI_TIET_HD where MA_HD=@MA_HD"
        Dim delete As SqlCommand = New SqlCommand(delquery, cthd)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        cthd.Open()
        Try
            If txtmahd.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã hóa đơn", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtmahd.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MA_HD", txtmahd.Text)
                    delete.ExecuteNonQuery()
                    cthd.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtmahd.Text = Nothing
                    txtmasach.Text = Nothing
                    txtbgaymuon.Text = Nothing
                    txtngaytra.Text = Nothing
                    txtmahd.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã hóa đơn cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvcthd.DataSource = db
        dgvcthd.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub dgvcthd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcthd.CellContentClick
        Dim click As Integer = dgvcthd.CurrentCell.RowIndex
        txtmahd.Text = dgvcthd.Item(0, click).Value
        txtmasach.Text = dgvcthd.Item(1, click).Value
        txtbgaymuon.Text = dgvcthd.Item(2, click).Value
        txtngaytra.Text = dgvcthd.Item(3, click).Value
    End Sub

    Private Sub fmchitiethd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
End Class