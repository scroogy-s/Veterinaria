Imports NEGOCIOS
Public Class Vacunas_ATP

    Dim vac_atp As New Vacunaciones_ATPsN
    Dim paciente As New PacientesN

    Private Sub Vacunas_ATP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As DataTable = paciente.busqueda_Paciente_Id(Me.Tag)
        dgv_vacunas_atp.DataSource = vac_atp.mostrar_Vac_ATPs(Me.Tag)
        dgv_vacunas_atp.Columns(4).Visible = False
        dgv_vacunas_atp.Columns(5).Visible = False
        txt_nombre_paciente.Text = tabla.Rows(0)(0).ToString
    End Sub

    Private Sub CheckBox_vacuna_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_vacuna.CheckedChanged

        If dgv_vacunas_atp.Rows.Count > 0 Then
            dgv_vacunas_atp.CurrentCell = Nothing
            For Each row As DataGridViewRow In dgv_vacunas_atp.Rows

                If row.Cells(4).Value = 1 Then
                    row.Visible = Not CheckBox_vacuna.Checked
                End If
            Next
        End If
    End Sub

    Private Sub CheckBox_atp_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_atp.CheckedChanged
        If dgv_vacunas_atp.Rows.Count > 0 Then
            dgv_vacunas_atp.CurrentCell = Nothing
            For Each row As DataGridViewRow In dgv_vacunas_atp.Rows
                If row.Cells(4).Value = 2 Then
                    row.Visible = Not CheckBox_atp.Checked
                End If
            Next
        End If
    End Sub

    Private Sub btn_volver_vac_atp_Click(sender As Object, e As EventArgs) Handles btn_volver_vac_atp.Click
        Me.Close()
        Menu_Clientes.Show()
    End Sub

    Private Sub btn_vacunar_Click(sender As Object, e As EventArgs) Handles btn_vacunar.Click
        Vacunar.Tag = Me.Tag
        Me.Hide()
        Vacunar.Show()
    End Sub

    Private Sub btn_desparasitar_Click(sender As Object, e As EventArgs) Handles btn_desparasitar.Click
        Desparasitar.Tag = Me.Tag
        Me.Hide()
        Desparasitar.Show()
    End Sub

End Class