<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administracion
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
        Me.btn_vacunas = New System.Windows.Forms.Button()
        Me.btn_antiparasitario = New System.Windows.Forms.Button()
        Me.btn_animales = New System.Windows.Forms.Button()
        Me.btn_admin_volver = New System.Windows.Forms.Button()
        Me.btn_veter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_vacunas
        '
        Me.btn_vacunas.Location = New System.Drawing.Point(76, 12)
        Me.btn_vacunas.Name = "btn_vacunas"
        Me.btn_vacunas.Size = New System.Drawing.Size(75, 23)
        Me.btn_vacunas.TabIndex = 0
        Me.btn_vacunas.Text = "Vacunas"
        Me.btn_vacunas.UseVisualStyleBackColor = True
        '
        'btn_antiparasitario
        '
        Me.btn_antiparasitario.Location = New System.Drawing.Point(76, 41)
        Me.btn_antiparasitario.Name = "btn_antiparasitario"
        Me.btn_antiparasitario.Size = New System.Drawing.Size(75, 23)
        Me.btn_antiparasitario.TabIndex = 1
        Me.btn_antiparasitario.Text = "ATP"
        Me.btn_antiparasitario.UseVisualStyleBackColor = True
        '
        'btn_animales
        '
        Me.btn_animales.Location = New System.Drawing.Point(76, 70)
        Me.btn_animales.Name = "btn_animales"
        Me.btn_animales.Size = New System.Drawing.Size(75, 23)
        Me.btn_animales.TabIndex = 2
        Me.btn_animales.Text = "Animales"
        Me.btn_animales.UseVisualStyleBackColor = True
        '
        'btn_admin_volver
        '
        Me.btn_admin_volver.Location = New System.Drawing.Point(60, 162)
        Me.btn_admin_volver.Name = "btn_admin_volver"
        Me.btn_admin_volver.Size = New System.Drawing.Size(104, 23)
        Me.btn_admin_volver.TabIndex = 3
        Me.btn_admin_volver.Text = "Volver"
        Me.btn_admin_volver.UseVisualStyleBackColor = True
        '
        'btn_veter
        '
        Me.btn_veter.Location = New System.Drawing.Point(76, 99)
        Me.btn_veter.Name = "btn_veter"
        Me.btn_veter.Size = New System.Drawing.Size(75, 23)
        Me.btn_veter.TabIndex = 4
        Me.btn_veter.Text = "Veterinarios"
        Me.btn_veter.UseVisualStyleBackColor = True
        '
        'Administracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 197)
        Me.Controls.Add(Me.btn_veter)
        Me.Controls.Add(Me.btn_admin_volver)
        Me.Controls.Add(Me.btn_animales)
        Me.Controls.Add(Me.btn_antiparasitario)
        Me.Controls.Add(Me.btn_vacunas)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Administracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administracion"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_vacunas As Button
    Friend WithEvents btn_antiparasitario As Button
    Friend WithEvents btn_animales As Button
    Friend WithEvents btn_admin_volver As Button
    Friend WithEvents btn_veter As Button
End Class
