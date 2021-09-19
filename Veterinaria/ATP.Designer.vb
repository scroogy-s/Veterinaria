<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ATP
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
        Me.btn_volver_atp = New System.Windows.Forms.Button()
        Me.btn_baja_atp = New System.Windows.Forms.Button()
        Me.btn_alta_atp = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_atp = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_atp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_volver_atp
        '
        Me.btn_volver_atp.Location = New System.Drawing.Point(326, 293)
        Me.btn_volver_atp.Name = "btn_volver_atp"
        Me.btn_volver_atp.Size = New System.Drawing.Size(75, 23)
        Me.btn_volver_atp.TabIndex = 9
        Me.btn_volver_atp.Text = "Volver"
        Me.btn_volver_atp.UseVisualStyleBackColor = True
        '
        'btn_baja_atp
        '
        Me.btn_baja_atp.Location = New System.Drawing.Point(93, 293)
        Me.btn_baja_atp.Name = "btn_baja_atp"
        Me.btn_baja_atp.Size = New System.Drawing.Size(75, 23)
        Me.btn_baja_atp.TabIndex = 8
        Me.btn_baja_atp.Text = "Baja"
        Me.btn_baja_atp.UseVisualStyleBackColor = True
        '
        'btn_alta_atp
        '
        Me.btn_alta_atp.Location = New System.Drawing.Point(12, 293)
        Me.btn_alta_atp.Name = "btn_alta_atp"
        Me.btn_alta_atp.Size = New System.Drawing.Size(75, 23)
        Me.btn_alta_atp.TabIndex = 7
        Me.btn_alta_atp.Text = "Alta"
        Me.btn_alta_atp.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_atp)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 275)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipos de Antiparasitarios"
        '
        'dgv_atp
        '
        Me.dgv_atp.AllowUserToAddRows = False
        Me.dgv_atp.AllowUserToDeleteRows = False
        Me.dgv_atp.AllowUserToOrderColumns = True
        Me.dgv_atp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_atp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_atp.Location = New System.Drawing.Point(6, 19)
        Me.dgv_atp.Name = "dgv_atp"
        Me.dgv_atp.ReadOnly = True
        Me.dgv_atp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_atp.Size = New System.Drawing.Size(377, 250)
        Me.dgv_atp.TabIndex = 0
        '
        'ATP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 330)
        Me.Controls.Add(Me.btn_volver_atp)
        Me.Controls.Add(Me.btn_baja_atp)
        Me.Controls.Add(Me.btn_alta_atp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ATP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Antiparasitarios"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_atp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_volver_atp As Button
    Friend WithEvents btn_baja_atp As Button
    Friend WithEvents btn_alta_atp As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_atp As DataGridView
End Class
