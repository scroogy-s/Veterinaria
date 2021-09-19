<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_Cliente
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtbox_codigo_cliente = New System.Windows.Forms.TextBox()
        Me.txtbox_nombre_cliente = New System.Windows.Forms.TextBox()
        Me.txtbox_direccion_cliente = New System.Windows.Forms.TextBox()
        Me.txtbox_cel_cliente = New System.Windows.Forms.TextBox()
        Me.txtbox_codigo_postal = New System.Windows.Forms.TextBox()
        Me.txtbox_email_cliente = New System.Windows.Forms.TextBox()
        Me.cmb_empresa_celular = New System.Windows.Forms.ComboBox()
        Me.cmb_localidad = New System.Windows.Forms.ComboBox()
        Me.dtp_alta_cliente = New System.Windows.Forms.DateTimePicker()
        Me.dtp_ult_visita_cliente = New System.Windows.Forms.DateTimePicker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_buscar_img_cliente = New System.Windows.Forms.Button()
        Me.btn_ingresar_paciente = New System.Windows.Forms.Button()
        Me.btn_guardar_cliente = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.cmb_provincia = New System.Windows.Forms.ComboBox()
        Me.PictureBox_cliente = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre y Apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Celular:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Localidad:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Provincia:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Codigo Postal:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(69, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "e-Mail:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(46, 299)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Fecha Alta:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(214, 299)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Fecha de Ultima Visita:"
        '
        'txtbox_codigo_cliente
        '
        Me.txtbox_codigo_cliente.Enabled = False
        Me.txtbox_codigo_cliente.Location = New System.Drawing.Point(113, 14)
        Me.txtbox_codigo_cliente.Name = "txtbox_codigo_cliente"
        Me.txtbox_codigo_cliente.Size = New System.Drawing.Size(95, 20)
        Me.txtbox_codigo_cliente.TabIndex = 12
        '
        'txtbox_nombre_cliente
        '
        Me.txtbox_nombre_cliente.Location = New System.Drawing.Point(113, 40)
        Me.txtbox_nombre_cliente.Name = "txtbox_nombre_cliente"
        Me.txtbox_nombre_cliente.Size = New System.Drawing.Size(189, 20)
        Me.txtbox_nombre_cliente.TabIndex = 13
        '
        'txtbox_direccion_cliente
        '
        Me.txtbox_direccion_cliente.Location = New System.Drawing.Point(113, 66)
        Me.txtbox_direccion_cliente.Name = "txtbox_direccion_cliente"
        Me.txtbox_direccion_cliente.Size = New System.Drawing.Size(189, 20)
        Me.txtbox_direccion_cliente.TabIndex = 14
        '
        'txtbox_cel_cliente
        '
        Me.txtbox_cel_cliente.Location = New System.Drawing.Point(113, 118)
        Me.txtbox_cel_cliente.Name = "txtbox_cel_cliente"
        Me.txtbox_cel_cliente.Size = New System.Drawing.Size(95, 20)
        Me.txtbox_cel_cliente.TabIndex = 16
        '
        'txtbox_codigo_postal
        '
        Me.txtbox_codigo_postal.Enabled = False
        Me.txtbox_codigo_postal.Location = New System.Drawing.Point(113, 198)
        Me.txtbox_codigo_postal.Name = "txtbox_codigo_postal"
        Me.txtbox_codigo_postal.Size = New System.Drawing.Size(95, 20)
        Me.txtbox_codigo_postal.TabIndex = 19
        '
        'txtbox_email_cliente
        '
        Me.txtbox_email_cliente.Location = New System.Drawing.Point(113, 267)
        Me.txtbox_email_cliente.Name = "txtbox_email_cliente"
        Me.txtbox_email_cliente.Size = New System.Drawing.Size(189, 20)
        Me.txtbox_email_cliente.TabIndex = 20
        '
        'cmb_empresa_celular
        '
        Me.cmb_empresa_celular.FormattingEnabled = True
        Me.cmb_empresa_celular.Items.AddRange(New Object() {"Personal", "Claro", "Movistar"})
        Me.cmb_empresa_celular.Location = New System.Drawing.Point(214, 118)
        Me.cmb_empresa_celular.Name = "cmb_empresa_celular"
        Me.cmb_empresa_celular.Size = New System.Drawing.Size(88, 21)
        Me.cmb_empresa_celular.TabIndex = 21
        '
        'cmb_localidad
        '
        Me.cmb_localidad.FormattingEnabled = True
        Me.cmb_localidad.Location = New System.Drawing.Point(113, 171)
        Me.cmb_localidad.Name = "cmb_localidad"
        Me.cmb_localidad.Size = New System.Drawing.Size(189, 21)
        Me.cmb_localidad.TabIndex = 22
        '
        'dtp_alta_cliente
        '
        Me.dtp_alta_cliente.Enabled = False
        Me.dtp_alta_cliente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_alta_cliente.Location = New System.Drawing.Point(113, 293)
        Me.dtp_alta_cliente.Name = "dtp_alta_cliente"
        Me.dtp_alta_cliente.Size = New System.Drawing.Size(95, 20)
        Me.dtp_alta_cliente.TabIndex = 23
        '
        'dtp_ult_visita_cliente
        '
        Me.dtp_ult_visita_cliente.Enabled = False
        Me.dtp_ult_visita_cliente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ult_visita_cliente.Location = New System.Drawing.Point(335, 293)
        Me.dtp_ult_visita_cliente.Name = "dtp_ult_visita_cliente"
        Me.dtp_ult_visita_cliente.Size = New System.Drawing.Size(95, 20)
        Me.dtp_ult_visita_cliente.TabIndex = 24
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_buscar_img_cliente
        '
        Me.btn_buscar_img_cliente.Location = New System.Drawing.Point(480, 14)
        Me.btn_buscar_img_cliente.Name = "btn_buscar_img_cliente"
        Me.btn_buscar_img_cliente.Size = New System.Drawing.Size(31, 23)
        Me.btn_buscar_img_cliente.TabIndex = 27
        Me.btn_buscar_img_cliente.Text = "..."
        Me.btn_buscar_img_cliente.UseVisualStyleBackColor = True
        '
        'btn_ingresar_paciente
        '
        Me.btn_ingresar_paciente.Location = New System.Drawing.Point(154, 341)
        Me.btn_ingresar_paciente.Name = "btn_ingresar_paciente"
        Me.btn_ingresar_paciente.Size = New System.Drawing.Size(175, 23)
        Me.btn_ingresar_paciente.TabIndex = 28
        Me.btn_ingresar_paciente.Text = "Guardar y agregar Paciente"
        Me.btn_ingresar_paciente.UseVisualStyleBackColor = True
        '
        'btn_guardar_cliente
        '
        Me.btn_guardar_cliente.Location = New System.Drawing.Point(335, 341)
        Me.btn_guardar_cliente.Name = "btn_guardar_cliente"
        Me.btn_guardar_cliente.Size = New System.Drawing.Size(95, 23)
        Me.btn_guardar_cliente.TabIndex = 29
        Me.btn_guardar_cliente.Text = "Guardar"
        Me.btn_guardar_cliente.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(436, 341)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver.TabIndex = 30
        Me.btn_volver.Text = "Cancelar"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'cmb_provincia
        '
        Me.cmb_provincia.FormattingEnabled = True
        Me.cmb_provincia.Location = New System.Drawing.Point(113, 144)
        Me.cmb_provincia.Name = "cmb_provincia"
        Me.cmb_provincia.Size = New System.Drawing.Size(189, 21)
        Me.cmb_provincia.TabIndex = 31
        '
        'PictureBox_cliente
        '
        Me.PictureBox_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox_cliente.Image = Global.Veterinaria.My.Resources.Resources.sample
        Me.PictureBox_cliente.Location = New System.Drawing.Point(335, 40)
        Me.PictureBox_cliente.Name = "PictureBox_cliente"
        Me.PictureBox_cliente.Size = New System.Drawing.Size(176, 178)
        Me.PictureBox_cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_cliente.TabIndex = 25
        Me.PictureBox_cliente.TabStop = False
        '
        'Alta_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 383)
        Me.Controls.Add(Me.cmb_provincia)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_guardar_cliente)
        Me.Controls.Add(Me.btn_ingresar_paciente)
        Me.Controls.Add(Me.btn_buscar_img_cliente)
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
        Me.Name = "Alta_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Cliente"
        CType(Me.PictureBox_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtbox_codigo_cliente As TextBox
    Friend WithEvents txtbox_nombre_cliente As TextBox
    Friend WithEvents txtbox_direccion_cliente As TextBox
    Friend WithEvents txtbox_cel_cliente As TextBox
    Friend WithEvents txtbox_codigo_postal As TextBox
    Friend WithEvents txtbox_email_cliente As TextBox
    Friend WithEvents cmb_empresa_celular As ComboBox
    Friend WithEvents cmb_localidad As ComboBox
    Friend WithEvents dtp_alta_cliente As DateTimePicker
    Friend WithEvents dtp_ult_visita_cliente As DateTimePicker
    Friend WithEvents PictureBox_cliente As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_buscar_img_cliente As Button
    Friend WithEvents btn_ingresar_paciente As Button
    Friend WithEvents btn_guardar_cliente As Button
    Friend WithEvents btn_volver As Button
    Friend WithEvents cmb_provincia As ComboBox
End Class
