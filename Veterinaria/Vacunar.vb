Imports NEGOCIOS
Public Class Vacunar

    Dim vacunas As New VacunasN
    Dim vacunacion As New Vacunaciones_ATPsN

    Private Sub btn_vacunar_cancelar_Click(sender As Object, e As EventArgs) Handles btn_vacunar_cancelar.Click
        Me.Close()
        Vacunas_ATP.Show()
    End Sub

    Private Sub Vacunar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_vacuna.DataSource = vacunas.mostrarVacunas()
        cmb_vacuna.DisplayMember = "nombre"
        cmb_vacuna.ValueMember = "idVacuna"
        cmb_prox_vacuna.DataSource = vacunas.mostrarVacunas()
        cmb_prox_vacuna.DisplayMember = "nombre"
        cmb_prox_vacuna.ValueMember = "idVacuna"
    End Sub

    Public Sub calcular_Proxima_fecha() Handles dtp_fecha_vacunacion.ValueChanged, txt_dias_vacunacion.TextChanged
        Dim dias As Integer = 0
        Integer.TryParse(txt_dias_vacunacion.Text, dias)
        dtp_fecha_revacuna.Value = dtp_fecha_vacunacion.Value.AddDays(dias)
    End Sub

    Private Sub btn_vacunar_aceptar_Click(sender As Object, e As EventArgs) Handles btn_vacunar_aceptar.Click
        vacunacion.insertarVacunacion(Me.Tag, cmb_vacuna.SelectedValue, txt_marca_serie.Text, dtp_fecha_vacunacion.Value)
        vacunacion.insertarVacunacionPendiente(Me.Tag, cmb_prox_vacuna.SelectedValue, dtp_fecha_revacuna.Value)
        Vacunas_ATP.dgv_vacunas_atp.DataSource = vacunacion.mostrar_Vac_ATPs(Me.Tag)
        MsgBox("Vacunacion agregada.", MsgBoxStyle.OkOnly, "Vacunaciones.")
        Me.Close()
        Vacunas_ATP.Show()
    End Sub
End Class