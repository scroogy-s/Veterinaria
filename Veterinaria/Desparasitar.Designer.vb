<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desparasitar
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
        Me.btn_desparacitar_cancelar = New System.Windows.Forms.Button()
        Me.btn_desparasitar_aceptar = New System.Windows.Forms.Button()
        Me.dtp_fecha_reatp = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_dias_atp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_fecha_atp = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_marca_serie = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_atp = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_prox_atp = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btn_desparacitar_cancelar
        '
        Me.btn_desparacitar_cancelar.Location = New System.Drawing.Point(258, 178)
        Me.btn_desparacitar_cancelar.Name = "btn_desparacitar_cancelar"
        Me.btn_desparacitar_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_desparacitar_cancelar.TabIndex = 29
        Me.btn_desparacitar_cancelar.Text = "Cancelar"
        Me.btn_desparacitar_cancelar.UseVisualStyleBackColor = True
        '
        'btn_desparasitar_aceptar
        '
        Me.btn_desparasitar_aceptar.Location = New System.Drawing.Point(177, 178)
        Me.btn_desparasitar_aceptar.Name = "btn_desparasitar_aceptar"
        Me.btn_desparasitar_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_desparasitar_aceptar.TabIndex = 28
        Me.btn_desparasitar_aceptar.Text = "Aceptar"
        Me.btn_desparasitar_aceptar.UseVisualStyleBackColor = True
        '
        'dtp_fecha_reatp
        '
        Me.dtp_fecha_reatp.Enabled = False
        Me.dtp_fecha_reatp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_reatp.Location = New System.Drawing.Point(152, 116)
        Me.dtp_fecha_reatp.Name = "dtp_fecha_reatp"
        Me.dtp_fecha_reatp.Size = New System.Drawing.Size(121, 20)
        Me.dtp_fecha_reatp.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Volver a desparasitar:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(209, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "dias."
        '
        'txt_dias_atp
        '
        Me.txt_dias_atp.Location = New System.Drawing.Point(152, 90)
        Me.txt_dias_atp.Name = "txt_dias_atp"
        Me.txt_dias_atp.Size = New System.Drawing.Size(51, 20)
        Me.txt_dias_atp.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Desparasitar a los "
        '
        'dtp_fecha_atp
        '
        Me.dtp_fecha_atp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_atp.Location = New System.Drawing.Point(152, 64)
        Me.dtp_fecha_atp.Name = "dtp_fecha_atp"
        Me.dtp_fecha_atp.Size = New System.Drawing.Size(121, 20)
        Me.dtp_fecha_atp.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Fecha de Desparasitación:"
        '
        'txt_marca_serie
        '
        Me.txt_marca_serie.Location = New System.Drawing.Point(152, 38)
        Me.txt_marca_serie.Name = "txt_marca_serie"
        Me.txt_marca_serie.Size = New System.Drawing.Size(121, 20)
        Me.txt_marca_serie.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Marca y Nro. de Serie:"
        '
        'cmb_atp
        '
        Me.cmb_atp.FormattingEnabled = True
        Me.cmb_atp.Location = New System.Drawing.Point(152, 11)
        Me.cmb_atp.Name = "cmb_atp"
        Me.cmb_atp.Size = New System.Drawing.Size(181, 21)
        Me.cmb_atp.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "ATP:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(75, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Proximo ATP:"
        '
        'cmb_prox_atp
        '
        Me.cmb_prox_atp.FormattingEnabled = True
        Me.cmb_prox_atp.Location = New System.Drawing.Point(152, 142)
        Me.cmb_prox_atp.Name = "cmb_prox_atp"
        Me.cmb_prox_atp.Size = New System.Drawing.Size(181, 21)
        Me.cmb_prox_atp.TabIndex = 31
        '
        'Desparasitar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 225)
        Me.Controls.Add(Me.cmb_prox_atp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_desparacitar_cancelar)
        Me.Controls.Add(Me.btn_desparasitar_aceptar)
        Me.Controls.Add(Me.dtp_fecha_reatp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_dias_atp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp_fecha_atp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_marca_serie)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_atp)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Desparasitar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desparasitar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_desparacitar_cancelar As Button
    Friend WithEvents btn_desparasitar_aceptar As Button
    Friend WithEvents dtp_fecha_reatp As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_dias_atp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp_fecha_atp As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_marca_serie As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_atp As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_prox_atp As ComboBox
End Class
