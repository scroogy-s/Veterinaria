<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Animales
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
        Me.btn_volver_animal = New System.Windows.Forms.Button()
        Me.btn_baja_atp = New System.Windows.Forms.Button()
        Me.btn_alta_animal = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_animales = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_animales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_volver_animal
        '
        Me.btn_volver_animal.Location = New System.Drawing.Point(326, 293)
        Me.btn_volver_animal.Name = "btn_volver_animal"
        Me.btn_volver_animal.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver_animal.TabIndex = 13
        Me.btn_volver_animal.Text = "Volver"
        Me.btn_volver_animal.UseVisualStyleBackColor = True
        '
        'btn_baja_atp
        '
        Me.btn_baja_atp.Location = New System.Drawing.Point(93, 293)
        Me.btn_baja_atp.Name = "btn_baja_atp"
        Me.btn_baja_atp.Size = New System.Drawing.Size(75, 23)
        Me.btn_baja_atp.TabIndex = 12
        Me.btn_baja_atp.Text = "Baja"
        Me.btn_baja_atp.UseVisualStyleBackColor = True
        '
        'btn_alta_animal
        '
        Me.btn_alta_animal.Location = New System.Drawing.Point(12, 293)
        Me.btn_alta_animal.Name = "btn_alta_animal"
        Me.btn_alta_animal.Size = New System.Drawing.Size(75, 23)
        Me.btn_alta_animal.TabIndex = 11
        Me.btn_alta_animal.Text = "Alta"
        Me.btn_alta_animal.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_animales)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 275)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Razas"
        '
        'dgv_animales
        '
        Me.dgv_animales.AllowUserToAddRows = False
        Me.dgv_animales.AllowUserToDeleteRows = False
        Me.dgv_animales.AllowUserToOrderColumns = True
        Me.dgv_animales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_animales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_animales.Location = New System.Drawing.Point(6, 19)
        Me.dgv_animales.Name = "dgv_animales"
        Me.dgv_animales.ReadOnly = True
        Me.dgv_animales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_animales.Size = New System.Drawing.Size(377, 250)
        Me.dgv_animales.TabIndex = 0
        '
        'Animales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 331)
        Me.Controls.Add(Me.btn_volver_animal)
        Me.Controls.Add(Me.btn_baja_atp)
        Me.Controls.Add(Me.btn_alta_animal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Animales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Animales"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_animales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_volver_animal As Button
    Friend WithEvents btn_baja_atp As Button
    Friend WithEvents btn_alta_animal As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_animales As DataGridView
End Class
