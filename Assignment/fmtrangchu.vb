Public Class fmtrangchu
    Private Sub TìmKiếmSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmSáchToolStripMenuItem.Click
        fmtimsach.ShowDialog()
    End Sub

    Private Sub CậpNhậtThôngTinToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CậpNhậtThôngTinToolStripMenuItem.Click
        fmsanpham.ShowDialog()
    End Sub

    Private Sub TìmKiếmKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmKháchHàngToolStripMenuItem.Click
        fmtimkhachhang.ShowDialog()
    End Sub

    Private Sub CậpNhậtThôngTinToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CậpNhậtThôngTinToolStripMenuItem1.Click
        fmkhachhang.ShowDialog()
    End Sub

    Private Sub ThôngTinHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinHóaĐơnToolStripMenuItem.Click
        fmhoadon.ShowDialog()
    End Sub

    Private Sub ChiTiếtHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtHóaĐơnToolStripMenuItem.Click
        fmchitiethd.ShowDialog()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub fmtrangchu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Time.Tick
        lbthoigian.Text = DateAndTime.Now.ToString("dd/MM/yyyy - hh:mm:ss")
    End Sub
End Class