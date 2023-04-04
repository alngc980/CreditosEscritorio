<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagar_credito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pagar_credito))
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chekmora = New System.Windows.Forms.CheckBox()
        Me.txtmora = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbrestante = New System.Windows.Forms.Label()
        Me.lbmonto = New System.Windows.Forms.Label()
        Me.lbfecha = New System.Windows.Forms.Label()
        Me.lbnumero = New System.Windows.Forms.Label()
        Me.lbid = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lblmontofaltante = New System.Windows.Forms.Label()
        Me.txtrestante2 = New System.Windows.Forms.TextBox()
        Me.txtmonto2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtrestante = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbltotal.ForeColor = System.Drawing.Color.Red
        Me.lbltotal.Location = New System.Drawing.Point(329, 313)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(54, 26)
        Me.lbltotal.TabIndex = 21
        Me.lbltotal.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(117, 313)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(208, 26)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "TOTAL A PAGAR:"
        '
        'chekmora
        '
        Me.chekmora.AutoSize = True
        Me.chekmora.Checked = True
        Me.chekmora.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chekmora.Location = New System.Drawing.Point(443, 209)
        Me.chekmora.Name = "chekmora"
        Me.chekmora.Size = New System.Drawing.Size(15, 14)
        Me.chekmora.TabIndex = 16
        Me.chekmora.UseVisualStyleBackColor = True
        '
        'txtmora
        '
        Me.txtmora.Enabled = False
        Me.txtmora.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmora.Location = New System.Drawing.Point(199, 200)
        Me.txtmora.MaxLength = 100
        Me.txtmora.Name = "txtmora"
        Me.txtmora.Size = New System.Drawing.Size(238, 26)
        Me.txtmora.TabIndex = 11
        Me.txtmora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(55, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 22)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "MOROSIDAD :"
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(199, 94)
        Me.txtnombre.MaxLength = 100
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(287, 26)
        Me.txtnombre.TabIndex = 5
        Me.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(84, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 22)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "NOMBRE  :"
        '
        'lbrestante
        '
        Me.lbrestante.AutoSize = True
        Me.lbrestante.BackColor = System.Drawing.Color.SpringGreen
        Me.lbrestante.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbrestante.Location = New System.Drawing.Point(604, 243)
        Me.lbrestante.Name = "lbrestante"
        Me.lbrestante.Size = New System.Drawing.Size(16, 18)
        Me.lbrestante.TabIndex = 50
        Me.lbrestante.Text = "z"
        Me.lbrestante.Visible = False
        '
        'lbmonto
        '
        Me.lbmonto.AutoSize = True
        Me.lbmonto.BackColor = System.Drawing.Color.SpringGreen
        Me.lbmonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbmonto.Location = New System.Drawing.Point(604, 207)
        Me.lbmonto.Name = "lbmonto"
        Me.lbmonto.Size = New System.Drawing.Size(16, 18)
        Me.lbmonto.TabIndex = 49
        Me.lbmonto.Text = "z"
        Me.lbmonto.Visible = False
        '
        'lbfecha
        '
        Me.lbfecha.AutoSize = True
        Me.lbfecha.BackColor = System.Drawing.Color.SpringGreen
        Me.lbfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbfecha.Location = New System.Drawing.Point(604, 171)
        Me.lbfecha.Name = "lbfecha"
        Me.lbfecha.Size = New System.Drawing.Size(16, 18)
        Me.lbfecha.TabIndex = 48
        Me.lbfecha.Text = "z"
        Me.lbfecha.Visible = False
        '
        'lbnumero
        '
        Me.lbnumero.AutoSize = True
        Me.lbnumero.BackColor = System.Drawing.Color.SpringGreen
        Me.lbnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbnumero.Location = New System.Drawing.Point(604, 136)
        Me.lbnumero.Name = "lbnumero"
        Me.lbnumero.Size = New System.Drawing.Size(16, 18)
        Me.lbnumero.TabIndex = 47
        Me.lbnumero.Text = "z"
        Me.lbnumero.Visible = False
        '
        'lbid
        '
        Me.lbid.AutoSize = True
        Me.lbid.BackColor = System.Drawing.Color.SpringGreen
        Me.lbid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbid.Location = New System.Drawing.Point(604, 101)
        Me.lbid.Name = "lbid"
        Me.lbid.Size = New System.Drawing.Size(16, 18)
        Me.lbid.TabIndex = 46
        Me.lbid.Text = "z"
        Me.lbid.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(328, 238)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lblmontofaltante
        '
        Me.lblmontofaltante.AutoSize = True
        Me.lblmontofaltante.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmontofaltante.Location = New System.Drawing.Point(568, 207)
        Me.lblmontofaltante.Name = "lblmontofaltante"
        Me.lblmontofaltante.Size = New System.Drawing.Size(16, 18)
        Me.lblmontofaltante.TabIndex = 41
        Me.lblmontofaltante.Text = "0"
        Me.lblmontofaltante.Visible = False
        '
        'txtrestante2
        '
        Me.txtrestante2.Enabled = False
        Me.txtrestante2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrestante2.Location = New System.Drawing.Point(357, 271)
        Me.txtrestante2.Name = "txtrestante2"
        Me.txtrestante2.Size = New System.Drawing.Size(112, 26)
        Me.txtrestante2.TabIndex = 19
        Me.txtrestante2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmonto2
        '
        Me.txtmonto2.Enabled = False
        Me.txtmonto2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonto2.Location = New System.Drawing.Point(357, 235)
        Me.txtmonto2.Name = "txtmonto2"
        Me.txtmonto2.Size = New System.Drawing.Size(112, 26)
        Me.txtmonto2.TabIndex = 15
        Me.txtmonto2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(175, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 42)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "GUARDAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtrestante
        '
        Me.txtrestante.Enabled = False
        Me.txtrestante.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrestante.Location = New System.Drawing.Point(199, 271)
        Me.txtrestante.Name = "txtrestante"
        Me.txtrestante.Size = New System.Drawing.Size(112, 26)
        Me.txtrestante.TabIndex = 18
        Me.txtrestante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(2, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(194, 22)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "DEUDA RESTANTE :"
        '
        'txtmonto
        '
        Me.txtmonto.Enabled = False
        Me.txtmonto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonto.Location = New System.Drawing.Point(199, 235)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(112, 26)
        Me.txtmonto.TabIndex = 13
        Me.txtmonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(14, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "MONTO A PAGAR :"
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha.Location = New System.Drawing.Point(199, 165)
        Me.txtfecha.MaxLength = 100
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(287, 26)
        Me.txtfecha.TabIndex = 9
        Me.txtfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(20, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "FECHA DE PAGO :"
        '
        'txtnumero
        '
        Me.txtnumero.Enabled = False
        Me.txtnumero.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumero.Location = New System.Drawing.Point(199, 130)
        Me.txtnumero.MaxLength = 3000
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(287, 26)
        Me.txtnumero.TabIndex = 7
        Me.txtnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(83, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "N° CUOTA :"
        '
        'txtid
        '
        Me.txtid.Enabled = False
        Me.txtid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(199, 58)
        Me.txtid.MaxLength = 100
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(287, 26)
        Me.txtid.TabIndex = 3
        Me.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(42, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID PRESTAMO :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(457, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "REALIZAR PAGO DEL PRESTAMO"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Red
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(8, 10)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(478, 42)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Pagar_credito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(490, 404)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.chekmora)
        Me.Controls.Add(Me.txtmora)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbrestante)
        Me.Controls.Add(Me.lbmonto)
        Me.Controls.Add(Me.lbfecha)
        Me.Controls.Add(Me.lbnumero)
        Me.Controls.Add(Me.lbid)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lblmontofaltante)
        Me.Controls.Add(Me.txtrestante2)
        Me.Controls.Add(Me.txtmonto2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtrestante)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtmonto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pagar_credito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAGAR PRESTAMO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents chekmora As CheckBox
    Friend WithEvents txtmora As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbrestante As Label
    Friend WithEvents lbmonto As Label
    Friend WithEvents lbfecha As Label
    Friend WithEvents lbnumero As Label
    Friend WithEvents lbid As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents lblmontofaltante As Label
    Friend WithEvents txtrestante2 As TextBox
    Friend WithEvents txtmonto2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtrestante As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtmonto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
