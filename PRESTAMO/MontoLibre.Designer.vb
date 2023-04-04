<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MontoLibre
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
        Me.txtmora = New System.Windows.Forms.TextBox()
        Me.txtdeuda = New System.Windows.Forms.TextBox()
        Me.txtsuma = New System.Windows.Forms.TextBox()
        Me.txtmontopagar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnpagar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtmora
        '
        Me.txtmora.Enabled = False
        Me.txtmora.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmora.Location = New System.Drawing.Point(201, 3)
        Me.txtmora.Name = "txtmora"
        Me.txtmora.Size = New System.Drawing.Size(226, 27)
        Me.txtmora.TabIndex = 1
        Me.txtmora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdeuda
        '
        Me.txtdeuda.Enabled = False
        Me.txtdeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdeuda.Location = New System.Drawing.Point(201, 51)
        Me.txtdeuda.Name = "txtdeuda"
        Me.txtdeuda.Size = New System.Drawing.Size(226, 27)
        Me.txtdeuda.TabIndex = 3
        Me.txtdeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsuma
        '
        Me.txtsuma.Enabled = False
        Me.txtsuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsuma.Location = New System.Drawing.Point(201, 104)
        Me.txtsuma.Name = "txtsuma"
        Me.txtsuma.Size = New System.Drawing.Size(226, 27)
        Me.txtsuma.TabIndex = 5
        Me.txtsuma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmontopagar
        '
        Me.txtmontopagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmontopagar.Location = New System.Drawing.Point(213, 184)
        Me.txtmontopagar.Name = "txtmontopagar"
        Me.txtmontopagar.Size = New System.Drawing.Size(226, 27)
        Me.txtmontopagar.TabIndex = 2
        Me.txtmontopagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MORA TOTAL:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DEUDA TOTAL:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SUMATORIA:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 22)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "INGRESE EL MONTO:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtsuma)
        Me.Panel1.Controls.Add(Me.txtmora)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtdeuda)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 145)
        Me.Panel1.TabIndex = 0
        '
        'btnpagar
        '
        Me.btnpagar.Location = New System.Drawing.Point(257, 229)
        Me.btnpagar.Name = "btnpagar"
        Me.btnpagar.Size = New System.Drawing.Size(146, 67)
        Me.btnpagar.TabIndex = 3
        Me.btnpagar.Text = "GRABAR"
        Me.btnpagar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(68, 229)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(146, 67)
        Me.btncancelar.TabIndex = 4
        Me.btncancelar.Text = "CANCELACION"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'MontoLibre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(488, 308)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnpagar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtmontopagar)
        Me.Name = "MontoLibre"
        Me.Text = "PAGOS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtmora As TextBox
    Friend WithEvents txtdeuda As TextBox
    Friend WithEvents txtsuma As TextBox
    Friend WithEvents txtmontopagar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnpagar As Button
    Friend WithEvents btncancelar As Button
End Class
