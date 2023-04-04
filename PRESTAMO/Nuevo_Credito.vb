Imports System.Data.SqlClient
Imports Capa_Datos
Imports Capa_Entidad
Public Class Nuevo_Credito
    Dim scn As New SqlConnection
    Dim cn As New conexion
    Dim entidad As New entidad_credito
    Dim datos As New datos_credito
    Dim sda As New SqlDataAdapter
    Dim entcli As New entidad_cliente
    Dim datcli As New datos_clientes
    Dim datos_usuarios As New datos_usuario


    Dim entidad_credito_pago As New entidad_creditodetalle
    Dim datos_credito_pago As New datos_creditodetalle

    Public cod_convenio, cod_vendedor, cod_caja As String

    Dim saldo As Decimal = 0
    Sub listar()
        cbvendedor.DataSource = datos_usuarios.listar_usuario.Tables("usuarios")
        cbvendedor.DisplayMember = "NOMBRES"
        cbvendedor.ValueMember = "ID_USUARIO"
    End Sub

    Sub limpiar()
        txtpc.Clear()
        lblcodigoclientexx.Text = ""
        txtdniruc.Clear()
        txtnombre.Clear()
        txtdireccion.Clear()
        fsumar()
    End Sub
    Sub activar()
        txtdniruc.Enabled = True
        'txtdescripcion.Enabled = True
        'txtcant.Enabled = True
        btnregistrar.Enabled = True
    End Sub
    Sub desactivar()
        txtpc.Enabled = False
        txtdniruc.Enabled = False
        'txtdescripcion.Enabled = False
        'txtcant.Enabled = False
        btnregistrar.Enabled = False
    End Sub

    Public Function Validar_check(ckb As CheckBox) As String
        If ckb.Checked = True Then
            Return ckb.Text
        Else
            Return ""
        End If
    End Function

    Sub Registrar_Credito()
        generar_pc()  '''GENERANDO NUEVA PC

        ''''''''''REGISTRANDO EL ORDEN DE PEDIDO'''''''''''''''''''
        entidad.Cr_pccorrelativo = txtpc.Text
        If checkfecharegistro.Checked = True Then
            entidad.Cr_fecha = DateTime.Now
        Else
            entidad.Cr_fecha = dtpfecharegistro.Text
        End If
        entidad.Usu_id = cbvendedor.SelectedValue
        entidad.Cli_id = lblcodigoclientexx.Text
        entidad.Cr_monto = txttratado.Text
        entidad.Cr_interes = ComboBox1.Text
        entidad.Cr_moraTotal = 0
        entidad.Cr_total = lblsaldo.Text
        entidad.Cv_id = 1
        entidad.Vendedor = cbvendedor.SelectedValue 'cod_vendedor
        entidad.Id_caja = 1 'cod_caja
        datos.registrar_credito(entidad)  '''''Registro de Credito

        Dim id_credi As String = datos.Ultimo_credito()
        ''''''''''REGISTRANDO EL PAGO DE LA ORDEN DE TRABAJO
        'entidad_credito_pago.Id_Cr_pccorrelativo = id_credi
        'entidad_credito_pago.Cdd_numero = 0
        'entidad_credito_pago.Cdd_fecha = DateTime.Now
        'entidad_credito_pago.Cdd_fecha_pago = DateTime.Now
        'entidad_credito_pago.tipo_pago = 1 'rbnefectivo.Text
        'entidad_credito_pago.Cdd_abono = 0
        'entidad_credito_pago.Cdd_saldo = lblsaldo.Text
        'entidad_credito_pago.Cdd_estado = 1
        'entidad_credito_pago.Cdd_caja = cod_caja
        'datos_credito_pago.registrar_creditodetalle(entidad_credito_pago)

        For Renglones As Integer = 0 To dgvpagoss.RowCount - 1
            entidad_credito_pago.Id_Cr_pccorrelativo = id_credi
            entidad_credito_pago.Cdd_numero = Me.dgvpagoss.Item(0, Renglones).Value
            entidad_credito_pago.Cdd_fecha = Me.dgvpagoss.Item(1, Renglones).Value
            ''entidad_credito_pago.Cdd_fecha_pago = DateTime.Now
            entidad_credito_pago.tipo_pago = 1
            entidad_credito_pago.Cdd_abono = Me.dgvpagoss.Item(2, Renglones).Value
            entidad_credito_pago.Cdd_saldo = Me.dgvpagoss.Item(3, Renglones).Value
            entidad_credito_pago.Cdd_estado = 0
            entidad_credito_pago.Cdd_caja = 0
            datos_credito_pago.registrar_creditodetalle(entidad_credito_pago)
        Next


        '''''''''Aqui se va hacer el PC del documento''''''''''''''''
        Reporte_Pc_A5.var = id_credi
        Reporte_Pc_A5.NUMERO = "1"
        Reporte_Pc_A5.ShowDialog()

        limpiar()
        Me.Close()
    End Sub

    Sub buscarcliente()
        Try
            scn = cn.conectar
            scn.Open()
            Dim comand As SqlCommand
            comand = New SqlCommand("select top 1 cli_id,cli_razon,cli_direccion from clientes where cli_numero='" + txtdniruc.Text + "'", scn)

            sda = New SqlDataAdapter(comand)
            Dim dt As New DataTable()
            sda.Fill(dt)
            If dt.Rows.Count() > 0 Then
                lblcodigoclientexx.Text = dt.Rows(0)(0).ToString()
                txtnombre.Text = dt.Rows(0)(1).ToString()
                txtdireccion.Text = dt.Rows(0)(2).ToString()
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnlistar_Click(sender As Object, e As EventArgs)
        'If (txtdescripcion.Text <> "" And txtcant.Text <> "") Then
        '    dgvdetalle.Rows.Add(txtcant.Text, txtdescripcion.Text & " " & txtadicional.Text, Val(txtsubtotal.Text) / Val(txtcant.Text), txtsubtotal.Text, procodigo.Text, lblstock.Text, txtadicional.Text, txtprecioadicional.Text)
        '    txtdescripcion.Clear()
        '    txtcant.Clear()
        '    txtdesc.Clear()
        '    txtadicional.Clear()
        '    txtprecioadicional.Clear()
        '    procodigo.Text = "-"
        '    lblprecio.Text = "0"
        '    lblstock.Text = "0"
        '    txtsubtotal.Text = "0"
        '    txtdescripcion.Focus()
        'End If
        fsumar()
    End Sub

    Private Sub txtcant_TextChanged(sender As Object, e As EventArgs)
        CalCularTotal()

    End Sub
    Sub CalCularTotal()
        'If txtcant.Text = "" Then
        '    txtcant.Text = 0
        'End If
        'If txtprecioadicional.Text = "" Then
        '    txtprecioadicional.Text = 0
        'End If
        'If txtdesc.Text = "" Then
        '    txtdesc.Text = 0
        'End If

        'If IsNumeric(txtcant.Text) Then
        '    Try
        '        If Val(txtcant.Text) > Val(lblstock.Text) Then
        '            ''MsgBox("Stock limitado", MsgBoxStyle.Information, Title:="MENSAJE")
        '            txtsubtotal.Text = Val(txtcant.Text * lblprecio.Text) - Val(txtdesc.Text)
        '            txtcant.Focus()
        '        Else
        '            If txtcant.Text = "" Then
        '                txtsubtotal.Text = "0"
        '            Else
        '                txtsubtotal.Text = Val((txtcant.Text * lblprecio.Text) + txtprecioadicional.Text) - Val(txtdesc.Text)
        '            End If
        '        End If
        '    Catch ex As Exception

        '    End Try
        'End If
    End Sub

    Sub fsumar()
        'Dim total As Double = 0
        'For Each fila As DataGridViewRow In dgvdetalle.Rows
        '    If fila.Cells(3).Value Is Nothing Then
        '        Exit Sub
        '    Else
        '        total += Convert.ToDouble(fila.Cells(3).Value)
        '    End If
        'Next
        'txttratado.Text = Format(total, "#,##0.00")
    End Sub

    Private Sub Nuevo_Credito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkfecharegistro.Checked = True
        dtpfecharegistro.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        dtpfecharegistro.Format = DateTimePickerFormat.Custom

        limpiar()
        listar()
        generar_pc()
        ComboBox1.Text = "10"


        dgvpagoss.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvpagoss.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvpagoss.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        dgvpagoss.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable

    End Sub


    Sub generar_pc()
        Try
            Dim r As String
            r = "000000"
            Dim num As Integer = datos.generarcredito(cod_vendedor)
            txtpc.Text = r & num

            If num > 9 Then
                r = "00000"
                txtpc.Text = r & num
            End If
            If num > 99 Then
                r = "0000"
                txtpc.Text = r & num
            End If
            If num > 999 Then
                r = "000"
                txtpc.Text = r & num
            End If
            If num > 9999 Then
                r = "00"
                txtpc.Text = r & num
            End If
            If num > 99999 Then
                r = "0"
                txtpc.Text = r & num
            End If
            If num > 999999 Then
                txtpc.Text = num
            End If
            If num > 9999999 Then
                MsgBox("Registros Llenos", Title:="Llame al programador")
            End If
        Catch ex As Exception
            MsgBox("LLAMA AL PROGRAMADOR")
        End Try
        activar()
    End Sub


    Private Sub txtdniruc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdniruc.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                buscarcliente(txtdniruc.Text)
        End Select
    End Sub

    Sub buscarcliente(dni_cliente As String)
        Try
            scn = cn.conectar
            scn.Open()
            Dim comand As SqlCommand
            If dni_cliente = "" Then
                MsgBox("Seleccione un cliente", MsgBoxStyle.Information, Title:="Mensaje")
            Else
                comand = New SqlCommand("select cli_id, cli_razon, cli_direccion,nombre, garantia from clientes where cli_numero='" & dni_cliente & "'", scn)

                sda = New SqlDataAdapter(comand)
                Dim dt As New DataTable()

                sda.Fill(dt)

                If dt.Rows.Count() > 0 Then
                    lblcodigoclientexx.Text = dt.Rows(0)(0).ToString()
                    txtnombre.Text = dt.Rows(0)(1).ToString()
                    txtdireccion.Text = dt.Rows(0)(2).ToString()

                    txtgarante.Text = dt.Rows(0)(3).ToString()
                    txtgarantia.Text = dt.Rows(0)(4).ToString()
                Else
                    lblcodigoclientexx.Text = ""
                    txtnombre.Text = ""
                    txtdireccion.Text = ""
                    txtgarante.Text = ""
                    txtgarantia.Text = ""
                    MsgBox("Cliente no encontrado!", MsgBoxStyle.Critical, Title:="Mensaje")
                End If

            End If
        Catch ex As Exception
            Throw ex
        Finally
            scn.Close()
        End Try
    End Sub

    Private Sub cbpagos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbpagos.SelectedIndexChanged
        Dim fecha_actual As Date = DateTime.Now
        Dim diasAdicionados As Integer = 0
        dgvpagoss.Rows.Clear()
        txtnumeropagos.Enabled = True
        If cbpagos.Text = "MENSUAL" Then
            txtnumeropagos.Text = 1
        End If
        If IsNumeric(txtnumeropagos.Text) And cbpagos.Text <> "" Then
            Select Case cbpagos.Text
                Case "DIARIO"
                    Dim monto As String = lblsaldo.Text / txtnumeropagos.Text
                    Dim restante As Decimal = lblsaldo.Text - monto
                    For i As Integer = 1 To txtnumeropagos.Text
                        Dim fecha As Date = fecha_actual.AddDays(i + diasAdicionados)

                        If fecha.DayOfWeek = DayOfWeek.Sunday Then
                            fecha = fecha_actual.AddDays(i + diasAdicionados + 1)
                            diasAdicionados = diasAdicionados + 1
                        End If

                        dgvpagoss.Rows.Add(i, Format(fecha, "dd/MM/yyyy"), Math.Round(Convert.ToDecimal(monto), 1), Math.Round(Convert.ToDecimal(restante), 1))
                        restante = restante - monto
                    Next
                Case "MENSUAL"
                    txtnumeropagos.Text = "1"
                    txtnumeropagos.Enabled = False
                    Dim monto As String = lblsaldo.Text / 1
                    Dim restante As Decimal = lblsaldo.Text - monto
                    For i As Integer = 1 To txtnumeropagos.Text
                        Dim fecha As Date = fecha_actual.AddMonths(i)
                        dgvpagoss.Rows.Add(i, Format(fecha, "dd/MM/yyyy"), Math.Round(Convert.ToDecimal(monto), 1), Math.Round(Convert.ToDecimal(restante), 1))
                        restante = restante - monto
                    Next

                Case Else

            End Select

            Dim diferecia As Decimal = lblsaldo.Text - fsumar1()

            For Renglones As Integer = 0 To dgvpagoss.RowCount - 1
                If Renglones = dgvpagoss.RowCount - 1 Then
                    Me.dgvpagoss.Item(2, Renglones).Value = Convert.ToDecimal(Me.dgvpagoss.Item(2, Renglones).Value) + diferecia
                    Me.dgvpagoss.Item(3, Renglones).Value = 0
                End If
            Next

        End If
    End Sub
    Public Function fsumar1() As Decimal
        Dim total As Double = 0
        For Each fila As DataGridViewRow In dgvpagoss.Rows
            If fila.Cells(2).Value Is Nothing Then
                Return 0
            Else
                total += Convert.ToDouble(fila.Cells(2).Value)
            End If
        Next
        'dgvpagos.Text = Format(total, "#,##0.00")
        Return total
    End Function

    Private Sub lblsaldo_TextChanged(sender As Object, e As EventArgs) Handles lblsaldo.TextChanged
        saldo = lblsaldo.Text
        dgvpagoss.Rows.Clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If IsNumeric(txttratado.Text) Then
            Select Case ComboBox1.Text
                Case "10"
                    lblsaldo.Text = txttratado.Text + (txttratado.Text * 0.1)
                'Case "15"
                '    lblsaldo.Text = txttratado.Text + (txttratado.Text * 0.15)
                Case "20"
                    lblsaldo.Text = txttratado.Text + (txttratado.Text * 0.2)
            End Select
        End If
    End Sub


    Private Sub btnregistrar_Click_1(sender As Object, e As EventArgs) Handles btnregistrar.Click
        If lblnombrecliente.Text.Trim = "" Or lblcodigoclientexx.Text.Length = 0 Then
            MsgBox("Termina de Llenar los campos!", Title:="Mensaje")
        Else
            If Convert.ToDecimal(lblsaldo.Text) > 0 And dgvpagoss.Rows.Count <> 0 Then
                Registrar_Credito()
            End If
        End If
        ''Detalle_Credito.listar()
    End Sub

    Private Sub txtdniruc_TextChanged(sender As Object, e As EventArgs) Handles txtdniruc.TextChanged

    End Sub

    Private Sub txttratado_TextChanged(sender As Object, e As EventArgs) Handles txttratado.TextChanged
        If IsNumeric(txttratado.Text) Then
            Select Case ComboBox1.Text
                Case "10"
                    lblsaldo.Text = txttratado.Text + (txttratado.Text * 0.1)
                'Case "15"
                '    lblsaldo.Text = txttratado.Text + (txttratado.Text * 0.15)
                Case "20"
                    lblsaldo.Text = txttratado.Text + (txttratado.Text * 0.2)
            End Select
        End If
    End Sub

    Private Sub cbpagos_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbpagos.SelectedValueChanged
        Dim fecha_actual As Date = DateTime.Now
        dgvpagoss.Rows.Clear()
        txtnumeropagos.Enabled = True
        If cbpagos.Text = "MENSUAL" Then
            txtnumeropagos.Text = 1
        End If
        If IsNumeric(txtnumeropagos.Text) And cbpagos.Text <> "" Then
            Select Case cbpagos.Text
                Case "DIARIO"
                    Dim monto As String = lblsaldo.Text / txtnumeropagos.Text
                    Dim restante As Decimal = lblsaldo.Text - monto
                    For i As Integer = 1 To txtnumeropagos.Text
                        Dim fecha As Date = fecha_actual.AddDays(i)
                        dgvpagoss.Rows.Add(i, Format(fecha, "dd/MM/yyyy"), Math.Round(Convert.ToDecimal(monto), 1), Math.Round(Convert.ToDecimal(restante), 1))
                        restante = restante - monto
                    Next
                Case "MENSUAL"
                    txtnumeropagos.Text = "1"
                    txtnumeropagos.Enabled = False
                    Dim monto As String = lblsaldo.Text / 1
                    Dim restante As Decimal = lblsaldo.Text - monto
                    For i As Integer = 1 To txtnumeropagos.Text
                        Dim fecha As Date = fecha_actual.AddMonths(i)
                        dgvpagoss.Rows.Add(i, Format(fecha, "dd/MM/yyyy"), Math.Round(Convert.ToDecimal(monto), 1), Math.Round(Convert.ToDecimal(restante), 1))
                        restante = restante - monto
                    Next

                Case Else

            End Select

            Dim diferecia As Decimal = lblsaldo.Text - fsumar1()

            For Renglones As Integer = 0 To dgvpagoss.RowCount - 1
                If Renglones = dgvpagoss.RowCount - 1 Then
                    Me.dgvpagoss.Item(2, Renglones).Value = Convert.ToDecimal(Me.dgvpagoss.Item(2, Renglones).Value) + diferecia
                    Me.dgvpagoss.Item(3, Renglones).Value = 0
                End If
            Next

        End If

    End Sub

    Private Sub cbpagos_TextChanged(sender As Object, e As EventArgs) Handles cbpagos.TextChanged
        Dim fecha_actual As Date = DateTime.Now
        dgvpagoss.Rows.Clear()
        txtnumeropagos.Enabled = True
        If cbpagos.Text = "MENSUAL" Then
            txtnumeropagos.Text = 1
        End If
        If IsNumeric(txtnumeropagos.Text) And cbpagos.Text <> "" Then
            Select Case cbpagos.Text
                Case "DIARIO"
                    Dim monto As String = lblsaldo.Text / txtnumeropagos.Text
                    Dim restante As Decimal = lblsaldo.Text - monto
                    For i As Integer = 1 To txtnumeropagos.Text
                        Dim fecha As Date = fecha_actual.AddDays(i)
                        dgvpagoss.Rows.Add(i, Format(fecha, "dd/MM/yyyy"), Math.Round(Convert.ToDecimal(monto), 1), Math.Round(Convert.ToDecimal(restante), 1))
                        restante = restante - monto
                    Next
                Case "MENSUAL"
                    txtnumeropagos.Text = "1"
                    txtnumeropagos.Enabled = False
                    Dim monto As String = lblsaldo.Text / 1
                    Dim restante As Decimal = lblsaldo.Text - monto
                    For i As Integer = 1 To txtnumeropagos.Text
                        Dim fecha As Date = fecha_actual.AddMonths(i)
                        dgvpagoss.Rows.Add(i, Format(fecha, "dd/MM/yyyy"), Math.Round(Convert.ToDecimal(monto), 1), Math.Round(Convert.ToDecimal(restante), 1))
                        restante = restante - monto
                    Next

                Case Else

            End Select

            Dim diferecia As Decimal = lblsaldo.Text - fsumar1()

            For Renglones As Integer = 0 To dgvpagoss.RowCount - 1
                If Renglones = dgvpagoss.RowCount - 1 Then
                    Me.dgvpagoss.Item(2, Renglones).Value = Convert.ToDecimal(Me.dgvpagoss.Item(2, Renglones).Value) + diferecia
                    Me.dgvpagoss.Item(3, Renglones).Value = 0
                End If
            Next

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim asd As New Clientes
        asd.ShowDialog()
        txtdniruc.Text = asd.numero
        lblcodigoclientexx.Text = asd.cod
        txtdireccion.Text = asd.direccion
        txtnombre.Text = asd.nombres

        txtgarante.Text = asd.garante
        txtgarantia.Text = asd.garantia
    End Sub

    Private Sub checkfecharegistro_CheckedChanged(sender As Object, e As EventArgs) Handles checkfecharegistro.CheckedChanged
        If checkfecharegistro.Checked = True Then
            dtpfecharegistro.Visible = False
        Else
            dtpfecharegistro.Visible = True
        End If
    End Sub
End Class
