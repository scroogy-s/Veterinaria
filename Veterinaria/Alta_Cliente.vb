Imports NEGOCIOS

Public Class Alta_Cliente
    Dim cliente As New ClientesN

    Private Sub btn_buscar_img_cliente_Click(sender As Object, e As EventArgs) Handles btn_buscar_img_cliente.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Imagen (JPG,BMP,PNG)|*.JPG;*.BMP;*.PNG|All files (*.*)|*.*"
        If file.ShowDialog() = DialogResult.OK Then
            PictureBox_cliente.Image = Image.FromFile(file.FileName)
        End If
    End Sub

    Private Sub btn_guardar_cliente_Click(sender As Object, e As EventArgs) Handles btn_guardar_cliente.Click
        Dim ms1 As New System.IO.MemoryStream()
        PictureBox_cliente.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg)
        cliente.insertarCliente(txtbox_nombre_cliente.Text, txtbox_direccion_cliente.Text, txtbox_cel_cliente.Text, cmb_empresa_celular.SelectedItem, cmb_localidad.SelectedValue, dtp_alta_cliente.Value, dtp_ult_visita_cliente.Value, txtbox_email_cliente.Text, ms1.GetBuffer())
        MsgBox("Cliente agregado.", MsgBoxStyle.OkOnly, "Nuevo Cliente")
        Me.Close()
        Menu_Clientes.Show()
    End Sub

    Private Sub Alta_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim ruta As String
        'ruta = "F:\Programacion Aplicada\Programa\Veterinaria\sample.png"
        'PictureBox_cliente.BackgroundImage = Image.FromFile(ruta)
        PictureBox_cliente.BackgroundImageLayout = ImageLayout.Stretch
        txtbox_codigo_cliente.Text = cliente.devolverProximoCodigo()
        RemoveHandler cmb_provincia.SelectedIndexChanged, AddressOf cmb_provincia_SelectedIndexChanged
        cmb_provincia.DataSource = cliente.mostrarProvincias()
        cmb_provincia.DisplayMember = "nombre"
        cmb_provincia.ValueMember = "idProvincia"
        RemoveHandler cmb_localidad.SelectedIndexChanged, AddressOf cmb_localidad_SelectedIndexChanged
        cmb_localidad.DataSource = cliente.mostrarLocalidades_Provincias(cmb_provincia.SelectedValue)
        cmb_localidad.DisplayMember = "nombre"
        cmb_localidad.ValueMember = "idLocalidad"
        txtbox_codigo_postal.Text = cliente.devolverCP(cmb_localidad.SelectedValue)
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

    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Me.Close()
        Menu_Clientes.Show()
    End Sub

    Private Sub btn_ingresar_paciente_Click(sender As Object, e As EventArgs) Handles btn_ingresar_paciente.Click
        If verificacion_paciente() Then
            Dim ms1 As New System.IO.MemoryStream()
            PictureBox_cliente.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg)
            cliente.insertarCliente(txtbox_nombre_cliente.Text, txtbox_direccion_cliente.Text, txtbox_cel_cliente.Text, cmb_empresa_celular.SelectedItem, cmb_localidad.SelectedValue, dtp_alta_cliente.Value, dtp_ult_visita_cliente.Value, txtbox_email_cliente.Text, ms1.GetBuffer())
            MsgBox("Cliente agregado.", MsgBoxStyle.OkOnly, "Nuevo Cliente")
            Alta_Pacientes.Tag = CInt(txtbox_codigo_cliente.Text)
            Alta_Pacientes.btn_cerrar_modif.Visible = False
            Alta_Pacientes.btn_volver_paciente.Visible = True
            Alta_Pacientes.Show()
            Me.Close()
        Else
            MsgBox("Complete todos los campos obligatorios, por favor", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Function verificacion_paciente() As Boolean
        Return txtbox_nombre_cliente.Text.Length <> 0 And txtbox_direccion_cliente.Text.Length <> 0 And txtbox_cel_cliente.Text.Length <> 0 And
            cmb_empresa_celular.Text.Length <> 0 And txtbox_email_cliente.Text.Length <> 0
    End Function
End Class