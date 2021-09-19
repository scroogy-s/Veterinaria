<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salida_Guarderia
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
        Me.CheckBox_incluyesalida_guard = New System.Windows.Forms.CheckBox()
        Me.txt_noches_guard = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_costoxdia_guard = New System.Windows.Forms.TextBox()
        Me.dtp_fechasalida_guard = New System.Windows.Forms.DateTimePicker()
        Me.dtp_ingreso_guard = New System.Windows.Forms.DateTimePicker()
        Me.txt_saldo_guard = New System.Windows.Forms.TextBox()
        Me.txt_seña_guard = New System.Windows.Forms.TextBox()
        Me.txt_importe_guard = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nombre_cliente_guard = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nombre_paciente_guard = New System.Windows.Forms.TextBox()
        Me.Label_Hoy_Es = New System.Windows.Forms.Label()
        Me.btn_aceptar_salida = New System.Windows.Forms.Button()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckBox_incluyesalida_guard
        '
        Me.CheckBox_incluyesalida_guard.AutoSize = True
        Me.CheckBox_incluyesalida_guard.Enabled = False
        Me.CheckBox_incluyesalida_guard.Location = New System.Drawing.Point(194, 230)
        Me.CheckBox_incluyesalida_guard.Name = "CheckBox_incluyesalida_guard"
        Me.CheckBox_incluyesalida_guard.Size = New System.Drawing.Size(143, 17)
        Me.CheckBox_incluyesalida_guard.TabIndex = 38
        Me.CheckBox_incluyesalida_guard.Text = "Incluye el día de Salida?"
        Me.CheckBox_incluyesalida_guard.UseVisualStyleBackColor = True
        '
        'txt_noches_guard
        '
        Me.txt_noches_guard.Enabled = False
        Me.txt_noches_guard.Location = New System.Drawing.Point(128, 228)
        Me.txt_noches_guard.Name = "txt_noches_guard"
        Me.txt_noches_guard.Size = New System.Drawing.Size(57, 20)
        Me.txt_noches_guard.TabIndex = 37
        Me.txt_noches_guard.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Enabled = False
        Me.Label15.Location = New System.Drawing.Point(11, 231)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 13)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Noches de Guarderia:"
        '
        'txt_costoxdia_guard
        '
        Me.txt_costoxdia_guard.Enabled = False
        Me.txt_costoxdia_guard.Location = New System.Drawing.Point(112, 163)
        Me.txt_costoxdia_guard.MaxLength = 10
        Me.txt_costoxdia_guard.Name = "txt_costoxdia_guard"
        Me.txt_costoxdia_guard.Size = New System.Drawing.Size(103, 20)
        Me.txt_costoxdia_guard.TabIndex = 35
        '
        'dtp_fechasalida_guard
        '
        Me.dtp_fechasalida_guard.Enabled = False
        Me.dtp_fechasalida_guard.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fechasalida_guard.Location = New System.Drawing.Point(112, 193)
        Me.dtp_fechasalida_guard.Name = "dtp_fechasalida_guard"
        Me.dtp_fechasalida_guard.Size = New System.Drawing.Size(103, 20)
        Me.dtp_fechasalida_guard.TabIndex = 34
        '
        'dtp_ingreso_guard
        '
        Me.dtp_ingreso_guard.Enabled = False
        Me.dtp_ingreso_guard.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ingreso_guard.Location = New System.Drawing.Point(112, 131)
        Me.dtp_ingreso_guard.Name = "dtp_ingreso_guard"
        Me.dtp_ingreso_guard.Size = New System.Drawing.Size(103, 20)
        Me.dtp_ingreso_guard.TabIndex = 33
        '
        'txt_saldo_guard
        '
        Me.txt_saldo_guard.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_saldo_guard.Enabled = False
        Me.txt_saldo_guard.Location = New System.Drawing.Point(281, 193)
        Me.txt_saldo_guard.Name = "txt_saldo_guard"
        Me.txt_saldo_guard.Size = New System.Drawing.Size(100, 20)
        Me.txt_saldo_guard.TabIndex = 32
        Me.txt_saldo_guard.Text = "0"
        '
        'txt_seña_guard
        '
        Me.txt_seña_guard.Enabled = False
        Me.txt_seña_guard.Location = New System.Drawing.Point(281, 163)
        Me.txt_seña_guard.MaxLength = 10
        Me.txt_seña_guard.Name = "txt_seña_guard"
        Me.txt_seña_guard.Size = New System.Drawing.Size(100, 20)
        Me.txt_seña_guard.TabIndex = 31
        Me.txt_seña_guard.Text = "0"
        '
        'txt_importe_guard
        '
        Me.txt_importe_guard.Enabled = False
        Me.txt_importe_guard.Location = New System.Drawing.Point(281, 131)
        Me.txt_importe_guard.Name = "txt_importe_guard"
        Me.txt_importe_guard.Size = New System.Drawing.Size(100, 20)
        Me.txt_importe_guard.TabIndex = 30
        Me.txt_importe_guard.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Enabled = False
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(238, 196)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Saldo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Enabled = False
        Me.Label13.Location = New System.Drawing.Point(240, 166)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Seña:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Enabled = False
        Me.Label12.Location = New System.Drawing.Point(230, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Importe:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.Location = New System.Drawing.Point(19, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Fecha de Salida:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Location = New System.Drawing.Point(40, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Costo x Día:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Location = New System.Drawing.Point(13, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Fecha de Ingreso:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(59, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Cliente:"
        '
        'nombre_cliente_guard
        '
        Me.nombre_cliente_guard.Enabled = False
        Me.nombre_cliente_guard.Location = New System.Drawing.Point(112, 66)
        Me.nombre_cliente_guard.Name = "nombre_cliente_guard"
        Me.nombre_cliente_guard.Size = New System.Drawing.Size(269, 20)
        Me.nombre_cliente_guard.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(59, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Paciente:"
        '
        'nombre_paciente_guard
        '
        Me.nombre_paciente_guard.Enabled = False
        Me.nombre_paciente_guard.Location = New System.Drawing.Point(112, 92)
        Me.nombre_paciente_guard.Name = "nombre_paciente_guard"
        Me.nombre_paciente_guard.Size = New System.Drawing.Size(269, 20)
        Me.nombre_paciente_guard.TabIndex = 42
        '
        'Label_Hoy_Es
        '
        Me.Label_Hoy_Es.AutoSize = True
        Me.Label_Hoy_Es.Enabled = False
        Me.Label_Hoy_Es.Location = New System.Drawing.Point(13, 21)
        Me.Label_Hoy_Es.Name = "Label_Hoy_Es"
        Me.Label_Hoy_Es.Size = New System.Drawing.Size(0, 13)
        Me.Label_Hoy_Es.TabIndex = 43
        '
        'btn_aceptar_salida
        '
        Me.btn_aceptar_salida.Location = New System.Drawing.Point(213, 277)
        Me.btn_aceptar_salida.Name = "btn_aceptar_salida"
        Me.btn_aceptar_salida.Size = New System.Drawing.Size(87, 23)
        Me.btn_aceptar_salida.TabIndex = 44
        Me.btn_aceptar_salida.Text = "Aceptar Salida"
        Me.btn_aceptar_salida.UseVisualStyleBackColor = True
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(306, 277)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver.TabIndex = 45
        Me.btn_volver.Text = "Cancelar"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'Salida_Guarderia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 323)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_aceptar_salida)
        Me.Controls.Add(Me.Label_Hoy_Es)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nombre_paciente_guard)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nombre_cliente_guard)
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Salida_Guarderia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salida de la Guarderia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckBox_incluyesalida_guard As CheckBox
    Friend WithEvents txt_noches_guard As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_costoxdia_guard As TextBox
    Friend WithEvents dtp_fechasalida_guard As DateTimePicker
    Friend WithEvents dtp_ingreso_guard As DateTimePicker
    Friend WithEvents txt_saldo_guard As TextBox
    Friend WithEvents txt_seña_guard As TextBox
    Friend WithEvents txt_importe_guard As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nombre_cliente_guard As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nombre_paciente_guard As TextBox
    Friend WithEvents Label_Hoy_Es As Label
    Friend WithEvents btn_aceptar_salida As Button
    Friend WithEvents btn_volver As Button
End Class
