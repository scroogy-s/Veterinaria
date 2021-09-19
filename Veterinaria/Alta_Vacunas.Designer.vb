<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_Vacunas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbox_nombre_vacuna = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtbox_descripcion_vacuna = New System.Windows.Forms.TextBox()
        Me.btn_volver_alta_vacuna = New System.Windows.Forms.Button()
        Me.btn_aceptar_alta_vacuna = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbox_nombre_vacuna)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nombre de la Vacuna"
        '
        'txtbox_nombre_vacuna
        '
        Me.txtbox_nombre_vacuna.Location = New System.Drawing.Point(6, 19)
        Me.txtbox_nombre_vacuna.Name = "txtbox_nombre_vacuna"
        Me.txtbox_nombre_vacuna.Size = New System.Drawing.Size(286, 20)
        Me.txtbox_nombre_vacuna.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtbox_descripcion_vacuna)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 75)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos extra de la Vacuna"
        '
        'txtbox_descripcion_vacuna
        '
        Me.txtbox_descripcion_vacuna.Location = New System.Drawing.Point(6, 19)
        Me.txtbox_descripcion_vacuna.Multiline = True
        Me.txtbox_descripcion_vacuna.Name = "txtbox_descripcion_vacuna"
        Me.txtbox_descripcion_vacuna.Size = New System.Drawing.Size(286, 50)
        Me.txtbox_descripcion_vacuna.TabIndex = 0
        '
        'btn_volver_alta_vacuna
        '
        Me.btn_volver_alta_vacuna.Location = New System.Drawing.Point(235, 147)
        Me.btn_volver_alta_vacuna.Name = "btn_volver_alta_vacuna"
        Me.btn_volver_alta_vacuna.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver_alta_vacuna.TabIndex = 2
        Me.btn_volver_alta_vacuna.Text = "Volver"
        Me.btn_volver_alta_vacuna.UseVisualStyleBackColor = True
        '
        'btn_aceptar_alta_vacuna
        '
        Me.btn_aceptar_alta_vacuna.Location = New System.Drawing.Point(154, 147)
        Me.btn_aceptar_alta_vacuna.Name = "btn_aceptar_alta_vacuna"
        Me.btn_aceptar_alta_vacuna.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar_alta_vacuna.TabIndex = 3
        Me.btn_aceptar_alta_vacuna.Text = "Aceptar"
        Me.btn_aceptar_alta_vacuna.UseVisualStyleBackColor = True
        '
        'Alta_Vacunas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 183)
        Me.Controls.Add(Me.btn_aceptar_alta_vacuna)
        Me.Controls.Add(Me.btn_volver_alta_vacuna)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Alta_Vacunas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta vacunas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbox_nombre_vacuna As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtbox_descripcion_vacuna As TextBox
    Friend WithEvents btn_volver_alta_vacuna As Button
    Friend WithEvents btn_aceptar_alta_vacuna As Button
End Class
