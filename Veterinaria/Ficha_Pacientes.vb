Imports NEGOCIOS
Public Class Ficha_Pacientes

    Dim paciente As New PacientesN

    Private Sub Ficha_Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemoveHandler cmb_especie_paciente.SelectedIndexChanged, AddressOf cmb_especie_paciente_SelectedIndexChanged
        cmb_especie_paciente.DataSource = paciente.Especies()
        cmb_especie_paciente.DisplayMember = "nombre"
        cmb_especie_paciente.ValueMember = "idEspecie"
        'cmb_raza_paciente.DataSource = Nothing
        'cmb_raza_paciente.DataSource = paciente.Razas(cmb_especie_paciente.SelectedValue)
        'cmb_raza_paciente.DisplayMember = "nombre"
        'cmb_raza_paciente.ValueMember = "idRaza"

        Dim info_paciente As DataTable = paciente.FichaPacientes(Me.Tag)

        txtbox_cod_cliente_paciente.Text = info_paciente.Rows(0)(0).ToString
        txtbox_nombre_paciente.Text = info_paciente.Rows(0)(1).ToString
        cmb_especie_paciente.SelectedValue = info_paciente.Rows(0)(10).ToString
        cmb_especie_paciente_SelectedIndexChanged(e, e)
        cmb_raza_paciente.SelectedValue = info_paciente.Rows(0)(2).ToString
        If info_paciente.Rows(0)(3).ToString = "0" Then
            cmb_sexo_paciente.SelectedText = "Macho"
        Else
            cmb_sexo_paciente.SelectedText = "Hembra"
        End If
        dtp_alta_paciente.Value = info_paciente.Rows(0)(5)
        dtp_nac_paciente.Value = info_paciente.Rows(0)(4)
        dtp_ult_visita_paciente.Value = info_paciente.Rows(0)(6)
        txtbox_microchip_paciente.Text = info_paciente.Rows(0)(7)

        Dim ms As New System.IO.MemoryStream() 'Creamos el MemoryStream y poder cargar la imagen.
        Dim imageBuffer() As Byte = CType(info_paciente.Rows(0)(8), Byte()) 'Convertimos la imagen cargada en el datatable a Bytes.
        ms = New System.IO.MemoryStream(imageBuffer) 'Cargamos el MemoryStream con la imagen ya convertida en Bytes.
        picturebox_paciente.Image = Nothing 'Si existe una imagen cargada en el PictureBox la borramos.
        picturebox_paciente.Image = (Image.FromStream(ms))
        ms.Dispose()

        AddHandler cmb_especie_paciente.SelectedIndexChanged, AddressOf cmb_especie_paciente_SelectedIndexChanged
    End Sub

    Private Sub cmb_especie_paciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_especie_paciente.SelectedIndexChanged
        cmb_raza_paciente.DataSource = Nothing
        cmb_raza_paciente.DataSource = paciente.Razas(cmb_especie_paciente.SelectedValue)
        cmb_raza_paciente.DisplayMember = "nombre"
        cmb_raza_paciente.ValueMember = "idRaza"
    End Sub

    Private Sub btn_guardar_paciente_Click(sender As Object, e As EventArgs) Handles btn_guardar_paciente.Click
        Dim sexo As Boolean
        If verificacion_paciente() Then
            If cmb_sexo_paciente.SelectedItem = "Macho" Then
                sexo = 0
            Else
                sexo = 1
            End If
            paciente.Update_Paciente(CInt(txtbox_cod_cliente_paciente.Text), txtbox_nombre_paciente.Text, cmb_raza_paciente.SelectedValue, sexo, dtp_nac_paciente.Value, txtbox_microchip_paciente.Text)
            Menu_Clientes.dgv_pacientes_pacientes.DataSource = paciente.MostrarPacientes()
            'dgv_pacientes_pacientes.Columns(6).Visible = False
            'dgv_pacientes_pacientes.Columns(7).Visible = False
            MsgBox("Paciente actualizado.", MsgBoxStyle.OkOnly, "Paciente")
        Else
            MsgBox("Complete todos los campos obligatorios, por favor", MsgBoxStyle.OkOnly, "Error")
        End If
    End Sub

    Private Function verificacion_paciente() As Boolean
        Return txtbox_nombre_paciente.Text.Length <> 0 And txtbox_cod_cliente_paciente.Text.Length <> 0 And txtbox_microchip_paciente.Text.Length <> 0
    End Function

    Private Sub btn_volver_paciente_Click(sender As Object, e As EventArgs) Handles btn_volver_paciente.Click
        Me.Close()
        Menu_Clientes.Show()
    End Sub
End Class