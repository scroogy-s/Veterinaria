<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ficha_Cliente
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
        Me.cmb_provincia = New System.Windows.Forms.ComboBox()
        Me.PictureBox_cliente = New System.Windows.Forms.PictureBox()
        Me.dtp_ult_visita_cliente = New System.Windows.Forms.DateTimePicker()
        Me.dtp_alta_cliente = New System.Windows.Forms.DateTimePicker()
        Me.cmb_localidad = New System.Windows.Forms.ComboBox()
        Me.cmb_empresa_celular = New System.Windows.Forms.ComboBox()
        Me.txtbox_email_cliente = New System.Windows.Forms.TextBox()
        Me.txtbox_codigo_postal = New System.Windows.Forms.TextBox()
        Me.txtbox_cel_cliente = New System.Windows.Forms.TextBox()
        Me.txtbox_direccion_cliente = New System.Windows.Forms.TextBox()
        Me.txtbox_nombre_cliente = New System.Windows.Forms.TextBox()
        Me.txtbox_codigo_cliente = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_agregar_pacientes_ficha = New System.Windows.Forms.Button()
        Me.btn_modificar_ficha_cliente = New System.Windows.Forms.Button()
        Me.btn_ficha_cliente_cerrar = New System.Windows.Forms.Button()
        CType(Me.PictureBox_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_provincia
        '
        Me.cmb_provincia.FormattingEnabled = True
        Me.cmb_provincia.Location = New System.Drawing.Point(113, 142)
        Me.cmb_provincia.Name = "cmb_provincia"
        Me.cmb_provincia.Size = New System.Drawing.Size(189, 21)
        Me.cmb_provincia.TabIndex = 57
        '
        'PictureBox_cliente
        '
        Me.PictureBox_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox_cliente.Image = Global.Veterinaria.My.Resources.Resources.sample
        Me.PictureBox_cliente.Location = New System.Drawing.Point(335, 38)
        Me.PictureBox_cliente.Name = "PictureBox_cliente"
        Me.PictureBox_cliente.Size = New System.Drawing.Size(176, 178)
        Me.PictureBox_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_cliente.TabIndex = 54
        Me.PictureBox_cliente.TabStop = False
        '
        'dtp_ult_visita_cliente
        '
        Me.dtp_ult_visita_cliente.Enabled = False
        Me.dtp_ult_visita_cliente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ult_visita_cliente.Location = New System.Drawing.Point(335, 291)
        Me.dtp_ult_visita_cliente.Name = "dtp_ult_visita_cliente"
        Me.dtp_ult_visita_cliente.Size = New System.Drawing.Size(95, 20)
        Me.dtp_ult_visita_cliente.TabIndex = 53
        '
        'dtp_alta_cliente
        '
        Me.dtp_alta_cliente.Enabled = False
        Me.dtp_alta_cliente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_alta_cliente.Location = New System.Drawing.Point(113, 291)
        Me.dtp_alta_cliente.Name = "dtp_alta_cliente"
        Me.dtp_alta_cliente.Size = New System.Drawing.Size(95, 20)
        Me.dtp_alta_cliente.TabIndex = 52
        '
        'cmb_localidad
        '
        Me.cmb_localidad.FormattingEnabled = True
        Me.cmb_localidad.Location = New System.Drawing.Point(113, 169)
        Me.cmb_localidad.Name = "cmb_localidad"
        Me.cmb_localidad.Size = New System.Drawing.Size(189, 21)
        Me.cmb_localidad.TabIndex = 51
        '
        'cmb_empresa_celular
        '
        Me.cmb_empresa_celular.FormattingEnabled = True
        Me.cmb_empresa_celular.Items.AddRange(New Object() {"Personal", "Claro", "Movistar"})
        Me.cmb_empresa_celular.Location = New System.Drawing.Point(214, 116)
        Me.cmb_empresa_celular.Name = "cmb_empresa_celular"
        Me.cmb_empresa_celular.Size = New System.Drawing.Size(88, 21)
        Me.cmb_empresa_celular.TabIndex = 50
        '
        'txtbox_email_cliente
        '
        Me.txtbox_email_cliente.Location = New System.Drawing.Point(113, 265)
        Me.txtbox_email_cliente.Name = "txtbox_email_cliente"
        Me.txtbox_email_cliente.Size = New System.Drawing.Size(189, 20)
        Me.txtbox_email_cliente.TabIndex = 49
        '
        'txtbox_codigo_postal
        '
        Me.txtbox_codigo_postal.Enabled = False
        Me.txtbox_codigo_postal.Location = New System.Drawing.Point(113, 196)
        Me.txtbox_codigo_postal.Name = "txtbox_codigo_postal"
        Me.txtbox_codigo_postal.Size = New System.Drawing.Size(95, 20)
        Me.txtbox_codigo_postal.TabIndex = 48
        '
        'txtbox_cel_cliente
        '
        Me.txtbox_cel_cliente.Location = New System.Drawing.Point(113, 116)
        Me.txtbox_cel_cliente.Name = "txtbox_cel_cliente"
        Me.txtbox_cel_cliente.Size = New System.Drawing.Size(95, 20)
        Me.txtbox_cel_cliente.TabIndex = 47
        '
        'txtbox_direccion_cliente
        '
        Me.txtbox_direccion_cliente.Location = New System.Drawing.Point(113, 64)
        Me.txtbox_direccion_cliente.Name = "txtbox_direccion_cliente"
        Me.txtbox_direccion_cliente.Size = New System.Drawing.Size(189, 20)
        Me.txtbox_direccion_cliente.TabIndex = 45
        '
        'txtbox_nombre_cliente
        '
        Me.txtbox_nombre_cliente.Location = New System.Drawing.Point(113, 38)
        Me.txtbox_nombre_cliente.Name = "txtbox_nombre_cliente"
        Me.txtbox_nombre_cliente.Size = New System.Drawing.Size(189, 20)
        Me.txtbox_nombre_cliente.TabIndex = 44
        '
        'txtbox_codigo_cliente
        '
        Me.txtbox_codigo_cliente.Enabled = False
        Me.txtbox_codigo_cliente.Location = New System.Drawing.Point(113, 12)
        Me.txtbox_codigo_cliente.Name = "txtbox_codigo_cliente"
        Me.txtbox_codigo_cliente.Size = New System.Drawing.Size(95, 20)
        Me.txtbox_codigo_cliente.TabIndex = 43
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(214, 297)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 13)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Fecha de Ultima Visita:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(46, 297)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Fecha Alta:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(69, 268)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "e-Mail:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Codigo Postal:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Provincia:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Localidad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Celular:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Dirección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Nombre y Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Codigo:"
        '
        'btn_agregar_pacientes_ficha
        '
        Me.btn_agregar_pacientes_ficha.Location = New System.Drawing.Point(243, 345)
        Me.btn_agregar_pacientes_ficha.Name = "btn_agregar_pacientes_ficha"
        Me.btn_agregar_pacientes_ficha.Size = New System.Drawing.Size(116, 23)
        Me.btn_agregar_pacientes_ficha.TabIndex = 58
        Me.btn_agregar_pacientes_ficha.Text = "Agregar Pacientes"
        Me.btn_agregar_pacientes_ficha.UseVisualStyleBackColor = True
        '
        'btn_modificar_ficha_cliente
        '
        Me.btn_modificar_ficha_cliente.Location = New System.Drawing.Point(365, 345)
        Me.btn_modificar_ficha_cliente.Name = "btn_modificar_ficha_cliente"
        Me.btn_modificar_ficha_cliente.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificar_ficha_cliente.TabIndex = 59
        Me.btn_modificar_ficha_cliente.Text = "Modificar"
        Me.btn_modificar_ficha_cliente.UseVisualStyleBackColor = True
        '
        'btn_ficha_cliente_cerrar
        '
        Me.btn_ficha_cliente_cerrar.Location = New System.Drawing.Point(446, 345)
        Me.btn_ficha_cliente_cerrar.Name = "btn_ficha_cliente_cerrar"
        Me.btn_ficha_cliente_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_ficha_cliente_cerrar.TabIndex = 60
        Me.btn_ficha_cliente_cerrar.Text = "Cerrar"
        Me.btn_ficha_cliente_cerrar.UseVisualStyleBackColor = True
        '
        'Ficha_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 388)
        Me.Controls.Add(Me.btn_ficha_cliente_cerrar)
        Me.Controls.Add(Me.btn_modificar_ficha_cliente)
        Me.Controls.Add(Me.btn_agregar_pacientes_ficha)
        Me.Controls.Add(Me.cmb_provincia)
        Me.Controls.Add(Me.PictureBox_cliente)
        Me.Controls.Add(Me.dtp_ult_visita_cliente)
        Me.Controls.Add(Me.dtp_alta_cliente)
        Me.Controls.Add(Me.cmb_localidad)
        Me.Controls.Add(Me.cmb_empresa_celular)
        Me.Controls.Add(Me.txtbox_email_cliente)
        Me.Controls.Add(Me.txtbox_codigo_postal)
        Me.Controls.Add(Me.txtbox_cel_cliente)
        Me.Controls.Add(Me.txtbox_direccion_cliente)
        Me.Controls.Add(Me.txtbox_nombre_cliente)
        Me.Controls.Add(Me.txtbox_codigo_cliente)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ficha_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ficha de Cliente"
        CType(Me.PictureBox_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_provincia As ComboBox
    Friend WithEvents PictureBox_cliente As PictureBox
    Friend WithEvents dtp_ult_visita_cliente As DateTimePicker
    Friend WithEvents dtp_alta_cliente As DateTimePicker
    Friend WithEvents cmb_localidad As ComboBox
    Friend WithEvents cmb_empresa_celular As ComboBox
    Friend WithEvents txtbox_email_cliente As TextBox
    Friend WithEvents txtbox_codigo_postal As TextBox
    Friend WithEvents txtbox_cel_cliente As TextBox
    Friend WithEvents txtbox_direccion_cliente As TextBox
    Friend WithEvents txtbox_nombre_cliente As TextBox
    Friend WithEvents txtbox_codigo_cliente As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_agregar_pacientes_ficha As Button
    Friend WithEvents btn_modificar_ficha_cliente As Button
    Friend WithEvents btn_ficha_cliente_cerrar As Button
End Class
