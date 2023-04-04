<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clientes
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.dgvclientes = New System.Windows.Forms.DataGridView()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnregistrarCliente = New System.Windows.Forms.Button()
        Me.btnactualizarCliente = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgvclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvclientes
        '
        Me.dgvclientes.AllowUserToAddRows = False
        Me.dgvclientes.AllowUserToDeleteRows = False
        Me.dgvclientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvclientes.Location = New System.Drawing.Point(13, 62)
        Me.dgvclientes.Name = "dgvclientes"
        Me.dgvclientes.ReadOnly = True
        Me.dgvclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvclientes.Size = New System.Drawing.Size(973, 428)
        Me.dgvclientes.TabIndex = 13
        '
        'txtbuscar
        '
        Me.txtbuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbuscar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtbuscar.Location = New System.Drawing.Point(104, 20)
        Me.txtbuscar.MaxLength = 100
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(692, 26)
        Me.txtbuscar.TabIndex = 14
        Me.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "BUSCAR:"
        '
        'btnregistrarCliente
        '
        Me.btnregistrarCliente.BackgroundImage = CType(resources.GetObject("btnregistrarCliente.BackgroundImage"), System.Drawing.Image)
        Me.btnregistrarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnregistrarCliente.FlatAppearance.BorderSize = 0
        Me.btnregistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregistrarCliente.Location = New System.Drawing.Point(816, 1)
        Me.btnregistrarCliente.Name = "btnregistrarCliente"
        Me.btnregistrarCliente.Size = New System.Drawing.Size(56, 55)
        Me.btnregistrarCliente.TabIndex = 19
        Me.btnregistrarCliente.UseVisualStyleBackColor = True
        '
        'btnactualizarCliente
        '
        Me.btnactualizarCliente.BackgroundImage = CType(resources.GetObject("btnactualizarCliente.BackgroundImage"), System.Drawing.Image)
        Me.btnactualizarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnactualizarCliente.FlatAppearance.BorderSize = 0
        Me.btnactualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnactualizarCliente.Location = New System.Drawing.Point(885, 1)
        Me.btnactualizarCliente.Name = "btnactualizarCliente"
        Me.btnactualizarCliente.Size = New System.Drawing.Size(75, 55)
        Me.btnactualizarCliente.TabIndex = 20
        Me.btnactualizarCliente.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(998, 502)
        Me.Controls.Add(Me.btnactualizarCliente)
        Me.Controls.Add(Me.btnregistrarCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.dgvclientes)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CARTERA DE CLIENTES"
        CType(Me.dgvclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvclientes As DataGridView
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnregistrarCliente As Button
    Friend WithEvents btnactualizarCliente As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
