<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alta_Animales
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
        Me.txt_alta_nombre_raza = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbox_alta_raza = New System.Windows.Forms.ComboBox()
        Me.btn_alta_raza = New System.Windows.Forms.Button()
        Me.btn_volver_raza = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_alta_nombre_raza)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 53)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Raza"
        '
        'txt_alta_nombre_raza
        '
        Me.txt_alta_nombre_raza.Location = New System.Drawing.Point(6, 19)
        Me.txt_alta_nombre_raza.Name = "txt_alta_nombre_raza"
        Me.txt_alta_nombre_raza.Size = New System.Drawing.Size(285, 20)
        Me.txt_alta_nombre_raza.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbox_alta_raza)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 58)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Especie"
        '
        'cmbox_alta_raza
        '
        Me.cmbox_alta_raza.FormattingEnabled = True
        Me.cmbox_alta_raza.Location = New System.Drawing.Point(6, 19)
        Me.cmbox_alta_raza.Name = "cmbox_alta_raza"
        Me.cmbox_alta_raza.Size = New System.Drawing.Size(285, 21)
        Me.cmbox_alta_raza.TabIndex = 0
        '
        'btn_alta_raza
        '
        Me.btn_alta_raza.Location = New System.Drawing.Point(153, 135)
        Me.btn_alta_raza.Name = "btn_alta_raza"
        Me.btn_alta_raza.Size = New System.Drawing.Size(75, 23)
        Me.btn_alta_raza.TabIndex = 2
        Me.btn_alta_raza.Text = "Agregar"
        Me.btn_alta_raza.UseVisualStyleBackColor = True
        '
        'btn_volver_raza
        '
        Me.btn_volver_raza.Location = New System.Drawing.Point(234, 135)
        Me.btn_volver_raza.Name = "btn_volver_raza"
        Me.btn_volver_raza.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver_raza.TabIndex = 3
        Me.btn_volver_raza.Text = "Volver"
        Me.btn_volver_raza.UseVisualStyleBackColor = True
        '
        'Alta_Animales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 171)
        Me.Controls.Add(Me.btn_volver_raza)
        Me.Controls.Add(Me.btn_alta_raza)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Alta_Animales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Animales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_alta_nombre_raza As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbox_alta_raza As ComboBox
    Friend WithEvents btn_alta_raza As Button
    Friend WithEvents btn_volver_raza As Button
End Class
