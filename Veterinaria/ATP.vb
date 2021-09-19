Imports NEGOCIOS

Public Class ATP
    Dim tabla_atp As New AntiparasitariosN
    Dim atp As New AntiparasitariosN

    Private Sub ATP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_atp.DataSource = tabla_atp.mostrarATP()
        dgv_atp.Columns(0).Visible = False
        dgv_atp.Columns(1).HeaderText = "Tipos de Antiparasitarios"
    End Sub

    Private Sub btn_alta_atp_Click(sender As Object, e As EventArgs) Handles btn_alta_atp.Click
        Me.Close()
        Alta_ATP.Show()
    End Sub

    Private Sub btn_volver_atp_Click(sender As Object, e As EventArgs) Handles btn_volver_atp.Click
        Me.Close()
        Administracion.Show()
    End Sub

    Private Sub btn_baja_atp_Click(sender As Object, e As EventArgs) Handles btn_baja_atp.Click
        Dim mensaje As String
        mensaje = "¿Seguro elimina el Antiparasitario: " + dgv_atp.SelectedRows(0).Cells("nombre").Value.ToString + "?"
        If MsgBox(mensaje, MsgBoxStyle.YesNo, "Baja") = 6 Then
            atp.eliminarATP(dgv_atp.SelectedRows(0).Cells(0).Value)
            MsgBox("Eliminación realizada con exito.", MsgBoxStyle.OkOnly, "Fin de Operación")
            dgv_atp.DataSource = tabla_atp.mostrarATP()
            dgv_atp.Columns(0).Visible = False
        End If
    End Sub
End Class