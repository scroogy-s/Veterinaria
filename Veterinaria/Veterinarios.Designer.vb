<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Veterinarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.btn_alta_vet = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_veterinarios = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_veterinarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_volver
        '
        Me.btn_volver.Location = New System.Drawing.Point(326, 293)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver.TabIndex = 13
        Me.btn_volver.Text = "Volver"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'btn_alta_vet
        '
        Me.btn_alta_vet.Location = New System.Drawing.Point(12, 293)
        Me.btn_alta_vet.Name = "btn_alta_vet"
        Me.btn_alta_vet.Size = New System.Drawing.Size(75, 23)
        Me.btn_alta_vet.TabIndex = 11
        Me.btn_alta_vet.Text = "Alta"
        Me.btn_alta_vet.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_veterinarios)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 275)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Veterinarios"
        '
        'dgv_veterinarios
        '
        Me.dgv_veterinarios.AllowUserToAddRows = False
        Me.dgv_veterinarios.AllowUserToDeleteRows = False
        Me.dgv_veterinarios.AllowUserToOrderColumns = True
        Me.dgv_veterinarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_veterinarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_veterinarios.Location = New System.Drawing.Point(6, 19)
        Me.dgv_veterinarios.Name = "dgv_veterinarios"
        Me.dgv_veterinarios.ReadOnly = True
        Me.dgv_veterinarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_veterinarios.Size = New System.Drawing.Size(377, 250)
        Me.dgv_veterinarios.TabIndex = 0
        '
        'Veterinarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 338)
        Me.Controls.Add(Me.btn_volver)
        Me.Controls.Add(Me.btn_alta_vet)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Veterinarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Veterinarios"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_veterinarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_volver As Button
    Friend WithEvents btn_alta_vet As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_veterinarios As DataGridView
End Class
