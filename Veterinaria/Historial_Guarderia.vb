Imports NEGOCIOS
Public Class Historial_Guarderia

    Dim guarderia As New GuarderiaN

    Private Sub btn_historial_volver_Click(sender As Object, e As EventArgs) Handles btn_historial_volver.Click
        Me.Close()
        Menu_Clientes.Show()
    End Sub

    Private Sub dtp_fecha_desde_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fecha_desde.ValueChanged
        dtp_fecha_hasta.MinDate = dtp_fecha_desde.Value
    End Sub

    Private Sub btn_ver_porfecha_Click(sender As Object, e As EventArgs) Handles btn_ver_porfecha.Click
        dgv_historial_guard.DataSource = guarderia.Historial_Guard(dtp_fecha_desde.Value, dtp_fecha_hasta.Value)
    End Sub

End Class