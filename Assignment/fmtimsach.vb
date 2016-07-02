Imports System.Data.SqlClient

Public Class fmtimsach
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=(local);database=phucnkps03938_QLBH;trusted_connection=false;uid=sa;pwd=666999"
    Dim chuoiketnoi As String = "workstation id=QL-Sach-PS03938.mssql.somee.com;packet size=4096;user id=kfpipu2_SQLLogin_2;pwd=8pa2cx55r7;data source=QL-Sach-PS03938.mssql.somee.com;persist security info=False;initial catalog=QL-Sach-PS03938"
    Dim timkiem As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub bttmasach_Click(sender As Object, e As EventArgs) Handles bttmasach.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select MA_SACH as 'Mã sách', MA_TL as 'Mã thể loại', TEN_SACH as 'Tên sách', NOI_DUNG as 'Nội dung', TAC_GIA as 'Tác giả', NGAY_DAT_HANG as 'Ngày đặt hàng', TINH_TRANG as 'Tình trạng' FROM SACH where MA_SACH ='" & txttimma.Text & "' ", connect)
        Try
            If txttimma.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã sách", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvtimsach.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvtimsach.DataSource = db.DefaultView
                    txttimma.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txttimma.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btten_Click(sender As Object, e As EventArgs) Handles btten.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select MA_SACH as 'Mã sách', MA_TL as 'Mã thể loại', TEN_SACH as 'Tên sách', NOI_DUNG as 'Nội dung', TAC_GIA as 'Tác giả', NGAY_DAT_HANG as 'Ngày đặt hàng', TINH_TRANG as 'Tình trạng' FROM SACH where TEN_SACH like '%" & txttimten.Text & "%' ", connect)
        Try
            If txttimten.Text = "" Then
                MessageBox.Show("Bạn cần nhập tên sản phẩm", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvtimsach.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvtimsach.DataSource = db.DefaultView
                    txttimma.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txttimma.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MA_SACH as 'Mã sách', MA_TL as 'Mã thể loại', TEN_SACH as 'Tên sách', NOI_DUNG as 'Nội dung', TAC_GIA as 'Tác giả', NGAY_DAT_HANG as 'Ngày đặt hàng', TINH_TRANG as 'Tình trạng' FROM SACH", conn)
        db.Clear()
        load.Fill(db)
        dgvtimsach.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub fmtimsach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btdong_Click(sender As Object, e As EventArgs) Handles btdong.Click
        Me.Close()
    End Sub

    Private Sub btxem_Click(sender As Object, e As EventArgs) Handles btxem.Click
        LoadData()
        txttimma.Text = Nothing
        txttimten.Text = Nothing
        txttimma.Focus()
    End Sub
End Class