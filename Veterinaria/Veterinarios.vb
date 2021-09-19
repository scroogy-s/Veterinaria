Imports NEGOCIOS

Public Class Veterinarios

    Dim veterinario As New VeterinariosN

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Close()
        Administracion.Show()
    End Sub

    Private Sub Veterinarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_veterinarios.DataSource = veterinario.mostrar_Veterinarios()
        dgv_veterinarios.Columns(0).Visible = False
    End Sub

    Private Sub btn_alta_vet_Click(sender As Object, e As EventArgs) Handles btn_alta_vet.Click
        Me.Hide()
        Alta_Veterinario.Show()
    End Sub
End Class