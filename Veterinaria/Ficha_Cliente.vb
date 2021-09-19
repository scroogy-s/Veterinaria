Imports NEGOCIOS

Public Class Ficha_Cliente

    Dim cliente As New ClientesN

    Private Sub btn_ficha_cliente_cerrar_Click(sender As Object, e As EventArgs) Handles btn_ficha_cliente_cerrar.Click
        Me.Close()
        Menu_Clientes.Show()
    End Sub

    Private Sub Ficha_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RemoveHandler cmb_provincia.SelectedIndexChanged, AddressOf cmb_provincia_SelectedIndexChanged
        cmb_provincia.DataSource = cliente.mostrarProvincias()
        cmb_provincia.DisplayMember = "nombre"
        cmb_provincia.ValueMember = "idProvincia"
        RemoveHandler cmb_localidad.SelectedIndexChanged, AddressOf cmb_localidad_SelectedIndexChanged

        Dim info_cliente As DataTable = cliente.FichaClientes(Me.Tag)

        txtbox_codigo_cliente.Text = info_cliente.Rows(0)(0).ToString
        txtbox_nombre_cliente.Text = info_cliente.Rows(0)(1).ToString
        txtbox_direccion_cliente.Text = info_cliente.Rows(0)(2).ToString
        txtbox_cel_cliente.Text = info_cliente.Rows(0)(3).ToString
        cmb_empresa_celular.SelectedText = info_cliente.Rows(0)(4).ToString
        cmb_provincia.SelectedValue = info_cliente.Rows(0)(10).ToString
        cmb_provincia_SelectedIndexChanged(e, e)
        cmb_localidad.SelectedValue = info_cliente.Rows(0)(5).ToString
        cmb_localidad_SelectedIndexChanged(e, e)
        txtbox_email_cliente.Text = info_cliente.Rows(0)(8).ToString

        Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
        Dim imageBuffer() As Byte = CType(info_cliente.Rows(0)(9), Byte()) 'Convertimos la imagen cargada en el datatable a Bytes.
        ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream con la imagen ya convertida en Bytes.
        PictureBox_cliente.Image = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
        PictureBox_cliente.Image = (Image.FromStream(ms))
        ms.Dispose()

        dtp_alta_cliente.Value = info_cliente.Rows(0)(6)
        dtp_ult_visita_cliente.Value = info_cliente.Rows(0)(7)

        AddHandler cmb_localidad.SelectedIndexChanged, AddressOf cmb_localidad_SelectedIndexChanged
        AddHandler cmb_provincia.SelectedIndexChanged, AddressOf cmb_provincia_SelectedIndexChanged

    End Sub

    Private Sub cmb_provincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_provincia.SelectedIndexChanged
        RemoveHandler cmb_localidad.SelectedIndexChanged, AddressOf cmb_localidad_SelectedIndexChanged
        cmb_localidad.DataSource = cliente.mostrarLocalidades_Provincias(cmb_provincia.SelectedValue)
        cmb_localidad.DisplayMember = "nombre"
        cmb_localidad.ValueMember = "idLocalidad"
        txtbox_codigo_postal.Text = cliente.devolverCP(cmb_localidad.SelectedValue)
        AddHandler cmb_localidad.SelectedIndexChanged, AddressOf cmb_localidad_SelectedIndexChanged
    End Sub

    Private Sub cmb_localidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_localidad.SelectedIndexChanged
        txtbox_codigo_postal.Text = cliente.devolverCP(cmb_localidad.SelectedValue)
    End Sub

    Private Sub btn_modificar_ficha_cliente_Click(sender As Object, e As EventArgs) Handles btn_modificar_ficha_cliente.Click
        If verificacion_cliente() Then
            cliente.Update_Cliente(CInt(txtbox_codigo_cliente.Text), txtbox_nombre_cliente.Text, txtbox_direccion_cliente.Text, txtbox_cel_cliente.Text, cmb_empresa_celular.SelectedText, cmb_localidad.SelectedValue, txtbox_email_cliente.Text)
            MsgBox("Cliente actualizado.", MsgBoxStyle.OkOnly, "Cliente")
        Else
            MsgBox("Complete todos los campos obligatorios, por favor", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Function verificacion_cliente() As Boolean
        Return txtbox_nombre_cliente.Text.Length <> 0 And txtbox_direccion_cliente.Text.Length <> 0 And txtbox_cel_cliente.Text.Length <> 0 And
            cmb_empresa_celular.Text.Length <> 0 And txtbox_email_cliente.Text.Length <> 0
    End Function

    Private Sub btn_agregar_pacientes_ficha_Click(sender As Object, e As EventArgs) Handles btn_agregar_pacientes_ficha.Click
        Alta_Pacientes.Tag = CInt(txtbox_codigo_cliente.Text)
        Alta_Pacientes.btn_cerrar_modif.Visible = True
        Alta_Pacientes.btn_volver_paciente.Visible = False
        Alta_Pacientes.Show()
        Me.hide()
    End Sub
End Class