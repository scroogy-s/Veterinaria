<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ficha_Pacientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_volver_paciente = New System.Windows.Forms.Button()
        Me.btn_guardar_paciente = New System.Windows.Forms.Button()
        Me.picturebox_paciente = New System.Windows.Forms.PictureBox()
        Me.txtbox_microchip_paciente = New System.Windows.Forms.TextBox()
        Me.dtp_ult_visita_paciente = New System.Windows.Forms.DateTimePicker()
        Me.dtp_alta_paciente = New System.Windows.Forms.DateTimePicker()
        Me.dtp_nac_paciente = New System.Windows.Forms.DateTimePicker()
        Me.cmb_sexo_paciente = New System.Windows.Forms.ComboBox()
        Me.cmb_raza_paciente = New System.Windows.Forms.ComboBox()
        Me.cmb_especie_paciente = New System.Windows.Forms.ComboBox()
        Me.txtbox_nombre_paciente = New System.Windows.Forms.TextBox()
        Me.txtbox_cod_cliente_paciente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picturebox_paciente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_volver_paciente
        '
        Me.btn_volver_paciente.Location = New System.Drawing.Point(417, 271)
        Me.btn_volver_paciente.Name = "btn_volver_paciente"
        Me.btn_volver_paciente.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver_paciente.TabIndex = 44
        Me.btn_volver_paciente.Text = "Cancelar"
        Me.btn_volver_paciente.UseVisualStyleBackColor = True
        '
        'btn_guardar_paciente
        '
        Me.btn_guardar_paciente.Location = New System.Drawing.Point(336, 271)
        Me.btn_guardar_paciente.Name = "btn_guardar_paciente"
        Me.btn_guardar_paciente.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar_paciente.TabIndex = 43
        Me.btn_guardar_paciente.Text = "Modificar"
        Me.btn_guardar_paciente.UseVisualStyleBackColor = True
        '
        'picturebox_paciente
        '
        Me.picturebox_paciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picturebox_paciente.Image = Global.Veterinaria.My.Resources.Resources.sample
        Me.picturebox_paciente.Location = New System.Drawing.Point(302, 12)
        Me.picturebox_paciente.Name = "picturebox_paciente"
        Me.picturebox_paciente.Size = New System.Drawing.Size(190, 190)
        Me.picturebox_paciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picturebox_paciente.TabIndex = 42
        Me.picturebox_paciente.TabStop = False
        '
        'txtbox_microchip_paciente
        '
        Me.txtbox_microchip_paciente.Location = New System.Drawing.Point(127, 223)
        Me.txtbox_microchip_paciente.MaxLength = 4
        Me.txtbox_microchip_paciente.Name = "txtbox_microchip_paciente"
        Me.txtbox_microchip_paciente.Size = New System.Drawing.Size(121, 20)
        Me.txtbox_microchip_paciente.TabIndex = 40
        '
        'dtp_ult_visita_paciente
        '
        Me.dtp_ult_visita_paciente.Enabled = False
        Me.dtp_ult_visita_paciente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ult_visita_paciente.Location = New System.Drawing.Point(127, 197)
        Me.dtp_ult_visita_paciente.Name = "dtp_ult_visita_paciente"
        Me.dtp_ult_visita_paciente.Size = New System.Drawing.Size(121, 20)
        Me.dtp_ult_visita_paciente.TabIndex = 39
        '
        'dtp_alta_paciente
        '
        Me.dtp_alta_paciente.Enabled = False
        Me.dtp_alta_paciente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_alta_paciente.Location = New System.Drawing.Point(127, 171)
        Me.dtp_alta_paciente.Name = "dtp_alta_paciente"
        Me.dtp_alta_paciente.Size = New System.Drawing.Size(121, 20)
        Me.dtp_alta_paciente.TabIndex = 38
        '
        'dtp_nac_paciente
        '
        Me.dtp_nac_paciente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_nac_paciente.Location = New System.Drawing.Point(127, 145)
        Me.dtp_nac_paciente.Name = "dtp_nac_paciente"
        Me.dtp_nac_paciente.Size = New System.Drawing.Size(121, 20)
        Me.dtp_nac_paciente.TabIndex = 37
        '
        'cmb_sexo_paciente
        '
        Me.cmb_sexo_paciente.FormattingEnabled = True
        Me.cmb_sexo_paciente.Items.AddRange(New Object() {"Macho", "Hembra"})
        Me.cmb_sexo_paciente.Location = New System.Drawing.Point(127, 118)
        Me.cmb_sexo_paciente.Name = "cmb_sexo_paciente"
        Me.cmb_sexo_paciente.Size = New System.Drawing.Size(121, 21)
        Me.cmb_sexo_paciente.TabIndex = 36
        '
        'cmb_raza_paciente
        '
        Me.cmb_raza_paciente.FormattingEnabled = True
        Me.cmb_raza_paciente.Location = New System.Drawing.Point(127, 91)
        Me.cmb_raza_paciente.Name = "cmb_raza_paciente"
        Me.cmb_raza_paciente.Size = New System.Drawing.Size(121, 21)
        Me.cmb_raza_paciente.TabIndex = 35
        '
        'cmb_especie_paciente
        '
        Me.cmb_especie_paciente.FormattingEnabled = True
        Me.cmb_especie_paciente.Location = New System.Drawing.Point(127, 64)
        Me.cmb_especie_paciente.Name = "cmb_especie_paciente"
        Me.cmb_especie_paciente.Size = New System.Drawing.Size(121, 21)
        Me.cmb_especie_paciente.TabIndex = 34
        '
        'txtbox_nombre_paciente
        '
        Me.txtbox_nombre_paciente.Location = New System.Drawing.Point(127, 38)
        Me.txtbox_nombre_paciente.Name = "txtbox_nombre_paciente"
        Me.txtbox_nombre_paciente.Size = New System.Drawing.Size(121, 20)
        Me.txtbox_nombre_paciente.TabIndex = 33
        '
        'txtbox_cod_cliente_paciente
        '
        Me.txtbox_cod_cliente_paciente.Enabled = False
        Me.txtbox_cod_cliente_paciente.Location = New System.Drawing.Point(127, 12)
        Me.txtbox_cod_cliente_paciente.Name = "txtbox_cod_cliente_paciente"
        Me.txtbox_cod_cliente_paciente.Size = New System.Drawing.Size(121, 20)
        Me.txtbox_cod_cliente_paciente.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(65, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Microchip:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(55, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Ultima visita:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Fecha de Alta:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Fecha de Nacimiento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Sexo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Raza:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(73, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Especie:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nombre del Paciente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(78, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Codigo:"
        '
        'Ficha_Pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 312)
        Me.Controls.Add(Me.btn_volver_paciente)
        Me.Controls.Add(Me.btn_guardar_paciente)
        Me.Controls.Add(Me.picturebox_paciente)
        Me.Controls.Add(Me.txtbox_microchip_paciente)
        Me.Controls.Add(Me.dtp_ult_visita_paciente)
        Me.Controls.Add(Me.dtp_alta_paciente)
        Me.Controls.Add(Me.dtp_nac_paciente)
        Me.Controls.Add(Me.cmb_sexo_paciente)
        Me.Controls.Add(Me.cmb_raza_paciente)
        Me.Controls.Add(Me.cmb_especie_paciente)
        Me.Controls.Add(Me.txtbox_nombre_paciente)
        Me.Controls.Add(Me.txtbox_cod_cliente_paciente)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ficha_Pacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ficha de Paciente"
        CType(Me.picturebox_paciente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_volver_paciente As Button
    Friend WithEvents btn_guardar_paciente As Button
    Friend WithEvents picturebox_paciente As PictureBox
    Friend WithEvents txtbox_microchip_paciente As TextBox
    Friend WithEvents dtp_ult_visita_paciente As DateTimePicker
    Friend WithEvents dtp_alta_paciente As DateTimePicker
    Friend WithEvents dtp_nac_paciente As DateTimePicker
    Friend WithEvents cmb_sexo_paciente As ComboBox
    Friend WithEvents cmb_raza_paciente As ComboBox
    Friend WithEvents cmb_especie_paciente As ComboBox
    Friend WithEvents txtbox_nombre_paciente As TextBox
    Friend WithEvents txtbox_cod_cliente_paciente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
