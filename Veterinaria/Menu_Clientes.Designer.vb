<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Clientes
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_volver_cliente = New System.Windows.Forms.Button()
        Me.btn_eliminar_cliente = New System.Windows.Forms.Button()
        Me.btn_nuevo_cliente = New System.Windows.Forms.Button()
        Me.btn_abrir_ficha = New System.Windows.Forms.Button()
        Me.cmb_buscar = New System.Windows.Forms.ComboBox()
        Me.txtbox_buscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_pacientes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_vac_atp = New System.Windows.Forms.Button()
        Me.cmb_busq_paciente = New System.Windows.Forms.ComboBox()
        Me.txt_box_busq_paciente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_abrir_ficha_paciente = New System.Windows.Forms.Button()
        Me.btn_eliminar_paciente = New System.Windows.Forms.Button()
        Me.btn_cerrar_2 = New System.Windows.Forms.Button()
        Me.dgv_pacientes_pacientes = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btn_historial_guard = New System.Windows.Forms.Button()
        Me.btn_borrar_guard = New System.Windows.Forms.Button()
        Me.btn_detalle_guard = New System.Windows.Forms.Button()
        Me.btn_salida_guard = New System.Windows.Forms.Button()
        Me.btn_ingreso_guard = New System.Windows.Forms.Button()
        Me.dgv_guarderia = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_pacientes_pacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgv_guarderia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 564)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_volver_cliente)
        Me.TabPage1.Controls.Add(Me.btn_eliminar_cliente)
        Me.TabPage1.Controls.Add(Me.btn_nuevo_cliente)
        Me.TabPage1.Controls.Add(Me.btn_abrir_ficha)
        Me.TabPage1.Controls.Add(Me.cmb_buscar)
        Me.TabPage1.Controls.Add(Me.txtbox_buscar)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(768, 538)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CLIENTES"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_volver_cliente
        '
        Me.btn_volver_cliente.Location = New System.Drawing.Point(661, 494)
        Me.btn_volver_cliente.Name = "btn_volver_cliente"
        Me.btn_volver_cliente.Size = New System.Drawing.Size(101, 23)
        Me.btn_volver_cliente.TabIndex = 9
        Me.btn_volver_cliente.Text = "Volver"
        Me.btn_volver_cliente.UseVisualStyleBackColor = True
        '
        'btn_eliminar_cliente
        '
        Me.btn_eliminar_cliente.Location = New System.Drawing.Point(560, 494)
        Me.btn_eliminar_cliente.Name = "btn_eliminar_cliente"
        Me.btn_eliminar_cliente.Size = New System.Drawing.Size(95, 23)
        Me.btn_eliminar_cliente.TabIndex = 8
        Me.btn_eliminar_cliente.Text = "Eliminar"
        Me.btn_eliminar_cliente.UseVisualStyleBackColor = True
        '
        'btn_nuevo_cliente
        '
        Me.btn_nuevo_cliente.Location = New System.Drawing.Point(661, 459)
        Me.btn_nuevo_cliente.Name = "btn_nuevo_cliente"
        Me.btn_nuevo_cliente.Size = New System.Drawing.Size(101, 23)
        Me.btn_nuevo_cliente.TabIndex = 7
        Me.btn_nuevo_cliente.Text = "Nuevo Cliente"
        Me.btn_nuevo_cliente.UseVisualStyleBackColor = True
        '
        'btn_abrir_ficha
        '
        Me.btn_abrir_ficha.Location = New System.Drawing.Point(458, 494)
        Me.btn_abrir_ficha.Name = "btn_abrir_ficha"
        Me.btn_abrir_ficha.Size = New System.Drawing.Size(96, 23)
        Me.btn_abrir_ficha.TabIndex = 6
        Me.btn_abrir_ficha.Text = "Abrir Ficha"
        Me.btn_abrir_ficha.UseVisualStyleBackColor = True
        '
        'cmb_buscar
        '
        Me.cmb_buscar.FormattingEnabled = True
        Me.cmb_buscar.Items.AddRange(New Object() {"Nombre", "Direccion", "Celular", "Localidad", "Provincia", "eMail"})
        Me.cmb_buscar.Location = New System.Drawing.Point(92, 494)
        Me.cmb_buscar.Name = "cmb_buscar"
        Me.cmb_buscar.Size = New System.Drawing.Size(121, 21)
        Me.cmb_buscar.TabIndex = 5
        '
        'txtbox_buscar
        '
        Me.txtbox_buscar.Location = New System.Drawing.Point(92, 470)
        Me.txtbox_buscar.Name = "txtbox_buscar"
        Me.txtbox_buscar.Size = New System.Drawing.Size(121, 20)
        Me.txtbox_buscar.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 497)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "BUSCAR POR:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 473)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BUSCAR:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_pacientes)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 281)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(756, 172)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pacientes"
        '
        'dgv_pacientes
        '
        Me.dgv_pacientes.AllowUserToAddRows = False
        Me.dgv_pacientes.AllowUserToDeleteRows = False
        Me.dgv_pacientes.AllowUserToOrderColumns = True
        Me.dgv_pacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pacientes.Location = New System.Drawing.Point(6, 19)
        Me.dgv_pacientes.Name = "dgv_pacientes"
        Me.dgv_pacientes.ReadOnly = True
        Me.dgv_pacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_pacientes.Size = New System.Drawing.Size(744, 147)
        Me.dgv_pacientes.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_clientes)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(756, 269)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clientes"
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AllowUserToAddRows = False
        Me.dgv_clientes.AllowUserToDeleteRows = False
        Me.dgv_clientes.AllowUserToOrderColumns = True
        Me.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Location = New System.Drawing.Point(6, 19)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        Me.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_clientes.Size = New System.Drawing.Size(744, 244)
        Me.dgv_clientes.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_vac_atp)
        Me.TabPage2.Controls.Add(Me.cmb_busq_paciente)
        Me.TabPage2.Controls.Add(Me.txt_box_busq_paciente)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.btn_abrir_ficha_paciente)
        Me.TabPage2.Controls.Add(Me.btn_eliminar_paciente)
        Me.TabPage2.Controls.Add(Me.btn_cerrar_2)
        Me.TabPage2.Controls.Add(Me.dgv_pacientes_pacientes)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(768, 538)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PACIENTES"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_vac_atp
        '
        Me.btn_vac_atp.Location = New System.Drawing.Point(595, 423)
        Me.btn_vac_atp.Name = "btn_vac_atp"
        Me.btn_vac_atp.Size = New System.Drawing.Size(167, 23)
        Me.btn_vac_atp.TabIndex = 8
        Me.btn_vac_atp.Text = "Vacunación y Desparasitación"
        Me.btn_vac_atp.UseVisualStyleBackColor = True
        '
        'cmb_busq_paciente
        '
        Me.cmb_busq_paciente.FormattingEnabled = True
        Me.cmb_busq_paciente.Items.AddRange(New Object() {"Nombre", "Especie", "Raza", "Sexo", "Fecha Nac.", "Microchip"})
        Me.cmb_busq_paciente.Location = New System.Drawing.Point(101, 509)
        Me.cmb_busq_paciente.Name = "cmb_busq_paciente"
        Me.cmb_busq_paciente.Size = New System.Drawing.Size(121, 21)
        Me.cmb_busq_paciente.TabIndex = 7
        '
        'txt_box_busq_paciente
        '
        Me.txt_box_busq_paciente.Location = New System.Drawing.Point(75, 483)
        Me.txt_box_busq_paciente.Name = "txt_box_busq_paciente"
        Me.txt_box_busq_paciente.Size = New System.Drawing.Size(147, 20)
        Me.txt_box_busq_paciente.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 514)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "BUSCAR POR: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 486)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "BUSCAR: "
        '
        'btn_abrir_ficha_paciente
        '
        Me.btn_abrir_ficha_paciente.Location = New System.Drawing.Point(525, 509)
        Me.btn_abrir_ficha_paciente.Name = "btn_abrir_ficha_paciente"
        Me.btn_abrir_ficha_paciente.Size = New System.Drawing.Size(75, 23)
        Me.btn_abrir_ficha_paciente.TabIndex = 3
        Me.btn_abrir_ficha_paciente.Text = "Abrir ficha"
        Me.btn_abrir_ficha_paciente.UseVisualStyleBackColor = True
        '
        'btn_eliminar_paciente
        '
        Me.btn_eliminar_paciente.Location = New System.Drawing.Point(606, 509)
        Me.btn_eliminar_paciente.Name = "btn_eliminar_paciente"
        Me.btn_eliminar_paciente.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar_paciente.TabIndex = 2
        Me.btn_eliminar_paciente.Text = "Eliminar"
        Me.btn_eliminar_paciente.UseVisualStyleBackColor = True
        '
        'btn_cerrar_2
        '
        Me.btn_cerrar_2.Location = New System.Drawing.Point(687, 509)
        Me.btn_cerrar_2.Name = "btn_cerrar_2"
        Me.btn_cerrar_2.Size = New System.Drawing.Size(75, 23)
        Me.btn_cerrar_2.TabIndex = 1
        Me.btn_cerrar_2.Text = "Cerrar"
        Me.btn_cerrar_2.UseVisualStyleBackColor = True
        '
        'dgv_pacientes_pacientes
        '
        Me.dgv_pacientes_pacientes.AllowUserToAddRows = False
        Me.dgv_pacientes_pacientes.AllowUserToDeleteRows = False
        Me.dgv_pacientes_pacientes.AllowUserToOrderColumns = True
        Me.dgv_pacientes_pacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_pacientes_pacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_pacientes_pacientes.Location = New System.Drawing.Point(6, 6)
        Me.dgv_pacientes_pacientes.Name = "dgv_pacientes_pacientes"
        Me.dgv_pacientes_pacientes.ReadOnly = True
        Me.dgv_pacientes_pacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_pacientes_pacientes.Size = New System.Drawing.Size(756, 411)
        Me.dgv_pacientes_pacientes.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btn_historial_guard)
        Me.TabPage3.Controls.Add(Me.btn_borrar_guard)
        Me.TabPage3.Controls.Add(Me.btn_detalle_guard)
        Me.TabPage3.Controls.Add(Me.btn_salida_guard)
        Me.TabPage3.Controls.Add(Me.btn_ingreso_guard)
        Me.TabPage3.Controls.Add(Me.dgv_guarderia)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(768, 538)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "GUARDERIA"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btn_historial_guard
        '
        Me.btn_historial_guard.Location = New System.Drawing.Point(628, 452)
        Me.btn_historial_guard.Name = "btn_historial_guard"
        Me.btn_historial_guard.Size = New System.Drawing.Size(137, 23)
        Me.btn_historial_guard.TabIndex = 5
        Me.btn_historial_guard.Text = "Historial"
        Me.btn_historial_guard.UseVisualStyleBackColor = True
        '
        'btn_borrar_guard
        '
        Me.btn_borrar_guard.Location = New System.Drawing.Point(314, 473)
        Me.btn_borrar_guard.Name = "btn_borrar_guard"
        Me.btn_borrar_guard.Size = New System.Drawing.Size(94, 37)
        Me.btn_borrar_guard.TabIndex = 4
        Me.btn_borrar_guard.Text = "Borrar de Guarderia"
        Me.btn_borrar_guard.UseVisualStyleBackColor = True
        '
        'btn_detalle_guard
        '
        Me.btn_detalle_guard.Location = New System.Drawing.Point(214, 473)
        Me.btn_detalle_guard.Name = "btn_detalle_guard"
        Me.btn_detalle_guard.Size = New System.Drawing.Size(94, 37)
        Me.btn_detalle_guard.TabIndex = 3
        Me.btn_detalle_guard.Text = "Detalle de Guarderia"
        Me.btn_detalle_guard.UseVisualStyleBackColor = True
        '
        'btn_salida_guard
        '
        Me.btn_salida_guard.Location = New System.Drawing.Point(114, 473)
        Me.btn_salida_guard.Name = "btn_salida_guard"
        Me.btn_salida_guard.Size = New System.Drawing.Size(94, 37)
        Me.btn_salida_guard.TabIndex = 2
        Me.btn_salida_guard.Text = "Salida de Guarderia"
        Me.btn_salida_guard.UseVisualStyleBackColor = True
        '
        'btn_ingreso_guard
        '
        Me.btn_ingreso_guard.Location = New System.Drawing.Point(14, 473)
        Me.btn_ingreso_guard.Name = "btn_ingreso_guard"
        Me.btn_ingreso_guard.Size = New System.Drawing.Size(94, 37)
        Me.btn_ingreso_guard.TabIndex = 1
        Me.btn_ingreso_guard.Text = "Ingresar en Guarderia"
        Me.btn_ingreso_guard.UseVisualStyleBackColor = True
        '
        'dgv_guarderia
        '
        Me.dgv_guarderia.AllowUserToAddRows = False
        Me.dgv_guarderia.AllowUserToDeleteRows = False
        Me.dgv_guarderia.AllowUserToOrderColumns = True
        Me.dgv_guarderia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_guarderia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_guarderia.Location = New System.Drawing.Point(3, 3)
        Me.dgv_guarderia.Name = "dgv_guarderia"
        Me.dgv_guarderia.ReadOnly = True
        Me.dgv_guarderia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_guarderia.Size = New System.Drawing.Size(762, 443)
        Me.dgv_guarderia.TabIndex = 0
        '
        'Menu_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 588)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Menu_Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgv_pacientes_pacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgv_guarderia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_nuevo_cliente As Button
    Friend WithEvents btn_abrir_ficha As Button
    Friend WithEvents cmb_buscar As ComboBox
    Friend WithEvents txtbox_buscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgv_pacientes As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_clientes As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btn_volver_cliente As Button
    Friend WithEvents btn_eliminar_cliente As Button
    Friend WithEvents cmb_busq_paciente As ComboBox
    Friend WithEvents txt_box_busq_paciente As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_abrir_ficha_paciente As Button
    Friend WithEvents btn_eliminar_paciente As Button
    Friend WithEvents btn_cerrar_2 As Button
    Friend WithEvents dgv_pacientes_pacientes As DataGridView
    Friend WithEvents dgv_guarderia As DataGridView
    Friend WithEvents btn_historial_guard As Button
    Friend WithEvents btn_borrar_guard As Button
    Friend WithEvents btn_detalle_guard As Button
    Friend WithEvents btn_salida_guard As Button
    Friend WithEvents btn_ingreso_guard As Button
    Friend WithEvents btn_vac_atp As Button
End Class
