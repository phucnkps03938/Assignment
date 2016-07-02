Imports System.Data.SqlClient

Public Class fmkhachhang
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=(local);database=phucnkps03938_QLBH;trusted_connection=false;uid=sa;pwd=666999"
    Dim chuoiketnoi As String = "workstation id=QL-Sach-PS03938.mssql.somee.com;packet size=4096;user id=kfpipu2_SQLLogin_2;pwd=8pa2cx55r7;data source=QL-Sach-PS03938.mssql.somee.com;persist security info=False;initial catalog=QL-Sach-PS03938"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub fmkhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into KHACH_HANG values(@MA_KH,@HO_TEN,@DIA_CHI,@SDT)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtmakh.Focus()
            If txtmakh.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txthoten.Focus()
                If txthoten.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập họ tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtdiachi.Focus()
                    If txtsdt.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập số địa chỉ", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtmakh.Focus()
                        If txtsdt.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                        Else
                            save.Parameters.AddWithValue("@MA_KH", txtmakh.Text)
                            save.Parameters.AddWithValue("@HO_TEN", txthoten.Text)
                            save.Parameters.AddWithValue("@DIA_CHI", txtdiachi.Text)
                            save.Parameters.AddWithValue("@SDT", txtsdt.Text)
                            save.ExecuteNonQuery()
                            MessageBox.Show("Lưu thành công")
                            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                            txtmakh.Text = Nothing
                            txthoten.Text = Nothing
                            txtdiachi.Text = Nothing
                            txtsdt.Text = Nothing

                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select KHACH_HANG.MA_KH as 'Mã KH', HO_TEN as 'Họ Tên', DIA_CHI as 'Địa Chỉ', SDT as 'SĐT'from KHACH_HANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgvkhachhang.DataSource = db.DefaultView
    End Sub

    Private Sub btcapnhat_Click(sender As Object, e As EventArgs) Handles btcapnhat.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update KHACH_HANG set MA_KH=@MA_KH, HO_TEN=@HO_TEN, DIA_CHI=@DIA_CHI, SDT=@SDT where MA_KH=@MA_KH"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            addupdate.Parameters.AddWithValue("@MA_KH", txtmakh.Text)
            addupdate.Parameters.AddWithValue("@HO_TEN", txthoten.Text)
            addupdate.Parameters.AddWithValue("@DIA_CHI", txtdiachi.Text)
            addupdate.Parameters.AddWithValue("@SDT", txtsdt.Text)
            addupdate.ExecuteNonQuery()
            conn.Close() 'đóng kết nối
            MessageBox.Show("Cập nhật thành công")
            txtmakh.Focus()
            txtmakh.Text = Nothing
            txthoten.Text = Nothing
            txtdiachi.Text = Nothing
            txtsdt.Text = Nothing
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvkhachhang.DataSource = db
        dgvkhachhang.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim load As SqlDataAdapter = New SqlDataAdapter("select KHACH_HANG.MA_KH as 'Mã KH', HO_TEN as 'Họ Tên', DIA_CHI as 'Địa Chỉ', SDT as 'SĐT'from KHACH_HANG", conn)
        db.Clear()
        load.Fill(db)
        dgvkhachhang.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        Dim delquery As String = "delete from KHACH_HANG where MA_KH=@MA_KH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtmakh.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtmakh.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MA_KH", txtmakh.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtmakh.Text = Nothing
                    txthoten.Text = Nothing
                    txtdiachi.Text = Nothing
                    txtsdt.Text = Nothing
                    txtmakh.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã khách hàng cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvkhachhang.DataSource = db
        dgvkhachhang.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub dgvkhachhang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvkhachhang.CellContentClick
        Dim click As Integer = dgvkhachhang.CurrentCell.RowIndex
        txtmakh.Text = dgvkhachhang.Item(0, click).Value
        txthoten.Text = dgvkhachhang.Item(1, click).Value
        txtdiachi.Text = dgvkhachhang.Item(2, click).Value
        txtsdt.Text = dgvkhachhang.Item(3, click).Value
    End Sub
End Class