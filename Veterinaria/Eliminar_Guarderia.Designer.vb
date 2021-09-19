<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eliminar_Guarderia
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_idguard_elim = New System.Windows.Forms.TextBox()
        Me.txt_cliente_elim = New System.Windows.Forms.TextBox()
        Me.txt_paciente_elim = New System.Windows.Forms.TextBox()
        Me.dtp_ingreso_elim = New System.Windows.Forms.DateTimePicker()
        Me.btn_eliminar_guard = New System.Windows.Forms.Button()
        Me.btn_volver_eliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USTED VA A ELIMINAR EL SIGUIENTE REGISTRO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha de Ingreso:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Paciente:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Registro:"
        '
        'txt_idguard_elim
        '
        Me.txt_idguard_elim.Enabled = False
        Me.txt_idguard_elim.Location = New System.Drawing.Point(111, 39)
        Me.txt_idguard_elim.Name = "txt_idguard_elim"
        Me.txt_idguard_elim.Size = New System.Drawing.Size(113, 20)
        Me.txt_idguard_elim.TabIndex = 5
        '
        'txt_cliente_elim
        '
        Me.txt_cliente_elim.Enabled = False
        Me.txt_cliente_elim.Location = New System.Drawing.Point(111, 91)
        Me.txt_cliente_elim.Name = "txt_cliente_elim"
        Me.txt_cliente_elim.Size = New System.Drawing.Size(188, 20)
        Me.txt_cliente_elim.TabIndex = 7
        '
        'txt_paciente_elim
        '
        Me.txt_paciente_elim.Enabled = False
        Me.txt_paciente_elim.Location = New System.Drawing.Point(111, 117)
        Me.txt_paciente_elim.Name = "txt_paciente_elim"
        Me.txt_paciente_elim.Size = New System.Drawing.Size(188, 20)
        Me.txt_paciente_elim.TabIndex = 8
        '
        'dtp_ingreso_elim
        '
        Me.dtp_ingreso_elim.Enabled = False
        Me.dtp_ingreso_elim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ingreso_elim.Location = New System.Drawing.Point(111, 65)
        Me.dtp_ingreso_elim.Name = "dtp_ingreso_elim"
        Me.dtp_ingreso_elim.Size = New System.Drawing.Size(113, 20)
        Me.dtp_ingreso_elim.TabIndex = 9
        '
        'btn_eliminar_guard
        '
        Me.btn_eliminar_guard.Location = New System.Drawing.Point(64, 157)
        Me.btn_eliminar_guard.Name = "btn_eliminar_guard"
        Me.btn_eliminar_guard.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar_guard.TabIndex = 10
        Me.btn_eliminar_guard.Text = "Borrar"
        Me.btn_eliminar_guard.UseVisualStyleBackColor = True
        '
        'btn_volver_eliminar
        '
        Me.btn_volver_eliminar.Location = New System.Drawing.Point(195, 157)
        Me.btn_volver_eliminar.Name = "btn_volver_eliminar"
        Me.btn_volver_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver_eliminar.TabIndex = 11
        Me.btn_volver_eliminar.Text = "Cancelar"
        Me.btn_volver_eliminar.UseVisualStyleBackColor = True
        '
        'Eliminar_Guarderia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 203)
        Me.Controls.Add(Me.btn_volver_eliminar)
        Me.Controls.Add(Me.btn_eliminar_guard)
        Me.Controls.Add(Me.dtp_ingreso_elim)
        Me.Controls.Add(Me.txt_paciente_elim)
        Me.Controls.Add(Me.txt_cliente_elim)
        Me.Controls.Add(Me.txt_idguard_elim)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Eliminar_Guarderia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar de la Guarderia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_idguard_elim As TextBox
    Friend WithEvents txt_cliente_elim As TextBox
    Friend WithEvents txt_paciente_elim As TextBox
    Friend WithEvents dtp_ingreso_elim As DateTimePicker
    Friend WithEvents btn_eliminar_guard As Button
    Friend WithEvents btn_volver_eliminar As Button
End Class
