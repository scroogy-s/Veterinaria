Imports NEGOCIOS

Public Class Salida_Guarderia

    Dim guarderia As New GuarderiaN

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Close()
        Menu_Clientes.Show()
    End Sub

    Private Sub Salida_Guarderia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_Hoy_Es.Text = "Hoy es: " & String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Dim table As DataTable = guarderia.TraerDatosGuarderia(Me.Tag)
        dtp_ingreso_guard.Value = table.Rows(0)(0)
        nombre_cliente_guard.Text = table.Rows(0)(1).ToString
        nombre_paciente_guard.Text = table.Rows(0)(2).ToString
        txt_costoxdia_guard.Text = table.Rows(0)(3).ToString
        dtp_fechasalida_guard.Value = table.Rows(0)(4)
        CheckBox_incluyesalida_guard.Checked = table.Rows(0)(5)
        txt_seña_guard.Text = table.Rows(0)(6).ToString
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

    Private Sub calcular_dias()
        Dim dias As Int32 = dtp_fechasalida_guard.Value.Subtract(dtp_ingreso_guard.Value).Days
        If CheckBox_incluyesalida_guard.Checked = True Then
            dias = dias + 1
        End If

        txt_noches_guard.Text = dias.ToString
        calcular_monto()
    End Sub

    Private Sub btn_aceptar_salida_Click(sender As Object, e As EventArgs) Handles btn_aceptar_salida.Click
        guarderia.Update_Estado(Me.Tag)
        MsgBox("Se registro la salida del Paciente con exito.", MsgBoxStyle.OkOnly, "Guarderia")
        Menu_Clientes.dgv_guarderia.DataSource = guarderia.mostrarGuarderia()
        Me.Close()
        Menu_Clientes.Show()
    End Sub

End Class