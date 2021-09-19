Imports NEGOCIOS
Public Class Ingresar_Guarderia

    Dim paciente As New PacientesN
    Dim guarderia As New GuarderiaN

    Private Sub btn_cancelar_ing_guard_Click(sender As Object, e As EventArgs) Handles btn_cancelar_ing_guard.Click
        Me.Close()
        Menu_Clientes.Show()
    End Sub

    Private Sub btn_buscar_client_guard_Click(sender As Object, e As EventArgs) Handles btn_buscar_client_guard.Click
        Me.Hide()
        Busqueda_Cliente.Show()
    End Sub

    Public Sub cmb_paciente_guard_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_paciente_guard.SelectedIndexChanged
        Dim tabla As DataTable = paciente.busqueda_Paciente_Id(cmb_paciente_guard.SelectedValue)
        especie_paciente_guard.Text = tabla.Rows(0)(2).ToString
        raza_paciente_guard.Text = tabla.Rows(0)(3).ToString
        sexo_paciente_guard.Text = tabla.Rows(0)(4).ToString
        dtp_fechanac_guard.Value = tabla.Rows(0)(6)
    End Sub

    Private Sub Ingresar_Guarderia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Hoy_Es.Text = "Hoy es: " & String.Format("{0:dd/MM/yyyy}", DateTime.Now)
    End Sub

    Private Sub btn_guardar_paciente_guard_Click(sender As Object, e As EventArgs) Handles btn_guardar_paciente_guard.Click
        If verificacion() Then
            guarderia.ingresarPaciente_Guard(cmb_paciente_guard.SelectedValue, dtp_ingreso_guard.Value, dtp_fechasalida_guard.Value,
                                         txt_costoxdia_guard.Text, txt_seña_guard.Text, CheckBox_incluyesalida_guard.Checked,
                                         txt_alimento.Text, txt_notas.Text)
            MsgBox("Paciente ingresado en Guarderia con exito.", MsgBoxStyle.OkOnly, "Guarderia")
            Menu_Clientes.dgv_guarderia.DataSource = guarderia.mostrarGuarderia()
            Me.Close()
            Menu_Clientes.Show()
        Else
            MsgBox("Complete todos los campos obligatorios, por favor", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub dtp_ingreso_guard_ValueChanged(sender As Object, e As EventArgs) Handles dtp_ingreso_guard.ValueChanged
        dtp_fechasalida_guard.MinDate = dtp_ingreso_guard.Value
    End Sub

    Private Sub calcular_monto() Handles txt_costoxdia_guard.TextChanged, txt_seña_guard.TextChanged
        Dim precio As Double = 0
        If Double.TryParse(txt_costoxdia_guard.Text, precio) Then
            Dim dias As Double = CDbl(txt_noches_guard.Text)
            Dim monto As Double = precio * dias
            txt_importe_guard.Text = monto
            Dim seña As Double = 0
            Double.TryParse(txt_seña_guard.Text, seña)
            If monto - seña < 0 Then
                txt_saldo_guard.Text = 0
            Else
                txt_saldo_guard.Text = monto - seña
            End If
        Else
            If txt_costoxdia_guard.Text = "" Then
                txt_importe_guard.Text = 0
                txt_saldo_guard.Text = 0
            End If
        End If
    End Sub

    Private Sub calcular_dias() Handles dtp_ingreso_guard.ValueChanged, dtp_fechasalida_guard.ValueChanged, CheckBox_incluyesalida_guard.CheckedChanged
        Dim dias As Int32 = dtp_fechasalida_guard.Value.Subtract(dtp_ingreso_guard.Value).Days
        If CheckBox_incluyesalida_guard.Checked = True Then
            dias = dias + 1
        End If

        txt_noches_guard.Text = dias.ToString
        calcular_monto()
    End Sub

    Private Function verificacion() As Boolean
        Return txt_seña_guard.Text.Length <> 0 And txt_alimento.Text.Length <> 0 And txt_notas.Text.Length <> 0 And txt_costoxdia_guard.Text.Length <> 0 And cmb_paciente_guard.SelectedValue <> Nothing
    End Function
End Class