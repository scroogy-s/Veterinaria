Imports NEGOCIOS
Public Class Detalle_Guarderia

    Dim guarderia As New GuarderiaN

    Private Sub btn_cancelar_ing_guard_Click(sender As Object, e As EventArgs) Handles btn_cancelar_ing_guard.Click
        Me.Close()
        Menu_Clientes.Show()
    End Sub

    Private Sub Detalle_Guarderia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Hoy_Es.Text = "Hoy es: " & String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Dim table As DataTable = guarderia.Detalles_Guarderia(Me.Tag)
        nombre_cliente_guard.Text = table.Rows(0)(0).ToString
        direccion_cliente_guard.Text = table.Rows(0)(1).ToString
        telefono_cliente_guard.Text = table.Rows(0)(2).ToString
        nombre_paciente_guard.Text = table.Rows(0)(3).ToString
        especie_paciente_guard.Text = table.Rows(0)(4).ToString
        raza_paciente_guard.Text = table.Rows(0)(5).ToString
        sexo_paciente_guard.Text = table.Rows(0)(6).ToString
        dtp_fechanac_guard.Value = table.Rows(0)(7)
        dtp_ingreso_guard.Value = table.Rows(0)(8)
        txt_costoxdia_guard.Text = table.Rows(0)(9).ToString
        dtp_fechasalida_guard.Value = table.Rows(0)(10)
        CheckBox_incluyesalida_guard.Checked = table.Rows(0)(11)
        txt_seña_guard.Text = table.Rows(0)(12).ToString
        txt_alimento.Text = table.Rows(0)(13).ToString
        txt_notas.Text = table.Rows(0)(14).ToString
        calcular_dias()
    End Sub

    Private Sub calcular_monto()
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

    Private Sub calcular_dias() Handles dtp_ingreso_guard.ValueChanged, dtp_fechasalida_guard.ValueChanged
        Dim dias As Int32 = dtp_fechasalida_guard.Value.Subtract(dtp_ingreso_guard.Value).Days
        If CheckBox_incluyesalida_guard.Checked = True Then
            dias = dias + 1
        End If

        txt_noches_guard.Text = dias.ToString
        calcular_monto()
    End Sub

    Private Sub btn_guardar_paciente_guard_Click(sender As Object, e As EventArgs) Handles btn_guardar_paciente_guard.Click
        guarderia.Update_Detalles(Me.Tag, dtp_ingreso_guard.Value, dtp_fechasalida_guard.Value, txt_alimento.Text, txt_notas.Text)
        MsgBox("Detalles actualizados en Guarderia con exito.", MsgBoxStyle.OkOnly, "Guarderia")
        Menu_Clientes.dgv_guarderia.DataSource = guarderia.mostrarGuarderia()
        Me.Close()
        Menu_Clientes.Show()
    End Sub
End Class