<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_ATP
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
        Me.btn_aceptar_alta_atp = New System.Windows.Forms.Button()
        Me.btn_volver_alta_atp = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbox_nombre_atp = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_aceptar_alta_atp
        '
        Me.btn_aceptar_alta_atp.Location = New System.Drawing.Point(154, 66)
        Me.btn_aceptar_alta_atp.Name = "btn_aceptar_alta_atp"
        Me.btn_aceptar_alta_atp.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar_alta_atp.TabIndex = 7
        Me.btn_aceptar_alta_atp.Text = "Aceptar"
        Me.btn_aceptar_alta_atp.UseVisualStyleBackColor = True
        '
        'btn_volver_alta_atp
        '
        Me.btn_volver_alta_atp.Location = New System.Drawing.Point(235, 66)
        Me.btn_volver_alta_atp.Name = "btn_volver_alta_atp"
        Me.btn_volver_alta_atp.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver_alta_atp.TabIndex = 6
        Me.btn_volver_alta_atp.Text = "Volver"
        Me.btn_volver_alta_atp.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbox_nombre_atp)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 48)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nombre del Antiparasitario"
        '
        'txtbox_nombre_atp
        '
        Me.txtbox_nombre_atp.Location = New System.Drawing.Point(6, 19)
        Me.txtbox_nombre_atp.Name = "txtbox_nombre_atp"
        Me.txtbox_nombre_atp.Size = New System.Drawing.Size(286, 20)
        Me.txtbox_nombre_atp.TabIndex = 0
        '
        'Alta_ATP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 103)
        Me.Controls.Add(Me.btn_aceptar_alta_atp)
        Me.Controls.Add(Me.btn_volver_alta_atp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Alta_ATP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta ATP"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_aceptar_alta_atp As Button
    Friend WithEvents btn_volver_alta_atp As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbox_nombre_atp As TextBox
End Class
