Imports NEGOCIOS

Public Class Menu_Clientes

    Dim cliente As New ClientesN
    Dim paciente As New PacientesN
    Dim guarderia As New GuarderiaN

    Private Sub btn_nuevo_cliente_Click(sender As Object, e As EventArgs) Handles btn_nuevo_cliente.Click
        Me.Close()
        Alta_Cliente.Show()
    End Sub

    Private Sub btn_volver_cliente_Click(sender As Object, e As EventArgs) Handles btn_volver_cliente.Click
        Me.Close()
        Menu_Principal.Show()
    End Sub

    Private Sub Menu_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_clientes.DataSource = cliente.mostrarClientes()
        dgv_clientes.Columns(0).Visible = False
        dgv_pacientes.DataSource = paciente.MostrarPacientesxClientes(dgv_clientes.SelectedRows(0).Cells(0).Value)
        dgv_pacientes.Columns(1).Visible = False
        dgv_pacientes.Columns(6).Visible = False
        dgv_pacientes.Columns(7).Visible = False
        dgv_pacientes_pacientes.DataSource = paciente.MostrarPacientes()
        dgv_pacientes_pacientes.Columns(7).Visible = False
        dgv_pacientes_pacientes.Columns(8).Visible = False
        cmb_buscar.SelectedIndex = 0
        dgv_guarderia.DataSource = guarderia.mostrarGuarderia()
        dgv_guarderia.Columns(0).Visible = False
    End Sub

    Private Sub dgv_clientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_clientes.CellClick
        dgv_pacientes.DataSource = paciente.MostrarPacientesxClientes(dgv_clientes.SelectedRows(0).Cells(0).Value)

    End Sub

    Private Sub txtbox_buscar_TextChanged(sender As Object, e As EventArgs) Handles txtbox_buscar.TextChanged

        Select Case cmb_buscar.SelectedItem.ToString
            Case "Nombre"
                dgv_clientes.DataSource = cliente.Busqueda_Clientes_Nombre(txtbox_buscar.Text)
            Case "Direccion"
                dgv_clientes.DataSource = cliente.Busqueda_Clientes_Direccion(txtbox_buscar.Text)
            Case "Localidad"
                dgv_clientes.DataSource = cliente.Busqueda_Clientes_Localidad(txtbox_buscar.Text)
            Case "Celular"
                dgv_clientes.DataSource = cliente.Busqueda_Clientes_Celular(txtbox_buscar.Text)
            Case "Provincia"
                dgv_clientes.DataSource = cliente.Busqueda_Clientes_Provincia(txtbox_buscar.Text)
            Case "eMail"
                dgv_clientes.DataSource = cliente.Busqueda_Clientes_Mail(txtbox_buscar.Text)
        End Select

        If dgv_clientes.Rows.Count > 0 Then
            dgv_pacientes.DataSource = paciente.MostrarPacientesxClientes(dgv_clientes.SelectedRows(0).Cells(0).Value)
        Else
            dgv_pacientes.DataSource = Nothing
        End If

    End Sub

    Private Sub btn_abrir_ficha_Click(sender As Object, e As EventArgs) Handles btn_abrir_ficha.Click

        If dgv_clientes.Rows.Count <> 0 Then
            Ficha_Cliente.Tag = dgv_clientes.SelectedRows(0).Cells(0).Value
            Me.Hide()
            Ficha_Cliente.Show()
        Else
            MsgBox("No selecciono ningun cliente.", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub btn_eliminar_cliente_Click(sender As Object, e As EventArgs) Handles btn_eliminar_cliente.Click
        If (dgv_pacientes.Rows.Count <> 0) Then
            If (MsgBox("Al eliminar este cliente tambien elimnará a los pacientes asociados. ¿Desea continuar?", MsgBoxStyle.YesNo, "Advertencia") = 6) Then
                paciente.Delete_PacientexCliente(dgv_clientes.SelectedRows(0).Cells(0).Value)
                cliente.Delete_Cliente(dgv_clientes.SelectedRows(0).Cells(0).Value)
                dgv_clientes.DataSource = cliente.mostrarClientes()
                If (dgv_clientes.Rows.Count <> 0) Then
                    dgv_pacientes.DataSource = paciente.MostrarPacientesxClientes(dgv_clientes.SelectedRows(0).Cells(0).Value)
                End If
                MsgBox("Eliminación realiazada con éxito.", MsgBoxStyle.OkOnly, "Eliminación")
            End If
        Else
            If (MsgBox("¿Seguro elimina el cliente: " + dgv_clientes.SelectedRows(0).Cells("Cliente").Value.ToString + "?", MsgBoxStyle.YesNo, "Advertencia") = 6) Then
                cliente.Delete_Cliente(dgv_clientes.SelectedRows(0).Cells(0).Value)
                dgv_clientes.DataSource = cliente.mostrarClientes()
                If (dgv_clientes.Rows.Count <> 0) Then
                    dgv_pacientes.DataSource = paciente.MostrarPacientesxClientes(dgv_clientes.SelectedRows(0).Cells(0).Value)
                End If
                MsgBox("Eliminación realiazada con éxito.", MsgBoxStyle.OkOnly, "Eliminación")
            End If
        End If
    End Sub

    Private Sub btn_abrir_ficha_paciente_Click(sender As Object, e As EventArgs) Handles btn_abrir_ficha_paciente.Click
        If dgv_pacientes_pacientes.Rows.Count <> 0 Then
            Ficha_Pacientes.Tag = dgv_pacientes_pacientes.SelectedRows(0).Cells(8).Value
            Me.Hide()
            Ficha_Pacientes.Show()
        Else
            MsgBox("No selecciono ningun paciente.", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub btn_cerrar_2_Click(sender As Object, e As EventArgs) Handles btn_cerrar_2.Click
        Me.Close()
        Menu_Principal.Show()
    End Sub

    Private Sub btn_eliminar_paciente_Click(sender As Object, e As EventArgs) Handles btn_eliminar_paciente.Click
        If (MsgBox("¿Seguro elimina el paciente: " + dgv_pacientes_pacientes.SelectedRows(0).Cells("nombre").Value.ToString + "?", MsgBoxStyle.YesNo, "Advertencia") = 6) Then
            paciente.Delete_Paciente(dgv_clientes.SelectedRows(0).Cells(0).Value)
            dgv_pacientes_pacientes.DataSource = paciente.MostrarPacientes()
            MsgBox("Eliminación realiazada con éxito.", MsgBoxStyle.OkOnly, "Eliminación")
        End If
    End Sub

    Private Sub txt_box_busq_paciente_TextChanged(sender As Object, e As EventArgs) Handles txt_box_busq_paciente.TextChanged
        Select Case cmb_busq_paciente.SelectedItem.ToString
            Case "Nombre"
                dgv_pacientes_pacientes.DataSource = paciente.Busqueda_Paciente_Nombre(txt_box_busq_paciente.Text)
            Case "Especie"
                dgv_pacientes_pacientes.DataSource = paciente.Busqueda_Paciente_Especie(txt_box_busq_paciente.Text)
            Case "Raza"
                dgv_pacientes_pacientes.DataSource = paciente.Busqueda_Paciente_Raza(txt_box_busq_paciente.Text)
            Case "Sexo"
                dgv_pacientes_pacientes.DataSource = paciente.Busqueda_Paciente_Sexo(txt_box_busq_paciente.Text)
            Case "Fecha Nac."
                dgv_pacientes_pacientes.DataSource = paciente.Busqueda_Paciente_FechaNac(txt_box_busq_paciente.Text)
            Case "Microchip"
                dgv_pacientes_pacientes.DataSource = paciente.Busqueda_Paciente_Microchip(txt_box_busq_paciente.Text)
        End Select
    End Sub

    Private Sub btn_ingreso_guard_Click(sender As Object, e As EventArgs) Handles btn_ingreso_guard.Click
        Me.Hide()
        Ingresar_Guarderia.Show()
    End Sub

    Private Sub btn_salida_guard_Click(sender As Object, e As EventArgs) Handles btn_salida_guard.Click
        If dgv_guarderia.Rows.Count <> 0 Then
            Salida_Guarderia.Tag = dgv_guarderia.SelectedRows(0).Cells(0).Value
            Me.Hide()
            Salida_Guarderia.Show()
        Else
            MsgBox("No selecciono ningun paciente ingresado en Guarderia.", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub btn_historial_guard_Click(sender As Object, e As EventArgs) Handles btn_historial_guard.Click
        Me.Hide()
        Historial_Guarderia.Show()
    End Sub

    Private Sub btn_detalle_guard_Click(sender As Object, e As EventArgs) Handles btn_detalle_guard.Click
        If dgv_guarderia.Rows.Count <> 0 Then
            Detalle_Guarderia.Tag = dgv_guarderia.SelectedRows(0).Cells(0).Value
            Me.Hide()
            Detalle_Guarderia.Show()
        Else
            MsgBox("No selecciono ningun paciente.", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub btn_borrar_guard_Click(sender As Object, e As EventArgs) Handles btn_borrar_guard.Click
        If dgv_guarderia.Rows.Count <> 0 Then
            Eliminar_Guarderia.Tag = dgv_guarderia.SelectedRows(0).Cells(0).Value
            Me.Hide()
            Eliminar_Guarderia.Show()
        Else
            MsgBox("No selecciono ningun paciente.", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Sub btn_vac_atp_Click(sender As Object, e As EventArgs) Handles btn_vac_atp.Click
        If dgv_guarderia.Rows.Count <> 0 Then
            Vacunas_ATP.Tag = dgv_pacientes_pacientes.SelectedRows(0).Cells(8).Value
            Me.Hide()
            Vacunas_ATP.Show()
        Else
            MsgBox("No selecciono ningun paciente.", MsgBoxStyle.OkOnly, "Error")
        End If

    End Sub
End Class