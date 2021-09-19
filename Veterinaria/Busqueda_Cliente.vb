Imports NEGOCIOS

Public Class Busqueda_Cliente

    Dim cliente As New ClientesN
    Dim paciente As New PacientesN

    Private Sub Busqueda_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_clientes.DataSource = cliente.mostrarClientes()
        dgv_clientes.Columns(0).Visible = False
        cmb_buscar.SelectedIndex = 0
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
    End Sub

    Private Sub btn_seleccionar_cliente_Click(sender As Object, e As EventArgs) Handles btn_seleccionar_cliente.Click
        Ingresar_Guarderia.nombre_cliente_guard.Text = dgv_clientes.SelectedRows(0).Cells(1).Value
        Ingresar_Guarderia.direccion_cliente_guard.Text = dgv_clientes.SelectedRows(0).Cells(2).Value
        Ingresar_Guarderia.telefono_cliente_guard.Text = dgv_clientes.SelectedRows(0).Cells(3).Value
        RemoveHandler Ingresar_Guarderia.cmb_paciente_guard.SelectedIndexChanged, AddressOf Ingresar_Guarderia.cmb_paciente_guard_SelectedIndexChanged
        Ingresar_Guarderia.cmb_paciente_guard.DataSource = paciente.MostrarPacientesxClientes(dgv_clientes.SelectedRows(0).Cells(0).Value)
        Ingresar_Guarderia.cmb_paciente_guard.DisplayMember = "Nombre"
        Ingresar_Guarderia.cmb_paciente_guard.ValueMember = "idPaciente"
        AddHandler Ingresar_Guarderia.cmb_paciente_guard.SelectedIndexChanged, AddressOf Ingresar_Guarderia.cmb_paciente_guard_SelectedIndexChanged
        Dim tabla As DataTable = paciente.busqueda_Paciente_Id(Ingresar_Guarderia.cmb_paciente_guard.SelectedValue)
        Ingresar_Guarderia.especie_paciente_guard.Text = tabla.Rows(0)(2).ToString
        Ingresar_Guarderia.raza_paciente_guard.Text = tabla.Rows(0)(3).ToString
        Ingresar_Guarderia.sexo_paciente_guard.Text = tabla.Rows(0)(4).ToString
        Ingresar_Guarderia.dtp_fechanac_guard.Value = tabla.Rows(0)(6)
        Me.Close()
        Ingresar_Guarderia.Show()
    End Sub
End Class