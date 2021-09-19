<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busqueda_Cliente
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
        Me.dgv_clientes = New System.Windows.Forms.DataGridView()
        Me.cmb_buscar = New System.Windows.Forms.ComboBox()
        Me.txtbox_buscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_seleccionar_cliente = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_clientes)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(756, 269)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clientes"
        '
        'dgv_clientes
        '
        Me.dgv_clientes.AllowUserToAddRows = False
        Me.dgv_clientes.AllowUserToDeleteRows = False
        Me.dgv_clientes.AllowUserToOrderColumns = True
        Me.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_clientes.Location = New System.Drawing.Point(6, 19)
        Me.dgv_clientes.Name = "dgv_clientes"
        Me.dgv_clientes.ReadOnly = True
        Me.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_clientes.Size = New System.Drawing.Size(744, 244)
        Me.dgv_clientes.TabIndex = 0
        '
        'cmb_buscar
        '
        Me.cmb_buscar.FormattingEnabled = True
        Me.cmb_buscar.Items.AddRange(New Object() {"Nombre", "Direccion", "Celular", "Localidad", "Provincia", "eMail"})
        Me.cmb_buscar.Location = New System.Drawing.Point(314, 300)
        Me.cmb_buscar.Name = "cmb_buscar"
        Me.cmb_buscar.Size = New System.Drawing.Size(121, 21)
        Me.cmb_buscar.TabIndex = 9
        '
        'txtbox_buscar
        '
        Me.txtbox_buscar.Location = New System.Drawing.Point(101, 300)
        Me.txtbox_buscar.Name = "txtbox_buscar"
        Me.txtbox_buscar.Size = New System.Drawing.Size(121, 20)
        Me.txtbox_buscar.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(228, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "BUSCAR POR:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "BUSCAR:"
        '
        'btn_seleccionar_cliente
        '
        Me.btn_seleccionar_cliente.Location = New System.Drawing.Point(640, 298)
        Me.btn_seleccionar_cliente.Name = "btn_seleccionar_cliente"
        Me.btn_seleccionar_cliente.Size = New System.Drawing.Size(128, 23)
        Me.btn_seleccionar_cliente.TabIndex = 10
        Me.btn_seleccionar_cliente.Text = "Seleccionar Cliente"
        Me.btn_seleccionar_cliente.UseVisualStyleBackColor = True
        '
        'Busqueda_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 342)
        Me.Controls.Add(Me.btn_seleccionar_cliente)
        Me.Controls.Add(Me.cmb_buscar)
        Me.Controls.Add(Me.txtbox_buscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Busqueda_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Cliente"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_clientes As DataGridView
    Friend WithEvents cmb_buscar As ComboBox
    Friend WithEvents txtbox_buscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_seleccionar_cliente As Button
End Class
