Public Class frmPrincipal
    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim pantalla As New frmAcercade
        pantalla.ShowDialog()
    End Sub

    Private Sub CalcularMontoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularMontoToolStripMenuItem.Click
        Dim pantalla As New frmCalcularMonto
        pantalla.ShowDialog()
    End Sub

    Private Sub ConsultarTablaDeAmortizaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarTablaDeAmortizaciónToolStripMenuItem.Click
        Dim pantalla As New frmConsultarTabla
        pantalla.ShowDialog()
    End Sub

    Private Sub DatosRegistradosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosRegistradosToolStripMenuItem.Click
        Dim pantalla As New frmDatosRegistrados
        pantalla.ShowDialog()
    End Sub

    Private Sub MantenimientoDeInteresesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoDeInteresesToolStripMenuItem.Click
        Dim pantalla As New frmMantenimientoIntereses
        pantalla.ShowDialog()
    End Sub

    Private Sub ModificarTablaDeInteresesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarTablaDeInteresesToolStripMenuItem.Click
        Dim pantalla As New frmModificarTablaIntereses
        pantalla.ShowDialog()
    End Sub
End Class
