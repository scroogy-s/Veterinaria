Imports NEGOCIOS
Public Class Alta_ATP
    Dim atp1 As New AntiparasitariosN

    Private Sub btn_aceptar_alta_atp_Click(sender As Object, e As EventArgs) Handles btn_aceptar_alta_atp.Click
        atp1.insertarATP(txtbox_nombre_atp.Text)
        MsgBox("Antiparasitario agregado.", MsgBoxStyle.OkOnly, "Alta")
        ATP.Show()
        Me.Close()
    End Sub

    Private Sub btn_volver_alta_atp_Click(sender As Object, e As EventArgs) Handles btn_volver_alta_atp.Click
        ATP.Show()
        Me.Close()
    End Sub
End Class