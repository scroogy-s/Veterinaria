<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_Veterinario
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
        Me.txt_box_nombre_vet = New System.Windows.Forms.TextBox()
        Me.txt_box_matricula_vet = New System.Windows.Forms.TextBox()
        Me.btn_agregar_veterinario = New System.Windows.Forms.Button()
        Me.btn_volver_veterinario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VETERINARIO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "N°MAT. / CEDULA:"
        '
        'txt_box_nombre_vet
        '
        Me.txt_box_nombre_vet.Location = New System.Drawing.Point(15, 37)
        Me.txt_box_nombre_vet.Name = "txt_box_nombre_vet"
        Me.txt_box_nombre_vet.Size = New System.Drawing.Size(269, 20)
        Me.txt_box_nombre_vet.TabIndex = 2
        '
        'txt_box_matricula_vet
        '
        Me.txt_box_matricula_vet.Location = New System.Drawing.Point(15, 84)
        Me.txt_box_matricula_vet.Name = "txt_box_matricula_vet"
        Me.txt_box_matricula_vet.Size = New System.Drawing.Size(269, 20)
        Me.txt_box_matricula_vet.TabIndex = 3
        '
        'btn_agregar_veterinario
        '
        Me.btn_agregar_veterinario.Location = New System.Drawing.Point(128, 119)
        Me.btn_agregar_veterinario.Name = "btn_agregar_veterinario"
        Me.btn_agregar_veterinario.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar_veterinario.TabIndex = 4
        Me.btn_agregar_veterinario.Text = "Aceptar"
        Me.btn_agregar_veterinario.UseVisualStyleBackColor = True
        '
        'btn_volver_veterinario
        '
        Me.btn_volver_veterinario.Location = New System.Drawing.Point(209, 119)
        Me.btn_volver_veterinario.Name = "btn_volver_veterinario"
        Me.btn_volver_veterinario.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver_veterinario.TabIndex = 5
        Me.btn_volver_veterinario.Text = "Volver"
        Me.btn_volver_veterinario.UseVisualStyleBackColor = True
        '
        'Alta_Veterinario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 166)
        Me.Controls.Add(Me.btn_volver_veterinario)
        Me.Controls.Add(Me.btn_agregar_veterinario)
        Me.Controls.Add(Me.txt_box_matricula_vet)
        Me.Controls.Add(Me.txt_box_nombre_vet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Alta_Veterinario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Veterinario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_box_nombre_vet As TextBox
    Friend WithEvents txt_box_matricula_vet As TextBox
    Friend WithEvents btn_agregar_veterinario As Button
    Friend WithEvents btn_volver_veterinario As Button
End Class
