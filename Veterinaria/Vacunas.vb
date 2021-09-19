Imports NEGOCIOS

Public Class Vacunas
    Dim tablavacuna As New VacunasN
    Dim vacuna As New VacunasN

    Private Sub Vacunas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_vacunas.DataSource = tablavacuna.mostrarVacunas()
        dgv_vacunas.Columns(0).Visible = False
        dgv_vacunas.Columns(2).Visible = False
        textbox_descripcion_vacuna.Text = dgv_vacunas.SelectedRows(0).Cells("datosExtras").Value
    End Sub

    Private Sub btn_baja_vacuna_Click(sender As Object, e As EventArgs) Handles btn_baja_vacuna.Click
        Dim mensaje As String
        mensaje = "¿Seguro elimina la Vacuna: " + dgv_vacunas.SelectedRows(0).Cells("nombre").Value.ToString + "?"
        If MsgBox(mensaje, MsgBoxStyle.YesNo, "Baja") = 6 Then
            vacuna.eliminarVacuna(dgv_vacunas.SelectedRows(0).Cells(0).Value)
            MsgBox("Eliminación realizada con exito.", MsgBoxStyle.OkOnly, "Fin de Operación")
            dgv_vacunas.DataSource = tablavacuna.mostrarVacunas()
            dgv_vacunas.Columns(0).Visible = False
            dgv_vacunas.Columns(2).Visible = False
        End If
    End Sub

    Private Sub btn_volver_vacuna_Click(sender As Object, e As EventArgs) Handles btn_volver_vacuna.Click
        Administracion.Show()
        Me.Close()
    End Sub

    Private Sub btn_alta_vacuna_Click(sender As Object, e As EventArgs) Handles btn_alta_vacuna.Click
        Me.Close()
        Alta_Vacunas.Show()
    End Sub

    Private Sub dgv_vacunas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_vacunas.CellClick
        textbox_descripcion_vacuna.Text = dgv_vacunas.SelectedRows(0).Cells("datosExtras").Value
    End Sub
End Class