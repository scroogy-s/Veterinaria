Imports NEGOCIOS

Public Class Eliminar_Guarderia

    Dim guarderia As New GuarderiaN

    Private Sub btn_volver_eliminar_Click(sender As Object, e As EventArgs) Handles btn_volver_eliminar.Click
        Me.Close()
        Menu_Clientes.Show()
    End Sub

    Private Sub Eliminar_Guarderia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim table As DataTable = guarderia.TraerDatosEliminacion(Me.Tag)
        txt_idguard_elim.Text = Me.Tag
        dtp_ingreso_elim.Value = table.Rows(0)(0)
        txt_cliente_elim.Text = table.Rows(0)(1).ToString
        txt_paciente_elim.Text = table.Rows(0)(2).ToString
    End Sub

    Private Sub btn_eliminar_guard_Click(sender As Object, e As EventArgs) Handles btn_eliminar_guard.Click
        guarderia.Delete_Registro_Guarderia(Me.Tag)
        MsgBox("Registro eliminado en Guarderia con exito.", MsgBoxStyle.OkOnly, "Guarderia")
        Menu_Clientes.dgv_guarderia.DataSource = guarderia.mostrarGuarderia()
        Me.Close()
        Menu_Clientes.Show()
    End Sub
End Class