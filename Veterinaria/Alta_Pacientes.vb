Imports NEGOCIOS
Public Class Alta_Pacientes

    Dim paciente As New PacientesN

    Private Sub Alta_Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cmb_sexo_paciente.Items.Add(0, "Macho")
        'cmb_sexo_paciente.Items.Add(1, "Hembra")

        picturebox_paciente.BackgroundImageLayout = ImageLayout.Stretch
        txtbox_cod_cliente_paciente.Text = paciente.devolverProximoCodigo()
        RemoveHandler cmb_especie_paciente.SelectedIndexChanged, AddressOf cmb_especie_paciente_SelectedIndexChanged
        cmb_especie_paciente.DataSource = paciente.Especies()
        cmb_especie_paciente.DisplayMember = "nombre"
        cmb_especie_paciente.ValueMember = "idEspecie"
        cmb_raza_paciente.DataSource = Nothing
        cmb_raza_paciente.DataSource = paciente.Razas(cmb_especie_paciente.SelectedValue)
        cmb_raza_paciente.DisplayMember = "nombre"
        cmb_raza_paciente.ValueMember = "idRaza"
        AddHandler cmb_especie_paciente.SelectedIndexChanged, AddressOf cmb_especie_paciente_SelectedIndexChanged
    End Sub

    Private Sub cmb_especie_paciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_especie_paciente.SelectedIndexChanged
        cmb_raza_paciente.DataSource = Nothing
        cmb_raza_paciente.DataSource = paciente.Razas(cmb_especie_paciente.SelectedValue)
        cmb_raza_paciente.DisplayMember = "nombre"
        cmb_raza_paciente.ValueMember = "idRaza"
    End Sub

    Private Sub btn_volver_paciente_Click(sender As Object, e As EventArgs) Handles btn_volver_paciente.Click
        Me.Close()
        Alta_Cliente.Show()
    End Sub

    Private Sub btn_buscar_foto_paciente_Click(sender As Object, e As EventArgs) Handles btn_buscar_foto_paciente.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Imagen (JPG,BMP,PNG)|*.JPG;*.BMP;*.PNG|All files (*.*)|*.*"
        If file.ShowDialog() = DialogResult.OK Then
            picturebox_paciente.Image = Image.FromFile(file.FileName)
        End If
    End Sub

    Private Sub btn_guardar_paciente_Click(sender As Object, e As EventArgs) Handles btn_guardar_paciente.Click
        Dim sexo As Boolean
        Dim ms1 As New System.IO.MemoryStream()
        picturebox_paciente.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg)
        If cmb_sexo_paciente.SelectedItem = "Macho" Then
            sexo = 0
        Else
            sexo = 1
        End If
        paciente.insertarPaciente(txtbox_nombre_paciente.Text, cmb_raza_paciente.SelectedValue,
                                    sexo, dtp_nac_paciente.Value, dtp_alta_paciente.Value,
                                    dtp_ult_visita_paciente.Value, txtbox_microchip_paciente.Text, ms1.GetBuffer(), Me.Tag)
        Menu_Clientes.dgv_pacientes_pacientes.DataSource = paciente.MostrarPacientes()
        MsgBox("Paciente agregado.", MsgBoxStyle.OkOnly, "Nuevo Paciente")
        Limpiar_Pacientes()
    End Sub

    Private Sub btn_cerrar_modif_Click(sender As Object, e As EventArgs) Handles btn_cerrar_modif.Click
        Me.Close()
        Ficha_Cliente.Show()
    End Sub

    Private Sub Limpiar_Pacientes()
        txtbox_cod_cliente_paciente.Text = paciente.devolverProximoCodigo()
        txtbox_nombre_paciente.Clear()
        txtbox_microchip_paciente.Clear()
    End Sub
End Class