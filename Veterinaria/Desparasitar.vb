Imports NEGOCIOS

Public Class Desparasitar

    Dim atp As New AntiparasitariosN
    Dim desparacitacion As New Vacunaciones_ATPsN

    Private Sub Desparasitar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_atp.DataSource = atp.mostrarATP()
        cmb_atp.DisplayMember = "nombre"
        cmb_atp.ValueMember = "idATP"
        cmb_prox_atp.DataSource = atp.mostrarATP()
        cmb_prox_atp.DisplayMember = "nombre"
        cmb_prox_atp.ValueMember = "idATP"
    End Sub

    Public Sub calcular_Proxima_fecha() Handles dtp_fecha_atp.ValueChanged, txt_dias_atp.TextChanged
        Dim dias As Integer = 0
        Integer.TryParse(txt_dias_atp.Text, dias)
        dtp_fecha_reatp.Value = dtp_fecha_atp.Value.AddDays(dias)
    End Sub

    Private Sub btn_desparasitar_aceptar_Click(sender As Object, e As EventArgs) Handles btn_desparasitar_aceptar.Click
        desparacitacion.insertarDesparacitacion(Me.Tag, cmb_atp.SelectedValue, txt_marca_serie.Text, dtp_fecha_reatp.Value)
        desparacitacion.insertarDesparasitacionPendiente(Me.Tag, cmb_prox_atp.SelectedValue, dtp_fecha_reatp.Value)
        Vacunas_ATP.dgv_vacunas_atp.DataSource = desparacitacion.mostrar_Vac_ATPs(Me.Tag)
        MsgBox("Desparasitación agregada.", MsgBoxStyle.OkOnly, "Desparacitaciones.")
        Me.Close()
        Vacunas_ATP.Show()
    End Sub

    Private Sub btn_desparacitar_cancelar_Click(sender As Object, e As EventArgs) Handles btn_desparacitar_cancelar.Click
        Me.Close()
        Vacunas_ATP.Show()
    End Sub
End Class