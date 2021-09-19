<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Principal
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
        Me.btn_admin = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_admin
        '
        Me.btn_admin.Location = New System.Drawing.Point(12, 12)
        Me.btn_admin.Name = "btn_admin"
        Me.btn_admin.Size = New System.Drawing.Size(114, 23)
        Me.btn_admin.TabIndex = 0
        Me.btn_admin.Text = "Administración"
        Me.btn_admin.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Gestion Clientes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 303)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_admin)
        Me.Name = "Menu_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Veterinaria"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_admin As Button
    Friend WithEvents Button1 As Button
End Class
