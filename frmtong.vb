Public Class frmtong
    Private Sub ThôngTinKháchHàngToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ThôngTinKháchHàngToolStripMenuItem1.Click
        frmthongtinkh.Show()
        Me.Hide()
    End Sub

    Private Sub CậtNhậtKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CậtNhậtKháchHàngToolStripMenuItem.Click
        frmcapnhatkh.Show()
        Me.Hide()
    End Sub

    Private Sub ThôngTinSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThôngTinSảnPhẩmToolStripMenuItem.Click
        frmthongtinsp.Show()
        Me.Hide()
    End Sub

    Private Sub CậpNhậtSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CậpNhậtSảnPhẩmToolStripMenuItem.Click
        frmcatnhatsanpham.Show()
        Me.Hide()
    End Sub

    Private Sub ChiTiếtHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiTiếtHóaĐơnToolStripMenuItem.Click
        frmchitiethd.Show()
        Me.Hide()
    End Sub

    Private Sub ThôngTinỨngDụngToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmthongtin.Show()
        Me.Hide()
    End Sub

    Private Sub TìmKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKháchHàngToolStripMenuItem.Click
        frmsearch.Show()
        Me.Hide()
    End Sub
End Class
