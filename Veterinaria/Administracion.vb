Public Class Administracion
    Private Sub btn_admin_volver_Click(sender As Object, e As EventArgs) Handles btn_admin_volver.Click
        Me.Hide()
        Menu_Principal.Show()
    End Sub

    Private Sub btn_vacunas_Click(sender As Object, e As EventArgs) Handles btn_vacunas.Click
        Me.Hide()
        Vacunas.Show()
    End Sub

    Private Sub btn_antiparasitario_Click(sender As Object, e As EventArgs) Handles btn_antiparasitario.Click
        Me.Hide()
        ATP.Show()
    End Sub

    Private Sub btn_animales_Click(sender As Object, e As EventArgs) Handles btn_animales.Click
        Me.Hide()
        Animales.Show()
    End Sub

    Private Sub btn_veter_Click(sender As Object, e As EventArgs) Handles btn_veter.Click
        Me.Hide()
        Veterinarios.Show()
    End Sub
End Class