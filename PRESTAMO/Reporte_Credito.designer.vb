<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_Credito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reporte_Credito))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblnombrecliente = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbldineroprestado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblgarante = New System.Windows.Forms.Label()
        Me.dgvpagos = New System.Windows.Forms.DataGridView()
        Me.btnpagar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnimprimir = New System.Windows.Forms.Button()
        Me.BTNANULAR = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnmontolibre = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvpagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CLIENTE :"
        '
        'lblnombrecliente
        '
        Me.lblnombrecliente.AutoSize = True
        Me.lblnombrecliente.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombrecliente.Location = New System.Drawing.Point(145, 43)
        Me.lblnombrecliente.Name = "lblnombrecliente"
        Me.lblnombrecliente.Size = New System.Drawing.Size(66, 22)
        Me.lblnombrecliente.TabIndex = 2
        Me.lblnombrecliente.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(32, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(339, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "DINERO TOTAL A DEVOLVER :"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbltotal.ForeColor = System.Drawing.Color.Red
        Me.lbltotal.Location = New System.Drawing.Point(371, 145)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(77, 25)
        Me.lbltotal.TabIndex = 4
        Me.lbltotal.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 22)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ID PRESTAMO  :"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(188, 9)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(66, 22)
        Me.lblid.TabIndex = 12
        Me.lblid.Text = "Label3"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.lbldineroprestado)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lblgarante)
        Me.Panel2.Controls.Add(Me.lbltotal)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblid)
        Me.Panel2.Controls.Add(Me.lblnombrecliente)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(3, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(552, 183)
        Me.Panel2.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(32, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(236, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "DINERO PRESTADO :"
        '
        'lbldineroprestado
        '
        Me.lbldineroprestado.AutoSize = True
        Me.lbldineroprestado.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbldineroprestado.ForeColor = System.Drawing.Color.Red
        Me.lbldineroprestado.Location = New System.Drawing.Point(272, 108)
        Me.lbldineroprestado.Name = "lbldineroprestado"
        Me.lbldineroprestado.Size = New System.Drawing.Size(23, 25)
        Me.lbldineroprestado.TabIndex = 17
        Me.lbldineroprestado.Text = "0"
        Me.lbldineroprestado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 22)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "GARANTE - GARANTIA :"
        '
        'lblgarante
        '
        Me.lblgarante.AutoSize = True
        Me.lblgarante.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgarante.Location = New System.Drawing.Point(268, 78)
        Me.lblgarante.Name = "lblgarante"
        Me.lblgarante.Size = New System.Drawing.Size(66, 22)
        Me.lblgarante.TabIndex = 15
        Me.lblgarante.Text = "Label2"
        '
        'dgvpagos
        '
        Me.dgvpagos.AllowUserToAddRows = False
        Me.dgvpagos.AllowUserToDeleteRows = False
        Me.dgvpagos.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.dgvpagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpagos.Location = New System.Drawing.Point(3, 292)
        Me.dgvpagos.Name = "dgvpagos"
        Me.dgvpagos.ReadOnly = True
        Me.dgvpagos.RowHeadersVisible = False
        Me.dgvpagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvpagos.Size = New System.Drawing.Size(552, 239)
        Me.dgvpagos.TabIndex = 7
        '
        'btnpagar
        '
        Me.btnpagar.BackColor = System.Drawing.Color.Blue
        Me.btnpagar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpagar.ForeColor = System.Drawing.Color.White
        Me.btnpagar.Location = New System.Drawing.Point(447, 537)
        Me.btnpagar.Name = "btnpagar"
        Me.btnpagar.Size = New System.Drawing.Size(108, 50)
        Me.btnpagar.TabIndex = 5
        Me.btnpagar.Text = "PAGAR PRESTAMO"
        Me.btnpagar.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Red
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, 7)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(552, 42)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(70, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(460, 31)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ESTADO DE CUENTA PRESTAMOS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Red
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(21, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(457, 31)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "REALIZAR PAGO DEL PRESTAMO"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Red
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(3, 244)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(484, 42)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnimprimir
        '
        Me.btnimprimir.BackColor = System.Drawing.Color.Blue
        Me.btnimprimir.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimprimir.ForeColor = System.Drawing.Color.White
        Me.btnimprimir.Location = New System.Drawing.Point(486, 238)
        Me.btnimprimir.Name = "btnimprimir"
        Me.btnimprimir.Size = New System.Drawing.Size(69, 50)
        Me.btnimprimir.TabIndex = 6
        Me.btnimprimir.Text = "PRINT"
        Me.btnimprimir.UseVisualStyleBackColor = False
        '
        'BTNANULAR
        '
        Me.BTNANULAR.BackColor = System.Drawing.Color.Red
        Me.BTNANULAR.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNANULAR.ForeColor = System.Drawing.Color.White
        Me.BTNANULAR.Location = New System.Drawing.Point(3, 537)
        Me.BTNANULAR.Name = "BTNANULAR"
        Me.BTNANULAR.Size = New System.Drawing.Size(108, 50)
        Me.BTNANULAR.TabIndex = 9
        Me.BTNANULAR.Text = "ANULAR PRESTAMO"
        Me.BTNANULAR.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(582, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(424, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "IMPRIMIR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(570, 36)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReuseParameterValuesOnRefresh = True
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowPageNavigateButtons = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.ShowTextSearchButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(436, 560)
        Me.CrystalReportViewer1.TabIndex = 10
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btnmontolibre
        '
        Me.btnmontolibre.BackColor = System.Drawing.Color.Blue
        Me.btnmontolibre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmontolibre.ForeColor = System.Drawing.Color.White
        Me.btnmontolibre.Location = New System.Drawing.Point(299, 537)
        Me.btnmontolibre.Name = "btnmontolibre"
        Me.btnmontolibre.Size = New System.Drawing.Size(108, 50)
        Me.btnmontolibre.TabIndex = 13
        Me.btnmontolibre.Text = "MONTO LIBRE"
        Me.btnmontolibre.UseVisualStyleBackColor = False
        '
        'Reporte_Credito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1025, 599)
        Me.Controls.Add(Me.btnmontolibre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.BTNANULAR)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnpagar)
        Me.Controls.Add(Me.btnimprimir)
        Me.Controls.Add(Me.dgvpagos)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reporte_Credito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ESTADO DE CUENTA Y PAGOS"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvpagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblnombrecliente As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblid As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvpagos As DataGridView
    Friend WithEvents btnpagar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lbldineroprestado As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblgarante As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnimprimir As Button
    Friend WithEvents BTNANULAR As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnmontolibre As Button
End Class
