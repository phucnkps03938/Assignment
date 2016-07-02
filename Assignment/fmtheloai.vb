Imports System.Data.SqlClient

Public Class fmtheloai
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=(local);database=phucnkps03938_QLBH;trusted_connection=false;uid=sa;pwd=666999"
    Dim chuoiketnoi As String = "workstation id=QL-Sach-PS03938.mssql.somee.com;packet size=4096;user id=kfpipu2_SQLLogin_2;pwd=8pa2cx55r7;data source=QL-Sach-PS03938.mssql.somee.com;persist security info=False;initial catalog=QL-Sach-PS03938"
    Dim theloai As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btthem_Click(sender As Object, e As EventArgs) Handles btthem.Click
        Dim theloai As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into THE_LOAI values(@MA_TL,@TEN_TL)"
        Dim save As SqlCommand = New SqlCommand(query, theloai)
        theloai.Open()
        Try
            txtmatl.Focus()
            If txtmatl.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã thể loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtmatl.Focus()
                If txttentl.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập họ tên thể loại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    save.Parameters.AddWithValue("@MA_TL", txtmatl.Text)
                    save.Parameters.AddWithValue("@TEN_TL", txttentl.Text)
                    save.ExecuteNonQuery()
                    MessageBox.Show("Thêm thành công")
                    'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                    txtmatl.Text = Nothing
                    txttentl.Text = Nothing
                        End If
                    End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã thể loại", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MA_TL as 'Mã thể loại', TEN_TL as 'Tên thể loại' from THE_LOAI", theloai)
        db.Clear()
        refesh.Fill(db)
        dgvtheloai.DataSource = db.DefaultView
    End Sub

    Private Sub btxoa_Click(sender As Object, e As EventArgs) Handles btxoa.Click
        Dim delquery As String = "delete from THE_LOAI where MA_TL=@MA_TL"
        Dim delete As SqlCommand = New SqlCommand(delquery, theloai)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        theloai.Open()
        Try
            If txtmatl.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtmatl.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MA_TL", txtmatl.Text)
                    delete.ExecuteNonQuery()
                    theloai.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtmatl.Text = Nothing
                    txttentl.Text = Nothing
                    txtmatl.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã khách hàng cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvtheloai.DataSource = db
        dgvtheloai.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim theloai As SqlConnection = New SqlConnection(chuoiketnoi)
        theloai.Open()
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MA_TL as 'Mã thể loại' ,TEN_TL as 'Tên thể loại' from THE_LOAI", theloai)
        db.Clear()
        load.Fill(db)
        dgvtheloai.DataSource = db.DefaultView
        theloai.Close()
    End Sub

    Private Sub btcapnhat_Click(sender As Object, e As EventArgs) Handles btcapnhat.Click
        Dim theloai As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update THE_LOAI set MA_TL=@MA_TL, TEN_TL=@TEN_TL where MA_TL=@MA_TL"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, theloai)
        theloai.Open()
        Try
            addupdate.Parameters.AddWithValue("@MA_TL", txtmatl.Text)
            addupdate.Parameters.AddWithValue("@TEN_TL", txttentl.Text)
            addupdate.ExecuteNonQuery()
            theloai.Close() 'đóng kết nối
            MessageBox.Show("Cập nhật thành công")
            txtmatl.Focus()
            txtmatl.Text = Nothing
            txttentl.Text = Nothing
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvtheloai.DataSource = db
        dgvtheloai.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub fmtheloai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub dgvtheloai_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvtheloai.CellContentClick
        Dim click As Integer = dgvtheloai.CurrentCell.RowIndex
        txtmatl.Text = dgvtheloai.Item(0, click).Value
        txttentl.Text = dgvtheloai.Item(1, click).Value
    End Sub

    Private Sub bttimkiem_Click(sender As Object, e As EventArgs) Handles bttimkiem.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MA_TL as 'Mã thể loại', TEN_TL as 'Tên thể loại' from THE_LOAI where MA_TL= '" & txtmatl.Text & "'", connect)
        Try
            If txtmatl.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã thể loại để tìm tiếm", "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvtheloai.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvtheloai.DataSource = db.DefaultView
                    txtmatl.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtmatl.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class