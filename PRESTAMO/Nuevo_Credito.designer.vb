<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Nuevo_Credito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nuevo_Credito))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.checkfecharegistro = New System.Windows.Forms.CheckBox()
        Me.cbpagos = New System.Windows.Forms.ComboBox()
        Me.cbvendedor = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblsaldo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txttratado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpfecharegistro = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvpagoss = New System.Windows.Forms.DataGridView()
        Me.CUOTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MONTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALDOO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnregistrar = New System.Windows.Forms.Button()
        Me.txtnumeropagos = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RibbonCheckBox3 = New System.Windows.Forms.RibbonCheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtgarantia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtgarante = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtdniruc = New System.Windows.Forms.TextBox()
        Me.lblcodigoclientexx = New System.Windows.Forms.Label()
        Me.lblnombrecliente = New System.Windows.Forms.Label()
        Me.lbldoccliente = New System.Windows.Forms.Label()
        Me.RibbonCheckBox2 = New System.Windows.Forms.RibbonCheckBox()
        Me.txtpc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb14ultrex = New System.Windows.Forms.CheckBox()
        Me.RibbonCheckBox1 = New System.Windows.Forms.RibbonCheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvpagoss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'checkfecharegistro
        '
        resources.ApplyResources(Me.checkfecharegistro, "checkfecharegistro")
        Me.checkfecharegistro.Name = "checkfecharegistro"
        Me.checkfecharegistro.UseVisualStyleBackColor = True
        '
        'cbpagos
        '
        Me.cbpagos.BackColor = System.Drawing.SystemColors.Window
        Me.cbpagos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cbpagos, "cbpagos")
        Me.cbpagos.FormattingEnabled = True
        Me.cbpagos.Items.AddRange(New Object() {resources.GetString("cbpagos.Items"), resources.GetString("cbpagos.Items1")})
        Me.cbpagos.Name = "cbpagos"
        '
        'cbvendedor
        '
        Me.cbvendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cbvendedor, "cbvendedor")
        Me.cbvendedor.FormattingEnabled = True
        Me.cbvendedor.Name = "cbvendedor"
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.Name = "Label20"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'lblsaldo
        '
        resources.ApplyResources(Me.lblsaldo, "lblsaldo")
        Me.lblsaldo.ForeColor = System.Drawing.Color.Red
        Me.lblsaldo.Name = "lblsaldo"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.ComboBox1)
        Me.Panel4.Controls.Add(Me.txttratado)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.lblsaldo)
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("ComboBox1.AutoCompleteCustomSource"), resources.GetString("ComboBox1.AutoCompleteCustomSource1"), resources.GetString("ComboBox1.AutoCompleteCustomSource2")})
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {resources.GetString("ComboBox1.Items"), resources.GetString("ComboBox1.Items1")})
        Me.ComboBox1.Name = "ComboBox1"
        '
        'txttratado
        '
        resources.ApplyResources(Me.txttratado, "txttratado")
        Me.txttratado.ForeColor = System.Drawing.Color.Red
        Me.txttratado.Name = "txttratado"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'dtpfecharegistro
        '
        resources.ApplyResources(Me.dtpfecharegistro, "dtpfecharegistro")
        Me.dtpfecharegistro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecharegistro.Name = "dtpfecharegistro"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.dgvpagoss)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dtpfecharegistro)
        Me.Panel2.Controls.Add(Me.checkfecharegistro)
        Me.Panel2.Controls.Add(Me.cbpagos)
        Me.Panel2.Controls.Add(Me.btnregistrar)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtnumeropagos)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'dgvpagoss
        '
        Me.dgvpagoss.AllowUserToAddRows = False
        Me.dgvpagoss.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvpagoss.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvpagoss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpagoss.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CUOTA, Me.FECHA, Me.MONTO, Me.SALDOO})
        resources.ApplyResources(Me.dgvpagoss, "dgvpagoss")
        Me.dgvpagoss.Name = "dgvpagoss"
        Me.dgvpagoss.ReadOnly = True
        Me.dgvpagoss.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvpagoss.RowTemplate.Height = 25
        '
        'CUOTA
        '
        resources.ApplyResources(Me.CUOTA, "CUOTA")
        Me.CUOTA.Name = "CUOTA"
        Me.CUOTA.ReadOnly = True
        '
        'FECHA
        '
        resources.ApplyResources(Me.FECHA, "FECHA")
        Me.FECHA.Name = "FECHA"
        Me.FECHA.ReadOnly = True
        '
        'MONTO
        '
        resources.ApplyResources(Me.MONTO, "MONTO")
        Me.MONTO.Name = "MONTO"
        Me.MONTO.ReadOnly = True
        '
        'SALDOO
        '
        resources.ApplyResources(Me.SALDOO, "SALDOO")
        Me.SALDOO.Name = "SALDOO"
        Me.SALDOO.ReadOnly = True
        '
        'btnregistrar
        '
        resources.ApplyResources(Me.btnregistrar, "btnregistrar")
        Me.btnregistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnregistrar.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnregistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnregistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.UseVisualStyleBackColor = True
        '
        'txtnumeropagos
        '
        Me.txtnumeropagos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtnumeropagos, "txtnumeropagos")
        Me.txtnumeropagos.Name = "txtnumeropagos"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtgarantia)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtgarante)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.txtdireccion)
        Me.GroupBox3.Controls.Add(Me.txtnombre)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtdniruc)
        Me.GroupBox3.Controls.Add(Me.lblcodigoclientexx)
        Me.GroupBox3.Controls.Add(Me.lblnombrecliente)
        Me.GroupBox3.Controls.Add(Me.lbldoccliente)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'txtgarantia
        '
        resources.ApplyResources(Me.txtgarantia, "txtgarantia")
        Me.txtgarantia.Name = "txtgarantia"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'txtgarante
        '
        resources.ApplyResources(Me.txtgarante, "txtgarante")
        Me.txtgarante.Name = "txtgarante"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.ForeColor = System.Drawing.Color.White
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtdireccion
        '
        resources.ApplyResources(Me.txtdireccion, "txtdireccion")
        Me.txtdireccion.Name = "txtdireccion"
        '
        'txtnombre
        '
        resources.ApplyResources(Me.txtnombre, "txtnombre")
        Me.txtnombre.Name = "txtnombre"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'txtdniruc
        '
        resources.ApplyResources(Me.txtdniruc, "txtdniruc")
        Me.txtdniruc.Name = "txtdniruc"
        '
        'lblcodigoclientexx
        '
        resources.ApplyResources(Me.lblcodigoclientexx, "lblcodigoclientexx")
        Me.lblcodigoclientexx.Name = "lblcodigoclientexx"
        '
        'lblnombrecliente
        '
        resources.ApplyResources(Me.lblnombrecliente, "lblnombrecliente")
        Me.lblnombrecliente.Name = "lblnombrecliente"
        '
        'lbldoccliente
        '
        resources.ApplyResources(Me.lbldoccliente, "lbldoccliente")
        Me.lbldoccliente.Name = "lbldoccliente"
        '
        'txtpc
        '
        Me.txtpc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.txtpc, "txtpc")
        Me.txtpc.Name = "txtpc"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'cb14ultrex
        '
        resources.ApplyResources(Me.cb14ultrex, "cb14ultrex")
        Me.cb14ultrex.Name = "cb14ultrex"
        Me.cb14ultrex.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PRESTAMO.My.Resources.Resources.WhatsApp_Image_2020_06_30_at_9_10_04_PM
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Nuevo_Credito
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbvendedor)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtpc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb14ultrex)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Nuevo_Credito"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvpagoss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents checkfecharegistro As CheckBox
    Friend WithEvents cbpagos As ComboBox
    Friend WithEvents cbvendedor As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblsaldo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents txttratado As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpfecharegistro As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnregistrar As Button
    Friend WithEvents txtnumeropagos As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents RibbonCheckBox3 As RibbonCheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtgarantia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtgarante As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtdniruc As TextBox
    Friend WithEvents lblcodigoclientexx As Label
    Friend WithEvents lblnombrecliente As Label
    Friend WithEvents lbldoccliente As Label
    Friend WithEvents RibbonCheckBox2 As RibbonCheckBox
    Friend WithEvents txtpc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cb14ultrex As CheckBox
    Friend WithEvents RibbonCheckBox1 As RibbonCheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvpagoss As DataGridView
    Friend WithEvents CUOTA As DataGridViewTextBoxColumn
    Friend WithEvents FECHA As DataGridViewTextBoxColumn
    Friend WithEvents MONTO As DataGridViewTextBoxColumn
    Friend WithEvents SALDOO As DataGridViewTextBoxColumn
End Class
