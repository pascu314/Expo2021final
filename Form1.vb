Public Class Form1
    Private Sub FIFOToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FIFOToolStripMenuItem1.Click
        FrmFifo.Show()
        Me.Hide()
    End Sub

    Private Sub SJFToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SJFToolStripMenuItem1.Click
        FrmSjf.Show()
        Me.Hide()
    End Sub

    Private Sub PORPRIORIDADESToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PORPRIORIDADESToolStripMenuItem1.Click
        FrmPrioridades.Show()
        Me.Hide()
    End Sub

    Private Sub QUÉSONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QUÉSONToolStripMenuItem.Click
        FrmInfoQS.Show()
        Me.Hide()
    End Sub

    Private Sub FIFOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FIFOToolStripMenuItem.Click
        FrmInfoFIFO.Show()
        Me.Hide()
    End Sub

    Private Sub PORPRIORIDADESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PORPRIORIDADESToolStripMenuItem.Click
        FrmInfoPrioridades.Show()
        Me.Hide()
    End Sub

    Private Sub SJFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SJFToolStripMenuItem.Click
        FrmInfoSJF.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
End Class
