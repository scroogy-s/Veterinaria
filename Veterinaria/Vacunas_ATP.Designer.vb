<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vacunas_ATP
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
        Me.txt_nombre_paciente = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_vacunas_atp = New System.Windows.Forms.DataGridView()
        Me.btn_vacunar = New System.Windows.Forms.Button()
        Me.btn_desparasitar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox_atp = New System.Windows.Forms.CheckBox()
        Me.CheckBox_vacuna = New System.Windows.Forms.CheckBox()
        Me.btn_volver_vac_atp = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_vacunas_atp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Paciente:"
        '
        'txt_nombre_paciente
        '
        Me.txt_nombre_paciente.Location = New System.Drawing.Point(70, 6)
        Me.txt_nombre_paciente.Name = "txt_nombre_paciente"
        Me.txt_nombre_paciente.Size = New System.Drawing.Size(190, 20)
        Me.txt_nombre_paciente.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_vacunas_atp)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 406)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Vacunas y ATPs aplicados"
        '
        'dgv_vacunas_atp
        '
        Me.dgv_vacunas_atp.AllowUserToAddRows = False
        Me.dgv_vacunas_atp.AllowUserToDeleteRows = False
        Me.dgv_vacunas_atp.AllowUserToOrderColumns = True
        Me.dgv_vacunas_atp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_vacunas_atp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_vacunas_atp.Location = New System.Drawing.Point(6, 19)
        Me.dgv_vacunas_atp.Name = "dgv_vacunas_atp"
        Me.dgv_vacunas_atp.ReadOnly = True
        Me.dgv_vacunas_atp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_vacunas_atp.Size = New System.Drawing.Size(579, 381)
        Me.dgv_vacunas_atp.TabIndex = 0
        '
        'btn_vacunar
        '
        Me.btn_vacunar.Location = New System.Drawing.Point(609, 32)
        Me.btn_vacunar.Name = "btn_vacunar"
        Me.btn_vacunar.Size = New System.Drawing.Size(111, 23)
        Me.btn_vacunar.TabIndex = 5
        Me.btn_vacunar.Text = "Vacunar"
        Me.btn_vacunar.UseVisualStyleBackColor = True
        '
        'btn_desparasitar
        '
        Me.btn_desparasitar.Location = New System.Drawing.Point(609, 61)
        Me.btn_desparasitar.Name = "btn_desparasitar"
        Me.btn_desparasitar.Size = New System.Drawing.Size(111, 23)
        Me.btn_desparasitar.TabIndex = 6
        Me.btn_desparasitar.Text = "Desparasitar"
        Me.btn_desparasitar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox_atp)
        Me.GroupBox2.Controls.Add(Me.CheckBox_vacuna)
        Me.GroupBox2.Location = New System.Drawing.Point(609, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(111, 70)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ocultar"
        '
        'CheckBox_atp
        '
        Me.CheckBox_atp.AutoSize = True
        Me.CheckBox_atp.Location = New System.Drawing.Point(6, 42)
        Me.CheckBox_atp.Name = "CheckBox_atp"
        Me.CheckBox_atp.Size = New System.Drawing.Size(52, 17)
        Me.CheckBox_atp.TabIndex = 1
        Me.CheckBox_atp.Text = "ATPs"
        Me.CheckBox_atp.UseVisualStyleBackColor = True
        '
        'CheckBox_vacuna
        '
        Me.CheckBox_vacuna.AutoSize = True
        Me.CheckBox_vacuna.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox_vacuna.Name = "CheckBox_vacuna"
        Me.CheckBox_vacuna.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox_vacuna.TabIndex = 0
        Me.CheckBox_vacuna.Text = "Vacunas"
        Me.CheckBox_vacuna.UseVisualStyleBackColor = True
        '
        'btn_volver_vac_atp
        '
        Me.btn_volver_vac_atp.Location = New System.Drawing.Point(628, 409)
        Me.btn_volver_vac_atp.Name = "btn_volver_vac_atp"
        Me.btn_volver_vac_atp.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver_vac_atp.TabIndex = 8
        Me.btn_volver_vac_atp.Text = "Volver"
        Me.btn_volver_vac_atp.UseVisualStyleBackColor = True
        '
        'Vacunas_ATP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 450)
        Me.Controls.Add(Me.btn_volver_vac_atp)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_desparasitar)
        Me.Controls.Add(Me.btn_vacunar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_nombre_paciente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Vacunas_ATP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vacunas y Antiparacitación"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_vacunas_atp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nombre_paciente As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_vacunas_atp As DataGridView
    Friend WithEvents btn_vacunar As Button
    Friend WithEvents btn_desparasitar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox_atp As CheckBox
    Friend WithEvents CheckBox_vacuna As CheckBox
    Friend WithEvents btn_volver_vac_atp As Button
End Class
