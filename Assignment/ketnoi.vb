Imports System.Data.SqlClient

Public Class ketnoi
    Public Function Loadkhachhang() As DataSet
        'Dim chuoiketnoi As String = "server=(local);database=phucnkps03938_QLBH;trusted_connection=false;uid=sa;pwd=666999"
        Dim chuoiketnoi As String = "workstation id=QL-Sach-PS03938.mssql.somee.com;packet size=4096;user id=kfpipu2_SQLLogin_2;pwd=8pa2cx55r7;data source=QL-Sach-PS03938.mssql.somee.com;persist security info=False;initial catalog=QL-Sach-PS03938"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MA_KH as 'Mã KH', HO_TEN as 'Họ Tên', DIA_CHI as 'Địa Chỉ', SDT as 'SĐT'from KHACH_HANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadtheloai() As DataSet
        'Dim chuoiketnoi As String = "server=(local);database=phucnkps03938_QLBH;trusted_connection=false;uid=sa;pwd=666999"
        Dim chuoiketnoi As String = "workstation id=QL-Sach-PS03938.mssql.somee.com;packet size=4096;user id=kfpipu2_SQLLogin_2;pwd=8pa2cx55r7;data source=QL-Sach-PS03938.mssql.somee.com;persist security info=False;initial catalog=QL-Sach-PS03938"
        Dim theloai As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadTL As New SqlDataAdapter("select MA_TL as 'Mã thể loại', TEN_TL as 'Tên thể loại' from THE_LOAI", theloai)
        Dim db As New DataSet
        theloai.Open()
        LoadTL.Fill(db)
        theloai.Close()
        Return db
    End Function
    Public Function LoadSach() As DataSet
        'Dim chuoiketnoi As String = "server=(local);database=phucnkps03938_QLBH;trusted_connection=false;uid=sa;pwd=666999"
        Dim chuoiketnoi As String = "workstation id=QL-Sach-PS03938.mssql.somee.com;packet size=4096;user id=kfpipu2_SQLLogin_2;pwd=8pa2cx55r7;data source=QL-Sach-PS03938.mssql.somee.com;persist security info=False;initial catalog=QL-Sach-PS03938"
        Dim sach As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadS As New SqlDataAdapter("select MA_SACH as 'Mã sách', MA_TL as 'Mã thể loại', TEN_SACH as 'Tên sách', NOI_DUNG as 'Nội dung', TAC_GIA as 'Tác giả', NGAY_DAT_HANG as 'Ngày đặt hàng', TINH_TRANG as 'Tình trạng' FROM SACH", sach)
        Dim db As New DataSet
        sach.Open()
        LoadS.Fill(db)
        sach.Close()
        Return db
    End Function
    Public Function Loadhoadon() As DataSet
        'Dim chuoiketnoi As String = "server=(local);database=phucnkps03938_QLBH;trusted_connection=false;uid=sa;pwd=666999"
        Dim chuoiketnoi As String = "workstation id=QL-Sach-PS03938.mssql.somee.com;packet size=4096;user id=kfpipu2_SQLLogin_2;pwd=8pa2cx55r7;data source=QL-Sach-PS03938.mssql.somee.com;persist security info=False;initial catalog=QL-Sach-PS03938"
        Dim hoadon As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadHD As New SqlDataAdapter("select MA_HD as 'Mã hóa đơn', MA_KH as 'Mã Khách hàng', NGAY_LAP as 'Ngày lập' from HOA_DON", hoadon)
        Dim db As New DataSet
        hoadon.Open()
        LoadHD.Fill(db)
        hoadon.Close()
        Return db
    End Function
    Public Function Loadcthd() As DataSet
        'Dim chuoiketnoi As String = "server=(local);database=phucnkps03938_QLBH;trusted_connection=false;uid=sa;pwd=666999"
        Dim chuoiketnoi As String = "workstation id=QL-Sach-PS03938.mssql.somee.com;packet size=4096;user id=kfpipu2_SQLLogin_2;pwd=8pa2cx55r7;data source=QL-Sach-PS03938.mssql.somee.com;persist security info=False;initial catalog=QL-Sach-PS03938"
        Dim cthd As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim Loadct As New SqlDataAdapter("select MA_HD as 'Mã hóa đơn', MA_SACH as 'Mã sách', NGAY_MUON as 'Ngày mượn', NGAY_TRA as 'Ngày trả' from CHI_TIET_HD", cthd)
        Dim db As New DataSet
        cthd.Open()
        Loadct.Fill(db)
        cthd.Close()
        Return db
    End Function
End Class
