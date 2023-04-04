<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal_C
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal_C))
        Me.dgvlista = New System.Windows.Forms.DataGridView()
        Me.btnimprimirpagos = New System.Windows.Forms.Button()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.btnuevo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btncompromisodepago = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblcapitalprestado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvlista
        '
        Me.dgvlista.AllowUserToAddRows = False
        Me.dgvlista.AllowUserToDeleteRows = False
        Me.dgvlista.AllowUserToResizeRows = False
        Me.dgvlista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvlista.BackgroundColor = System.Drawing.Color.White
        Me.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlista.Location = New System.Drawing.Point(12, 56)
        Me.dgvlista.Name = "dgvlista"
        Me.dgvlista.ReadOnly = True
        Me.dgvlista.RowHeadersVisible = False
        Me.dgvlista.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvlista.RowTemplate.Height = 30
        Me.dgvlista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvlista.Size = New System.Drawing.Size(976, 326)
        Me.dgvlista.TabIndex = 6
        '
        'btnimprimirpagos
        '
        Me.btnimprimirpagos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnimprimirpagos.FlatAppearance.BorderSize = 0
        Me.btnimprimirpagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnimprimirpagos.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.btnimprimirpagos.Location = New System.Drawing.Point(578, 6)
        Me.btnimprimirpagos.Name = "btnimprimirpagos"
        Me.btnimprimirpagos.Size = New System.Drawing.Size(111, 44)
        Me.btnimprimirpagos.TabIndex = 3
        Me.btnimprimirpagos.Text = "VER PRESTAMO"
        Me.btnimprimirpagos.UseVisualStyleBackColor = False
        '
        'btnimprimir
        '
        Me.btnimprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnimprimir.FlatAppearance.BorderSize = 0
        Me.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnimprimir.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.btnimprimir.Location = New System.Drawing.Point(509, 185)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(118, 43)
        Me.btnimprimir.TabIndex = 4
        Me.btnimprimir.Text = "REIMPRIMIR CRONOGRAMA"
        Me.btnimprimir.UseVisualStyleBackColor = False
        '
        'btnuevo
        '
        Me.btnuevo.BackColor = System.Drawing.Color.Green
        Me.btnuevo.FlatAppearance.BorderSize = 0
        Me.btnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnuevo.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.btnuevo.ForeColor = System.Drawing.Color.White
        Me.btnuevo.Location = New System.Drawing.Point(475, 5)
        Me.btnuevo.Name = "btnuevo"
        Me.btnuevo.Size = New System.Drawing.Size(97, 44)
        Me.btnuevo.TabIndex = 2
        Me.btnuevo.Text = "NUEVO PRESTAMO"
        Me.btnuevo.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "BUSCAR PRESTAMO:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(189, 14)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(280, 26)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btncompromisodepago
        '
        Me.btncompromisodepago.BackColor = System.Drawing.Color.Cyan
        Me.btncompromisodepago.FlatAppearance.BorderSize = 0
        Me.btncompromisodepago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncompromisodepago.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.btncompromisodepago.Location = New System.Drawing.Point(698, 5)
        Me.btncompromisodepago.Name = "btncompromisodepago"
        Me.btncompromisodepago.Size = New System.Drawing.Size(98, 44)
        Me.btncompromisodepago.TabIndex = 5
        Me.btncompromisodepago.Text = "REPORTES"
        Me.btncompromisodepago.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(802, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 44)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "GIROS"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(424, 394)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "TOTAL A COBRAR PENDIENTE:"
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.Red
        Me.lbltotal.Location = New System.Drawing.Point(684, 394)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(47, 25)
        Me.lbltotal.TabIndex = 9
        Me.lbltotal.Text = "0.00"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.Button2.Location = New System.Drawing.Point(890, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 44)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "CAJA"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblcapitalprestado
        '
        Me.lblcapitalprestado.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblcapitalprestado.AutoSize = True
        Me.lblcapitalprestado.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcapitalprestado.ForeColor = System.Drawing.Color.Red
        Me.lblcapitalprestado.Location = New System.Drawing.Point(282, 394)
        Me.lblcapitalprestado.Name = "lblcapitalprestado"
        Me.lblcapitalprestado.Size = New System.Drawing.Size(47, 25)
        Me.lblcapitalprestado.TabIndex = 12
        Me.lblcapitalprestado.Text = "0.00"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(101, 394)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "CAPITAL PRESTADO:"
        '
        'Principal_C
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(999, 429)
        Me.Controls.Add(Me.lblcapitalprestado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btncompromisodepago)
        Me.Controls.Add(Me.btnimprimirpagos)
        Me.Controls.Add(Me.btnuevo)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvlista)
        Me.Controls.Add(Me.btnimprimir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Principal_C"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRINCIPAL PRESTAMOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvlista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvlista As DataGridView
    Friend WithEvents btnimprimirpagos As Button
    Friend WithEvents btnimprimir As Button
    Friend WithEvents btnuevo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btncompromisodepago As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents lblcapitalprestado As Label
    Friend WithEvents Label4 As Label
End Class
