<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingresar_Guarderia
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nombre_cliente_guard = New System.Windows.Forms.TextBox()
        Me.direccion_cliente_guard = New System.Windows.Forms.TextBox()
        Me.telefono_cliente_guard = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtp_fechanac_guard = New System.Windows.Forms.DateTimePicker()
        Me.raza_paciente_guard = New System.Windows.Forms.TextBox()
        Me.sexo_paciente_guard = New System.Windows.Forms.TextBox()
        Me.especie_paciente_guard = New System.Windows.Forms.TextBox()
        Me.cmb_paciente_guard = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label_Hoy_Es = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_importe_guard = New System.Windows.Forms.TextBox()
        Me.txt_seña_guard = New System.Windows.Forms.TextBox()
        Me.txt_saldo_guard = New System.Windows.Forms.TextBox()
        Me.dtp_ingreso_guard = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fechasalida_guard = New System.Windows.Forms.DateTimePicker()
        Me.txt_costoxdia_guard = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_noches_guard = New System.Windows.Forms.TextBox()
        Me.CheckBox_incluyesalida_guard = New System.Windows.Forms.CheckBox()
        Me.btn_buscar_client_guard = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_alimento = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_notas = New System.Windows.Forms.TextBox()
        Me.btn_guardar_paciente_guard = New System.Windows.Forms.Button()
        Me.btn_cancelar_ing_guard = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dirección:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono:"
        '
        'nombre_cliente_guard
        '
        Me.nombre_cliente_guard.Enabled = False
        Me.nombre_cliente_guard.Location = New System.Drawing.Point(72, 32)
        Me.nombre_cliente_guard.Name = "nombre_cliente_guard"
        Me.nombre_cliente_guard.Size = New System.Drawing.Size(275, 20)
        Me.nombre_cliente_guard.TabIndex = 3
        '
        'direccion_cliente_guard
        '
        Me.direccion_cliente_guard.Enabled = False
        Me.direccion_cliente_guard.Location = New System.Drawing.Point(72, 65)
        Me.direccion_cliente_guard.Name = "direccion_cliente_guard"
        Me.direccion_cliente_guard.Size = New System.Drawing.Size(275, 20)
        Me.direccion_cliente_guard.TabIndex = 4
        '
        'telefono_cliente_guard
        '
        Me.telefono_cliente_guard.Enabled = False
        Me.telefono_cliente_guard.Location = New System.Drawing.Point(72, 99)
        Me.telefono_cliente_guard.Name = "telefono_cliente_guard"
        Me.telefono_cliente_guard.Size = New System.Drawing.Size(135, 20)
        Me.telefono_cliente_guard.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.telefono_cliente_guard)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.direccion_cliente_guard)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.nombre_cliente_guard)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 149)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtp_fechanac_guard)
        Me.GroupBox2.Controls.Add(Me.raza_paciente_guard)
        Me.GroupBox2.Controls.Add(Me.sexo_paciente_guard)
        Me.GroupBox2.Controls.Add(Me.especie_paciente_guard)
        Me.GroupBox2.Controls.Add(Me.cmb_paciente_guard)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(367, 133)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Paciente"
        '
        'dtp_fechanac_guard
        '
        Me.dtp_fechanac_guard.Enabled = False
        Me.dtp_fechanac_guard.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechanac_guard.Location = New System.Drawing.Point(249, 94)
        Me.dtp_fechanac_guard.Name = "dtp_fechanac_guard"
        Me.dtp_fechanac_guard.Size = New System.Drawing.Size(98, 20)
        Me.dtp_fechanac_guard.TabIndex = 9
        '
        'raza_paciente_guard
        '
        Me.raza_paciente_guard.Enabled = False
        Me.raza_paciente_guard.Location = New System.Drawing.Point(249, 59)
        Me.raza_paciente_guard.Name = "raza_paciente_guard"
        Me.raza_paciente_guard.Size = New System.Drawing.Size(98, 20)
        Me.raza_paciente_guard.TabIndex = 8
        '
        'sexo_paciente_guard
        '
        Me.sexo_paciente_guard.Enabled = False
        Me.sexo_paciente_guard.Location = New System.Drawing.Point(71, 94)
        Me.sexo_paciente_guard.Name = "sexo_paciente_guard"
        Me.sexo_paciente_guard.Size = New System.Drawing.Size(100, 20)
        Me.sexo_paciente_guard.TabIndex = 7
        '
        'especie_paciente_guard
        '
        Me.especie_paciente_guard.Enabled = False
        Me.especie_paciente_guard.Location = New System.Drawing.Point(71, 59)
        Me.especie_paciente_guard.Name = "especie_paciente_guard"
        Me.especie_paciente_guard.Size = New System.Drawing.Size(100, 20)
        Me.especie_paciente_guard.TabIndex = 6
        '
        'cmb_paciente_guard
        '
        Me.cmb_paciente_guard.FormattingEnabled = True
        Me.cmb_paciente_guard.Location = New System.Drawing.Point(72, 24)
        Me.cmb_paciente_guard.Name = "cmb_paciente_guard"
        Me.cmb_paciente_guard.Size = New System.Drawing.Size(275, 21)
        Me.cmb_paciente_guard.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(177, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Fecha Nac.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(208, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Raza:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Sexo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Especie:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Paciente:"
        '
        'Label_Hoy_Es
        '
        Me.Label_Hoy_Es.AutoSize = True
        Me.Label_Hoy_Es.Location = New System.Drawing.Point(12, 315)
        Me.Label_Hoy_Es.Name = "Label_Hoy_Es"
        Me.Label_Hoy_Es.Size = New System.Drawing.Size(0, 13)
        Me.Label_Hoy_Es.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 335)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Fecha de Ingreso:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 367)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Costo x Día:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 397)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Fecha de Salida:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(228, 335)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Importe:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(238, 367)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Seña:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(236, 397)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Saldo:"
        '
        'txt_importe_guard
        '
        Me.txt_importe_guard.Enabled = False
        Me.txt_importe_guard.Location = New System.Drawing.Point(279, 332)
        Me.txt_importe_guard.Name = "txt_importe_guard"
        Me.txt_importe_guard.Size = New System.Drawing.Size(100, 20)
        Me.txt_importe_guard.TabIndex = 15
        Me.txt_importe_guard.Text = "0"
        '
        'txt_seña_guard
        '
        Me.txt_seña_guard.Location = New System.Drawing.Point(279, 364)
        Me.txt_seña_guard.MaxLength = 10
        Me.txt_seña_guard.Name = "txt_seña_guard"
        Me.txt_seña_guard.Size = New System.Drawing.Size(100, 20)
        Me.txt_seña_guard.TabIndex = 16
        Me.txt_seña_guard.Text = "0"
        '
        'txt_saldo_guard
        '
        Me.txt_saldo_guard.Enabled = False
        Me.txt_saldo_guard.Location = New System.Drawing.Point(279, 394)
        Me.txt_saldo_guard.Name = "txt_saldo_guard"
        Me.txt_saldo_guard.Size = New System.Drawing.Size(100, 20)
        Me.txt_saldo_guard.TabIndex = 17
        Me.txt_saldo_guard.Text = "0"
        '
        'dtp_ingreso_guard
        '
        Me.dtp_ingreso_guard.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ingreso_guard.Location = New System.Drawing.Point(110, 332)
        Me.dtp_ingreso_guard.Name = "dtp_ingreso_guard"
        Me.dtp_ingreso_guard.Size = New System.Drawing.Size(103, 20)
        Me.dtp_ingreso_guard.TabIndex = 18
        '
        'dtp_fechasalida_guard
        '
        Me.dtp_fechasalida_guard.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechasalida_guard.Location = New System.Drawing.Point(110, 394)
        Me.dtp_fechasalida_guard.Name = "dtp_fechasalida_guard"
        Me.dtp_fechasalida_guard.Size = New System.Drawing.Size(103, 20)
        Me.dtp_fechasalida_guard.TabIndex = 19
        '
        'txt_costoxdia_guard
        '
        Me.txt_costoxdia_guard.Location = New System.Drawing.Point(110, 364)
        Me.txt_costoxdia_guard.MaxLength = 10
        Me.txt_costoxdia_guard.Name = "txt_costoxdia_guard"
        Me.txt_costoxdia_guard.Size = New System.Drawing.Size(103, 20)
        Me.txt_costoxdia_guard.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 432)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Noches de Guarderia:"
        '
        'txt_noches_guard
        '
        Me.txt_noches_guard.Enabled = False
        Me.txt_noches_guard.Location = New System.Drawing.Point(126, 429)
        Me.txt_noches_guard.Name = "txt_noches_guard"
        Me.txt_noches_guard.Size = New System.Drawing.Size(57, 20)
        Me.txt_noches_guard.TabIndex = 22
        Me.txt_noches_guard.Text = "0"
        '
        'CheckBox_incluyesalida_guard
        '
        Me.CheckBox_incluyesalida_guard.AutoSize = True
        Me.CheckBox_incluyesalida_guard.Location = New System.Drawing.Point(192, 431)
        Me.CheckBox_incluyesalida_guard.Name = "CheckBox_incluyesalida_guard"
        Me.CheckBox_incluyesalida_guard.Size = New System.Drawing.Size(143, 17)
        Me.CheckBox_incluyesalida_guard.TabIndex = 23
        Me.CheckBox_incluyesalida_guard.Text = "Incluye el día de Salida?"
        Me.CheckBox_incluyesalida_guard.UseVisualStyleBackColor = True
        '
        'btn_buscar_client_guard
        '
        Me.btn_buscar_client_guard.Location = New System.Drawing.Point(513, 42)
        Me.btn_buscar_client_guard.Name = "btn_buscar_client_guard"
        Me.btn_buscar_client_guard.Size = New System.Drawing.Size(108, 23)
        Me.btn_buscar_client_guard.TabIndex = 24
        Me.btn_buscar_client_guard.Text = "Buscar Cliente"
        Me.btn_buscar_client_guard.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(385, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(50, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Alimento:"
        '
        'txt_alimento
        '
        Me.txt_alimento.Location = New System.Drawing.Point(388, 104)
        Me.txt_alimento.Name = "txt_alimento"
        Me.txt_alimento.Size = New System.Drawing.Size(355, 20)
        Me.txt_alimento.TabIndex = 26
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(385, 127)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Notas:"
        '
        'txt_notas
        '
        Me.txt_notas.Location = New System.Drawing.Point(388, 143)
        Me.txt_notas.Multiline = True
        Me.txt_notas.Name = "txt_notas"
        Me.txt_notas.Size = New System.Drawing.Size(355, 271)
        Me.txt_notas.TabIndex = 28
        '
        'btn_guardar_paciente_guard
        '
        Me.btn_guardar_paciente_guard.Location = New System.Drawing.Point(587, 429)
        Me.btn_guardar_paciente_guard.Name = "btn_guardar_paciente_guard"
        Me.btn_guardar_paciente_guard.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar_paciente_guard.TabIndex = 29
        Me.btn_guardar_paciente_guard.Text = "Guardar"
        Me.btn_guardar_paciente_guard.UseVisualStyleBackColor = True
        '
        'btn_cancelar_ing_guard
        '
        Me.btn_cancelar_ing_guard.Location = New System.Drawing.Point(668, 429)
        Me.btn_cancelar_ing_guard.Name = "btn_cancelar_ing_guard"
        Me.btn_cancelar_ing_guard.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar_ing_guard.TabIndex = 30
        Me.btn_cancelar_ing_guard.Text = "Cancelar"
        Me.btn_cancelar_ing_guard.UseVisualStyleBackColor = True
        '
        'Ingresar_Guarderia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 466)
        Me.Controls.Add(Me.btn_cancelar_ing_guard)
        Me.Controls.Add(Me.btn_guardar_paciente_guard)
        Me.Controls.Add(Me.txt_notas)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_alimento)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btn_buscar_client_guard)
        Me.Controls.Add(Me.CheckBox_incluyesalida_guard)
        Me.Controls.Add(Me.txt_noches_guard)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txt_costoxdia_guard)
        Me.Controls.Add(Me.dtp_fechasalida_guard)
        Me.Controls.Add(Me.dtp_ingreso_guard)
        Me.Controls.Add(Me.txt_saldo_guard)
        Me.Controls.Add(Me.txt_seña_guard)
        Me.Controls.Add(Me.txt_importe_guard)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label_Hoy_Es)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingresar_Guarderia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar en Guarderia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents nombre_cliente_guard As TextBox
    Friend WithEvents direccion_cliente_guard As TextBox
    Friend WithEvents telefono_cliente_guard As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtp_fechanac_guard As DateTimePicker
    Friend WithEvents raza_paciente_guard As TextBox
    Friend WithEvents sexo_paciente_guard As TextBox
    Friend WithEvents especie_paciente_guard As TextBox
    Friend WithEvents cmb_paciente_guard As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label_Hoy_Es As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_importe_guard As TextBox
    Friend WithEvents txt_seña_guard As TextBox
    Friend WithEvents txt_saldo_guard As TextBox
    Friend WithEvents dtp_ingreso_guard As DateTimePicker
    Friend WithEvents dtp_fechasalida_guard As DateTimePicker
    Friend WithEvents txt_costoxdia_guard As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_noches_guard As TextBox
    Friend WithEvents CheckBox_incluyesalida_guard As CheckBox
    Friend WithEvents btn_buscar_client_guard As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_alimento As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_notas As TextBox
    Friend WithEvents btn_guardar_paciente_guard As Button
    Friend WithEvents btn_cancelar_ing_guard As Button
End Class
