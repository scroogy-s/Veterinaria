Imports NEGOCIOS

Public Class Alta_Vacunas
    Dim vacuna As New VacunasN

    Private Sub btn_aceptar_alta_vacuna_Click(sender As Object, e As EventArgs) Handles btn_aceptar_alta_vacuna.Click
        vacuna.insertarVacuna(txtbox_nombre_vacuna.Text, txtbox_descripcion_vacuna.Text)
        MsgBox("Vacuna agregada.", MsgBoxStyle.OkOnly, "Alta")
        Vacunas.Show()
        Me.Hide()
    End Sub

    Private Sub btn_volver_alta_vacuna_Click(sender As Object, e As EventArgs) Handles btn_volver_alta_vacuna.Click
        Vacunas.Show()
        Me.Close()
    End Sub

End Class