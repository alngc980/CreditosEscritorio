<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Giros
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
        Me.txtorigen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdniemisor = New System.Windows.Forms.TextBox()
        Me.txtonombremisor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtdestino = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdnireceptor = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtnombrereceptor = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btngiro = New System.Windows.Forms.Button()
        Me.lblcodiforet = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcomision = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmontogiro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtorigen
        '
        Me.txtorigen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtorigen.Enabled = False
        Me.txtorigen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtorigen.Location = New System.Drawing.Point(192, 15)
        Me.txtorigen.MaxLength = 8
        Me.txtorigen.Name = "txtorigen"
        Me.txtorigen.Size = New System.Drawing.Size(445, 26)
        Me.txtorigen.TabIndex = 1
        Me.txtorigen.Text = "IQUITOS"
        Me.txtorigen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(145, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DNI :"
        '
        'txtdniemisor
        '
        Me.txtdniemisor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdniemisor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdniemisor.Location = New System.Drawing.Point(192, 46)
        Me.txtdniemisor.MaxLength = 8
        Me.txtdniemisor.Name = "txtdniemisor"
        Me.txtdniemisor.Size = New System.Drawing.Size(445, 26)
        Me.txtdniemisor.TabIndex = 3
        Me.txtdniemisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtonombremisor
        '
        Me.txtonombremisor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtonombremisor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtonombremisor.Location = New System.Drawing.Point(192, 77)
        Me.txtonombremisor.MaxLength = 100
        Me.txtonombremisor.Name = "txtonombremisor"
        Me.txtonombremisor.Size = New System.Drawing.Size(445, 26)
        Me.txtonombremisor.TabIndex = 5
        Me.txtonombremisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(10, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(180, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "NOMBRE COMPLETO :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(47, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ORIGEN CIUDAD :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtonombremisor)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtorigen)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtdniemisor)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(658, 117)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "EMISOR"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtdestino)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtdnireceptor)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtnombrereceptor)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 295)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(658, 125)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RECEPTOR"
        '
        'txtdestino
        '
        Me.txtdestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdestino.Enabled = False
        Me.txtdestino.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdestino.Location = New System.Drawing.Point(192, 22)
        Me.txtdestino.Name = "txtdestino"
        Me.txtdestino.Size = New System.Drawing.Size(445, 26)
        Me.txtdestino.TabIndex = 1
        Me.txtdestino.Text = "TARAPOTO"
        Me.txtdestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(105, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DESTINO :"
        '
        'txtdnireceptor
        '
        Me.txtdnireceptor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdnireceptor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdnireceptor.Location = New System.Drawing.Point(192, 53)
        Me.txtdnireceptor.MaxLength = 8
        Me.txtdnireceptor.Name = "txtdnireceptor"
        Me.txtdnireceptor.Size = New System.Drawing.Size(445, 26)
        Me.txtdnireceptor.TabIndex = 3
        Me.txtdnireceptor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(10, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "NOMBRE COMPLETO :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(145, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "DNI :"
        '
        'txtnombrereceptor
        '
        Me.txtnombrereceptor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnombrereceptor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombrereceptor.Location = New System.Drawing.Point(192, 84)
        Me.txtnombrereceptor.MaxLength = 100
        Me.txtnombrereceptor.Name = "txtnombrereceptor"
        Me.txtnombrereceptor.Size = New System.Drawing.Size(445, 26)
        Me.txtnombrereceptor.TabIndex = 5
        Me.txtnombrereceptor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PRESTAMO.My.Resources.Resources.WhatsApp_Image_2020_06_30_at_9_10_04_PM
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(44, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 41
        Me.PictureBox1.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Yellow
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(198, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(451, 62)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "GIROS DE DINERO A TARAPOTO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "            SEGURO Y RAPIDO :"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Yellow
        Me.TextBox1.Location = New System.Drawing.Point(171, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(499, 102)
        Me.TextBox1.TabIndex = 0
        '
        'txtid
        '
        Me.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtid.Enabled = False
        Me.txtid.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(204, 140)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(445, 26)
        Me.txtid.TabIndex = 3
        Me.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(168, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID :"
        '
        'btngiro
        '
        Me.btngiro.BackColor = System.Drawing.Color.Blue
        Me.btngiro.ForeColor = System.Drawing.Color.White
        Me.btngiro.Location = New System.Drawing.Point(381, 528)
        Me.btngiro.Name = "btngiro"
        Me.btngiro.Size = New System.Drawing.Size(268, 60)
        Me.btngiro.TabIndex = 14
        Me.btngiro.Text = "GUARDAR - IMPRIMIR GIRO"
        Me.btngiro.UseVisualStyleBackColor = False
        '
        'lblcodiforet
        '
        Me.lblcodiforet.AutoSize = True
        Me.lblcodiforet.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcodiforet.ForeColor = System.Drawing.Color.Blue
        Me.lblcodiforet.Location = New System.Drawing.Point(289, 551)
        Me.lblcodiforet.Name = "lblcodiforet"
        Me.lblcodiforet.Size = New System.Drawing.Size(76, 26)
        Me.lblcodiforet.TabIndex = 13
        Me.lblcodiforet.Text = "XXXX"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 551)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(263, 26)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "CODIGO DE RETIRO :"
        '
        'txtcomision
        '
        Me.txtcomision.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcomision.Enabled = False
        Me.txtcomision.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomision.Location = New System.Drawing.Point(204, 458)
        Me.txtcomision.MaxLength = 100
        Me.txtcomision.Name = "txtcomision"
        Me.txtcomision.Size = New System.Drawing.Size(445, 26)
        Me.txtcomision.TabIndex = 9
        Me.txtcomision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(104, 463)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "COMISION :"
        '
        'txtmontogiro
        '
        Me.txtmontogiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtmontogiro.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmontogiro.Location = New System.Drawing.Point(204, 426)
        Me.txtmontogiro.MaxLength = 100
        Me.txtmontogiro.Name = "txtmontogiro"
        Me.txtmontogiro.Size = New System.Drawing.Size(445, 26)
        Me.txtmontogiro.TabIndex = 7
        Me.txtmontogiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(58, 431)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "MONTO A GIRAR :"
        '
        'txttotal
        '
        Me.txttotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttotal.Enabled = False
        Me.txttotal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(204, 490)
        Me.txttotal.MaxLength = 100
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(445, 26)
        Me.txttotal.TabIndex = 11
        Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(65, 495)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 17)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "TOTAL A PAGAR :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(459, 117)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 17)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "FECHA :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(530, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 15)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "XXXX"
        '
        'Giros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 600)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtcomision)
        Me.Controls.Add(Me.btngiro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.txtmontogiro)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblcodiforet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Giros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Giros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtorigen As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdniemisor As TextBox
    Friend WithEvents txtonombremisor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtdnireceptor As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtnombrereceptor As TextBox
    Friend WithEvents txtdestino As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btngiro As Button
    Friend WithEvents lblcodiforet As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcomision As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtmontogiro As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
