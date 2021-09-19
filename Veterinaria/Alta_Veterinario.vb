Imports NEGOCIOS

Public Class Alta_Veterinario
    Dim veterinario As New VeterinariosN

    Private Sub btn_volver_veterinario_Click(sender As Object, e As EventArgs) Handles btn_volver_veterinario.Click
        Me.Close()
        Veterinarios.Show()
    End Sub

    Private Sub btn_agregar_veterinario_Click(sender As Object, e As EventArgs) Handles btn_agregar_veterinario.Click
        veterinario.Agregar_Veterinario(txt_box_nombre_vet.Text, txt_box_matricula_vet.Text)
        MsgBox("Veterinario agregado.", MsgBoxStyle.OkOnly, "Alta")
        Veterinarios.dgv_veterinarios.DataSource = veterinario.mostrar_Veterinarios()
        Veterinarios.dgv_veterinarios.Columns(0).Visible = False
        Veterinarios.Show()
        Me.Close()
    End Sub
End Class