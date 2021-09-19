<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vacunas
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
        Me.dgv_vacunas = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.textbox_descripcion_vacuna = New System.Windows.Forms.TextBox()
        Me.btn_alta_vacuna = New System.Windows.Forms.Button()
        Me.btn_baja_vacuna = New System.Windows.Forms.Button()
        Me.btn_volver_vacuna = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_vacunas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_vacunas)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 275)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipos de Vacunas"
        '
        'dgv_vacunas
        '
        Me.dgv_vacunas.AllowUserToAddRows = False
        Me.dgv_vacunas.AllowUserToDeleteRows = False
        Me.dgv_vacunas.AllowUserToOrderColumns = True
        Me.dgv_vacunas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_vacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vacunas.Location = New System.Drawing.Point(6, 19)
        Me.dgv_vacunas.Name = "dgv_vacunas"
        Me.dgv_vacunas.ReadOnly = True
        Me.dgv_vacunas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_vacunas.Size = New System.Drawing.Size(377, 250)
        Me.dgv_vacunas.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.textbox_descripcion_vacuna)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 293)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(389, 82)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la Vacuna"
        '
        'textbox_descripcion_vacuna
        '
        Me.textbox_descripcion_vacuna.HideSelection = False
        Me.textbox_descripcion_vacuna.Location = New System.Drawing.Point(6, 19)
        Me.textbox_descripcion_vacuna.Multiline = True
        Me.textbox_descripcion_vacuna.Name = "textbox_descripcion_vacuna"
        Me.textbox_descripcion_vacuna.ReadOnly = True
        Me.textbox_descripcion_vacuna.Size = New System.Drawing.Size(377, 57)
        Me.textbox_descripcion_vacuna.TabIndex = 0
        '
        'btn_alta_vacuna
        '
        Me.btn_alta_vacuna.Location = New System.Drawing.Point(12, 381)
        Me.btn_alta_vacuna.Name = "btn_alta_vacuna"
        Me.btn_alta_vacuna.Size = New System.Drawing.Size(75, 23)
        Me.btn_alta_vacuna.TabIndex = 2
        Me.btn_alta_vacuna.Text = "Alta"
        Me.btn_alta_vacuna.UseVisualStyleBackColor = True
        '
        'btn_baja_vacuna
        '
        Me.btn_baja_vacuna.Location = New System.Drawing.Point(93, 381)
        Me.btn_baja_vacuna.Name = "btn_baja_vacuna"
        Me.btn_baja_vacuna.Size = New System.Drawing.Size(75, 23)
        Me.btn_baja_vacuna.TabIndex = 3
        Me.btn_baja_vacuna.Text = "Baja"
        Me.btn_baja_vacuna.UseVisualStyleBackColor = True
        '
        'btn_volver_vacuna
        '
        Me.btn_volver_vacuna.Location = New System.Drawing.Point(326, 381)
        Me.btn_volver_vacuna.Name = "btn_volver_vacuna"
        Me.btn_volver_vacuna.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver_vacuna.TabIndex = 4
        Me.btn_volver_vacuna.Text = "Volver"
        Me.btn_volver_vacuna.UseVisualStyleBackColor = True
        '
        'Vacunas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 421)
        Me.Controls.Add(Me.btn_volver_vacuna)
        Me.Controls.Add(Me.btn_baja_vacuna)
        Me.Controls.Add(Me.btn_alta_vacuna)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Vacunas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vacunas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_vacunas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_vacunas As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents textbox_descripcion_vacuna As TextBox
    Friend WithEvents btn_alta_vacuna As Button
    Friend WithEvents btn_baja_vacuna As Button
    Friend WithEvents btn_volver_vacuna As Button
End Class
