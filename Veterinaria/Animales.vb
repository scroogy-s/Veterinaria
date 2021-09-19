Imports NEGOCIOS
Public Class Animales
    Dim tabla_animal As New AnimalesN
    Dim animal As New AnimalesN

    Private Sub btn_alta_animal_Click(sender As Object, e As EventArgs) Handles btn_alta_animal.Click
        Me.Close()
        Alta_Animales.Show()
    End Sub

    Private Sub btn_volver_animal_Click(sender As Object, e As EventArgs) Handles btn_volver_animal.Click
        Me.Close()
        Administracion.Show()
    End Sub

    Private Sub Animales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_animales.DataSource = tabla_animal.mostrarAnimales_Especies()
        dgv_animales.Columns(0).Visible = False
        dgv_animales.Columns(2).Visible = False
    End Sub

    Private Sub btn_baja_atp_Click(sender As Object, e As EventArgs) Handles btn_baja_atp.Click
        Dim mensaje As String
        mensaje = "¿Seguro elimina la raza: " + dgv_animales.SelectedRows(0).Cells("Raza").Value.ToString + "?"
        If MsgBox(mensaje, MsgBoxStyle.YesNo, "Baja") = 6 Then
            animal.eliminarAnimal(dgv_animales.SelectedRows(0).Cells(0).Value)
            MsgBox("Eliminación realizada con exito.", MsgBoxStyle.OkOnly, "Fin de Operación")
            dgv_animales.DataSource = tabla_animal.mostrarAnimales_Especies()
            dgv_animales.Columns(0).Visible = False
            dgv_animales.Columns(2).Visible = False
        End If
    End Sub
End Class