Public Class Menu_Principal
    Private Sub btn_admin_Click(sender As Object, e As EventArgs) Handles btn_admin.Click
        Me.Hide()
        Administracion.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Menu_Clientes.Show()
    End Sub
End Class
