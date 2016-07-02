Imports System.Data.SqlClient

Public Class fmtimkhachhang
    Dim db As New DataTable
    'Dim chuoiketnoi As String = "server=(local);database=phucnkps03938_QLBH;trusted_connection=false;uid=sa;pwd=666999"
    Dim chuoiketnoi As String = "workstation id=QL-Sach-PS03938.mssql.somee.com;packet size=4096;user id=kfpipu2_SQLLogin_2;pwd=8pa2cx55r7;data source=QL-Sach-PS03938.mssql.somee.com;persist security info=False;initial catalog=QL-Sach-PS03938"
    Dim timkiem As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub fmtimkhachhang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub tbtimmakh_Click(sender As Object, e As EventArgs) Handles tbtimmakh.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select MA_KH as 'Mã KH', HO_TEN as 'Họ Tên', DIA_CHI as 'Địa Chỉ', SDT as 'SĐT'from KHACH_HANG where MA_KH ='" & txttimmakh.Text & "' ", connect)
        Try
            If txttimmakh.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvtimkh.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvtimkh.DataSource = db.DefaultView
                    txttimmakh.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txttimmakh.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub bttimtenkh_Click(sender As Object, e As EventArgs) Handles bttimtenkh.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim timkiem As SqlDataAdapter = New SqlDataAdapter("select MA_KH as 'Mã KH', HO_TEN as 'Họ Tên', DIA_CHI as 'Địa Chỉ', SDT as 'SĐT'from KHACH_HANG where HO_TEN like '%" & txttimtenkh.Text & "%' ", connect)
        Try
            If txttimtenkh.Text = "" Then
                MessageBox.Show("Bạn cần nhập họ tên khách hàng", "Nhập thiếu", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                db.Clear()
                dgvtimkh.DataSource = Nothing
                timkiem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvtimkh.DataSource = db.DefaultView
                    txttimmakh.Text = Nothing
                Else
                    MessageBox.Show("Không tìm được")
                    txttimmakh.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MA_KH as 'Mã KH', HO_TEN as 'Họ Tên', DIA_CHI as 'Địa Chỉ', SDT as 'SĐT'from KHACH_HANG", conn)
        db.Clear()
        load.Fill(db)
        dgvtimkh.DataSource = db.DefaultView
        conn.Close()
    End Sub

    Private Sub btdong_Click(sender As Object, e As EventArgs) Handles btdong.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadData()
        txttimmakh.Focus()
        txttimmakh.Text = Nothing
        txttimtenkh.Text = Nothing
    End Sub
End Class