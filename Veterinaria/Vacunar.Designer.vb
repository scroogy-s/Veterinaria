<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vacunar
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
        Me.cmb_vacuna = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_marca_serie = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_fecha_vacunacion = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_dias_vacunacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_fecha_revacuna = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_prox_vacuna = New System.Windows.Forms.ComboBox()
        Me.btn_vacunar_aceptar = New System.Windows.Forms.Button()
        Me.btn_vacunar_cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vacuna:"
        '
        'cmb_vacuna
        '
        Me.cmb_vacuna.FormattingEnabled = True
        Me.cmb_vacuna.Location = New System.Drawing.Point(141, 12)
        Me.cmb_vacuna.Name = "cmb_vacuna"
        Me.cmb_vacuna.Size = New System.Drawing.Size(181, 21)
        Me.cmb_vacuna.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Marca y Nro. de Serie:"
        '
        'txt_marca_serie
        '
        Me.txt_marca_serie.Location = New System.Drawing.Point(141, 39)
        Me.txt_marca_serie.Name = "txt_marca_serie"
        Me.txt_marca_serie.Size = New System.Drawing.Size(121, 20)
        Me.txt_marca_serie.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha de Vacunación:"
        '
        'dtp_fecha_vacunacion
        '
        Me.dtp_fecha_vacunacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_vacunacion.Location = New System.Drawing.Point(141, 65)
        Me.dtp_fecha_vacunacion.Name = "dtp_fecha_vacunacion"
        Me.dtp_fecha_vacunacion.Size = New System.Drawing.Size(121, 20)
        Me.dtp_fecha_vacunacion.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Vacunar a los "
        '
        'txt_dias_vacunacion
        '
        Me.txt_dias_vacunacion.Location = New System.Drawing.Point(141, 91)
        Me.txt_dias_vacunacion.Name = "txt_dias_vacunacion"
        Me.txt_dias_vacunacion.Size = New System.Drawing.Size(51, 20)
        Me.txt_dias_vacunacion.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(198, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "dias."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Fecha de revacunación:"
        '
        'dtp_fecha_revacuna
        '
        Me.dtp_fecha_revacuna.Enabled = False
        Me.dtp_fecha_revacuna.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_revacuna.Location = New System.Drawing.Point(141, 117)
        Me.dtp_fecha_revacuna.Name = "dtp_fecha_revacuna"
        Me.dtp_fecha_revacuna.Size = New System.Drawing.Size(121, 20)
        Me.dtp_fecha_revacuna.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Proxima Vacuna:"
        '
        'cmb_prox_vacuna
        '
        Me.cmb_prox_vacuna.FormattingEnabled = True
        Me.cmb_prox_vacuna.Location = New System.Drawing.Point(141, 143)
        Me.cmb_prox_vacuna.Name = "cmb_prox_vacuna"
        Me.cmb_prox_vacuna.Size = New System.Drawing.Size(181, 21)
        Me.cmb_prox_vacuna.TabIndex = 12
        '
        'btn_vacunar_aceptar
        '
        Me.btn_vacunar_aceptar.Location = New System.Drawing.Point(166, 190)
        Me.btn_vacunar_aceptar.Name = "btn_vacunar_aceptar"
        Me.btn_vacunar_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_vacunar_aceptar.TabIndex = 13
        Me.btn_vacunar_aceptar.Text = "Aceptar"
        Me.btn_vacunar_aceptar.UseVisualStyleBackColor = True
        '
        'btn_vacunar_cancelar
        '
        Me.btn_vacunar_cancelar.Location = New System.Drawing.Point(247, 190)
        Me.btn_vacunar_cancelar.Name = "btn_vacunar_cancelar"
        Me.btn_vacunar_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_vacunar_cancelar.TabIndex = 14
        Me.btn_vacunar_cancelar.Text = "Cancelar"
        Me.btn_vacunar_cancelar.UseVisualStyleBackColor = True
        '
        'Vacunar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 230)
        Me.Controls.Add(Me.btn_vacunar_cancelar)
        Me.Controls.Add(Me.btn_vacunar_aceptar)
        Me.Controls.Add(Me.cmb_prox_vacuna)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtp_fecha_revacuna)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_dias_vacunacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp_fecha_vacunacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_marca_serie)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_vacuna)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Vacunar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vacunar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_vacuna As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_marca_serie As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_fecha_vacunacion As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_dias_vacunacion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtp_fecha_revacuna As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_prox_vacuna As ComboBox
    Friend WithEvents btn_vacunar_aceptar As Button
    Friend WithEvents btn_vacunar_cancelar As Button
End Class
