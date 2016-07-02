Imports System.Data.SqlClient

Public Class fmsanpham
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=(local);database=phucnkps03938_QLBH;trusted_connection=false;uid=sa;pwd=666999"
    Dim chuoiketnoi As String = "workstation id=QL-Sach-PS03938.mssql.somee.com;packet size=4096;user id=kfpipu2_SQLLogin_2;pwd=8pa2cx55r7;data source=QL-Sach-PS03938.mssql.somee.com;persist security info=False;initial catalog=QL-Sach-PS03938"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into SACH values(@MA_SACH,@MA_TL,@TEN_SACH,@NOI_DUNG,@TAC_GIA,@NGAY_DAT_HANG,@TINH_TRANG)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtmasach.Focus()
            If txtmasach.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sách", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtmasach.Focus()
                If txtmatheloai.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập mã thể loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtmatheloai.Focus()
                    If txttensach.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập tên sách", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txttensach.Focus()
                        If txtnoidung.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập nội dung", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtnoidung.Focus()
                            If txttacgia.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập tên tác giả", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else
                                txttacgia.Focus()
                                If txtngaydat.Text = "" Then
                                    MessageBox.Show("Bạn chưa nhập ngày đặt hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                Else
                                    txtmasach.Focus()
                                    If txttinhtrang.Text = "" Then
                                        MessageBox.Show("Bạn chưa nhập tình trạng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                                    Else
                                        save.Parameters.AddWithValue("@MA_SACH", txtmasach.Text)
                                        save.Parameters.AddWithValue("@MA_TL", txtmatheloai.Text)
                                        save.Parameters.AddWithValue("@TEN_SACH", txttensach.Text)
                                        save.Parameters.AddWithValue("@NOI_DUNG", txtnoidung.Text)
                                        save.Parameters.AddWithValue("@TAC_GIA", txttacgia.Text)
                                        save.Parameters.AddWithValue("@NGAY_DAT_HANG", txtngaydat.Text)
                                        save.Parameters.AddWithValue("@TINH_TRANG", txttinhtrang.Text)
                                        save.ExecuteNonQuery()
                                        MessageBox.Show("Thêm thành công")
                                        'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                                        txtmasach.Text = Nothing
                                        txtmatheloai.Text = Nothing
                                        txttensach.Text = Nothing
                                        txtnoidung.Text = Nothing
                                        txttacgia.Text = Nothing
                                        txtngaydat.Text = Nothing
                                        txttinhtrang.Text = Nothing
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã sản phẩm", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MA_SACH as 'Mã sách', MA_TL as 'Mã thể loại', TEN_SACH as 'Tên sách', NOI_DUNG as 'Nội dung', TAC_GIA as 'Tác giả', NGAY_DAT_HANG as 'Ngày đặt hàng', TINH_TRANG as 'Tình trạng' FROM SACH", conn)
        db.Clear()
        refesh.Fill(db)
        dgvqlsach.DataSource = db.DefaultView
    End Sub

    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MA_SACH as 'Mã sách', MA_TL as 'Mã thể loại', TEN_SACH as 'Tên sách', NOI_DUNG as 'Nội dung', TAC_GIA as 'Tác giả', NGAY_DAT_HANG as 'Ngày đặt hàng', TINH_TRANG as 'Tình trạng' FROM SACH", conn)
        db.Clear()
        load.Fill(db)
        dgvqlsach.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub fmsanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        Dim delquery As String = "delete from SACH where MA_SACH=@MA_SACH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtmasach.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtmasach.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MA_SACH", txtmasach.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtmasach.Text = Nothing
                    txtmatheloai.Text = Nothing
                    txttensach.Text = Nothing
                    txtnoidung.Text = Nothing
                    txttacgia.Text = Nothing
                    txtngaydat.Text = Nothing
                    txttinhtrang.Text = Nothing
                    txtmasach.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã sách cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvqlsach.DataSource = db
        dgvqlsach.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub dgvqlsach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvqlsach.CellContentClick
        Dim click As Integer = dgvqlsach.CurrentCell.RowIndex
        txtmasach.Text = dgvqlsach.Item(0, click).Value
        txtmatheloai.Text = dgvqlsach.Item(1, click).Value
        txttensach.Text = dgvqlsach.Item(2, click).Value
        txtnoidung.Text = dgvqlsach.Item(3, click).Value
        txttacgia.Text = dgvqlsach.Item(4, click).Value
        txtngaydat.Text = dgvqlsach.Item(5, click).Value
        txttinhtrang.Text = dgvqlsach.Item(6, click).Value
    End Sub

    Private Sub btcapnhat_Click(sender As Object, e As EventArgs) Handles btcapnhat.Click
        Dim sanpham As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update SACH set MA_SACH=@MA_SACH, MA_TL=@MA_TL, TEN_SACH=@TEN_SACH, NOI_DUNG=@NOI_DUNG, TAC_GIA=@TAC_GIA, NGAY_DAT_HANG=@NGAY_DAT_HANG, TINH_TRANG=@TINH_TRANG where MA_SACH=@MA_SACH"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, sanpham)
        sanpham.Open()
        Try
            addupdate.Parameters.AddWithValue("@MA_SACH", txtmasach.Text)
            addupdate.Parameters.AddWithValue("@MA_TL", txtmatheloai.Text)
            addupdate.Parameters.AddWithValue("@TEN_SACH", txttensach.Text)
            addupdate.Parameters.AddWithValue("@NOI_DUNG", txtnoidung.Text)
            addupdate.Parameters.AddWithValue("@TAC_GIA", txttacgia.Text)
            addupdate.Parameters.AddWithValue("@NGAY_DAT_HANG", txtngaydat.Text)
            addupdate.Parameters.AddWithValue("@TINH_TRANG", txttinhtrang.Text)
            addupdate.ExecuteNonQuery()
            sanpham.Close() 'đóng kết nối
            MessageBox.Show("Cập nhật thành công")
            txtmasach.Focus()
            txtmasach.Text = Nothing
            txtmatheloai.Text = Nothing
            txttensach.Text = Nothing
            txtnoidung.Text = Nothing
            txttacgia.Text = Nothing
            txtngaydat.Text = Nothing
            txttinhtrang.Text = Nothing
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvqlsach.DataSource = db
        dgvqlsach.DataSource = Nothing
        LoadData()
    End Sub
End Class