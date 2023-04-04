<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAJA
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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmontocaja = New System.Windows.Forms.TextBox()
        Me.btngrabar = New System.Windows.Forms.Button()
        Me.txtcobrado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvcaja = New System.Windows.Forms.DataGridView()
        Me.btncerrarcaja = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgvcaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(398, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MONTO CAJA:"
        '
        'txtmontocaja
        '
        Me.txtmontocaja.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmontocaja.Location = New System.Drawing.Point(403, 71)
        Me.txtmontocaja.Name = "txtmontocaja"
        Me.txtmontocaja.Size = New System.Drawing.Size(236, 32)
        Me.txtmontocaja.TabIndex = 2
        '
        'btngrabar
        '
        Me.btngrabar.Location = New System.Drawing.Point(471, 202)
        Me.btngrabar.Name = "btngrabar"
        Me.btngrabar.Size = New System.Drawing.Size(168, 55)
        Me.btngrabar.TabIndex = 3
        Me.btngrabar.Text = "GRABAR"
        Me.btngrabar.UseVisualStyleBackColor = True
        '
        'txtcobrado
        '
        Me.txtcobrado.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcobrado.Location = New System.Drawing.Point(403, 153)
        Me.txtcobrado.Name = "txtcobrado"
        Me.txtcobrado.Size = New System.Drawing.Size(236, 32)
        Me.txtcobrado.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(398, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "TOTAL COBRADO:"
        '
        'dgvcaja
        '
        Me.dgvcaja.AllowUserToAddRows = False
        Me.dgvcaja.AllowUserToDeleteRows = False
        Me.dgvcaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcaja.Location = New System.Drawing.Point(12, 12)
        Me.dgvcaja.Name = "dgvcaja"
        Me.dgvcaja.ReadOnly = True
        Me.dgvcaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvcaja.Size = New System.Drawing.Size(369, 300)
        Me.dgvcaja.TabIndex = 6
        '
        'btncerrarcaja
        '
        Me.btncerrarcaja.BackColor = System.Drawing.Color.Red
        Me.btncerrarcaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncerrarcaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrarcaja.Location = New System.Drawing.Point(403, 202)
        Me.btncerrarcaja.Name = "btncerrarcaja"
        Me.btncerrarcaja.Size = New System.Drawing.Size(62, 55)
        Me.btncerrarcaja.TabIndex = 7
        Me.btncerrarcaja.Text = "X"
        Me.ToolTip1.SetToolTip(Me.btncerrarcaja, "CERRAR CAJA")
        Me.btncerrarcaja.UseVisualStyleBackColor = False
        '
        'CAJA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(664, 324)
        Me.Controls.Add(Me.btncerrarcaja)
        Me.Controls.Add(Me.dgvcaja)
        Me.Controls.Add(Me.txtcobrado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btngrabar)
        Me.Controls.Add(Me.txtmontocaja)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CAJA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAJA"
        CType(Me.dgvcaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtmontocaja As TextBox
    Friend WithEvents btngrabar As Button
    Friend WithEvents txtcobrado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvcaja As DataGridView
    Friend WithEvents btncerrarcaja As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
