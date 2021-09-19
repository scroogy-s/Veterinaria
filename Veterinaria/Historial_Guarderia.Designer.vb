<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial_Guarderia
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
        Me.dtp_fecha_desde = New System.Windows.Forms.DateTimePicker()
        Me.dtp_fecha_hasta = New System.Windows.Forms.DateTimePicker()
        Me.btn_ver_porfecha = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_historial_guard = New System.Windows.Forms.DataGridView()
        Me.btn_historial_volver = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_historial_guard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DESDE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "HASTA:"
        '
        'dtp_fecha_desde
        '
        Me.dtp_fecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_desde.Location = New System.Drawing.Point(62, 16)
        Me.dtp_fecha_desde.Name = "dtp_fecha_desde"
        Me.dtp_fecha_desde.Size = New System.Drawing.Size(97, 20)
        Me.dtp_fecha_desde.TabIndex = 2
        '
        'dtp_fecha_hasta
        '
        Me.dtp_fecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_hasta.Location = New System.Drawing.Point(227, 15)
        Me.dtp_fecha_hasta.Name = "dtp_fecha_hasta"
        Me.dtp_fecha_hasta.Size = New System.Drawing.Size(97, 20)
        Me.dtp_fecha_hasta.TabIndex = 3
        '
        'btn_ver_porfecha
        '
        Me.btn_ver_porfecha.Location = New System.Drawing.Point(354, 13)
        Me.btn_ver_porfecha.Name = "btn_ver_porfecha"
        Me.btn_ver_porfecha.Size = New System.Drawing.Size(53, 23)
        Me.btn_ver_porfecha.TabIndex = 4
        Me.btn_ver_porfecha.Text = "Ver"
        Me.btn_ver_porfecha.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_historial_guard)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 389)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HISTORIAL DE GUARDERIA"
        '
        'dgv_historial_guard
        '
        Me.dgv_historial_guard.AllowUserToAddRows = False
        Me.dgv_historial_guard.AllowUserToDeleteRows = False
        Me.dgv_historial_guard.AllowUserToOrderColumns = True
        Me.dgv_historial_guard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_historial_guard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_historial_guard.Location = New System.Drawing.Point(6, 19)
        Me.dgv_historial_guard.Name = "dgv_historial_guard"
        Me.dgv_historial_guard.ReadOnly = True
        Me.dgv_historial_guard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_historial_guard.Size = New System.Drawing.Size(764, 364)
        Me.dgv_historial_guard.TabIndex = 0
        '
        'btn_historial_volver
        '
        Me.btn_historial_volver.Location = New System.Drawing.Point(707, 13)
        Me.btn_historial_volver.Name = "btn_historial_volver"
        Me.btn_historial_volver.Size = New System.Drawing.Size(75, 23)
        Me.btn_historial_volver.TabIndex = 6
        Me.btn_historial_volver.Text = "Volver"
        Me.btn_historial_volver.UseVisualStyleBackColor = True
        '
        'Historial_Guarderia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_historial_volver)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_ver_porfecha)
        Me.Controls.Add(Me.dtp_fecha_hasta)
        Me.Controls.Add(Me.dtp_fecha_desde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Historial_Guarderia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial de Guarderia"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_historial_guard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_fecha_desde As DateTimePicker
    Friend WithEvents dtp_fecha_hasta As DateTimePicker
    Friend WithEvents btn_ver_porfecha As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_historial_guard As DataGridView
    Friend WithEvents btn_historial_volver As Button
End Class
