Imports System.Data.SqlClient
Imports Capa_Datos
Imports Capa_Entidad
Public Class Pagar_credito
    Dim entidad_credito_pago As New entidad_creditodetalle
    Dim datos_credito_pago As New datos_creditodetalle

    Public id_credi, cod_caja As String

    Public monto, interess As String


    Sub CargarSgtPago()
        If Convert.ToDecimal(lblmontofaltante.Text) > 0 Then
            entidad_credito_pago.Cdd_id = lbid.Text
            'entidad_credito_pago.Id_Cr_pccorrelativo = id_credi
            'entidad_credito_pago.Cdd_numero = txtnumero.Text
            'entidad_credito_pago.Cdd_fecha = DateTime.Now
            entidad_credito_pago.tipo_pago = "EFECTIVO"
            entidad_credito_pago.Cdd_abono = Convert.ToDecimal(lbmonto.Text) + Convert.ToDecimal(lblmontofaltante.Text)
            entidad_credito_pago.Cdd_saldo = lbrestante.Text
            entidad_credito_pago.Cdd_estado = 0
            entidad_credito_pago.Cdd_caja = 0
            datos_credito_pago.actualizar_credito_detalle(entidad_credito_pago)
        End If
    End Sub
    Sub CREARSgtPago()
        If Convert.ToDecimal(lblmontofaltante.Text) > 0 Then
            'entidad_credito_pago.Cdd_id = lbid.Text
            entidad_credito_pago.Id_Cr_pccorrelativo = id_credi
            entidad_credito_pago.Cdd_numero = Convert.ToDecimal(txtnumero.Text) + 1
            entidad_credito_pago.Cdd_fecha = DateTime.Now.AddDays(1)
            'entidad_credito_pago.Cdd_fecha_pago = ""
            entidad_credito_pago.tipo_pago = "0"
            entidad_credito_pago.Cdd_abono = lblmontofaltante.Text
            entidad_credito_pago.Cdd_saldo = 0
            entidad_credito_pago.Cdd_estado = 0
            entidad_credito_pago.Cdd_caja = 0
            datos_credito_pago.registrar_creditodetalle(entidad_credito_pago)
        End If
    End Sub


    Sub calcularMora()
        If IsDate(txtfecha.Text) Then
            If CDate(txtfecha.Text) < System.DateTime.Now.Date Then

                Select Case Convert.ToDecimal(monto)
                    Case 100
                        txtmora.Text = "1.00"
                    Case 150
                        txtmora.Text = "1.50"
                    Case 200
                        txtmora.Text = "2.00"
                    Case Else
                        txtmora.Text = "0.00"
                End Select

            Else
                txtmora.Text = "0.00"
            End If
        End If

        If CheckBox1.Checked = True Then
            If IsNumeric(txtmonto2.Text) Then
                lbltotal.Text = Convert.ToDecimal(txtmonto2.Text) + Convert.ToDecimal(txtmora.Text)
            End If
        Else
            If IsNumeric(txtmonto.Text) Then
                lbltotal.Text = Convert.ToDecimal(txtmonto.Text) + Convert.ToDecimal(txtmora.Text)
            End If
        End If

    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = False Then
            entidad_credito_pago.Cdd_id = txtid.Text
            entidad_credito_pago.Cdd_fecha_pago = DateTime.Now

            entidad_credito_pago.tipo_pago = "EFECTIVO"

            entidad_credito_pago.Cdd_abono = txtmonto.Text
            entidad_credito_pago.Cdd_saldo = txtrestante.Text
            entidad_credito_pago.Cdd_mora = txtmora.Text
            entidad_credito_pago.Cdd_estado = 1
            entidad_credito_pago.Cdd_caja = cod_caja
            datos_credito_pago.actualizar_credito_detalle(entidad_credito_pago)
            Me.Close()
        Else
            If txtmonto2.Text <> "" And txtrestante2.Text <> "" Then
                If IsNumeric(txtmonto2.Text) And IsNumeric(txtrestante2.Text) Then
                    entidad_credito_pago.Cdd_id = txtid.Text
                    entidad_credito_pago.Cdd_fecha_pago = DateTime.Now

                    entidad_credito_pago.tipo_pago = "EFECTIVO"

                    entidad_credito_pago.Cdd_abono = txtmonto2.Text
                    entidad_credito_pago.Cdd_saldo = txtrestante2.Text
                    entidad_credito_pago.Cdd_mora = txtmora.Text
                    entidad_credito_pago.Cdd_estado = 1
                    entidad_credito_pago.Cdd_caja = cod_caja
                    datos_credito_pago.actualizar_credito_detalle(entidad_credito_pago)

                    If lbid.Text <> "" Then
                        CargarSgtPago()
                    Else
                        CREARSgtPago()
                    End If

                    Me.Close()
                End If
            Else
                MsgBox("LLENAR LOS CAMPOS", MsgBoxStyle.Critical, Title:="MENSAJE")
            End If
        End If
        Dim REPORT As New Reporte_Pc_A5
        REPORT.NUMERO = "2"
        REPORT.var = txtid.Text
        REPORT.ShowDialog()
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtmonto2.Enabled = True
            txtmonto2.Clear()
            lblmontofaltante.Text = "0"
            txtrestante2.Clear()
            txtmonto2.Focus()

            lbltotal.Text = "0.00"
        Else
            txtmonto2.Enabled = False
            txtmonto2.Clear()
            lblmontofaltante.Text = "0"
            txtrestante2.Clear()
            Button1.Focus()

            lbltotal.Text = Convert.ToDecimal(txtmonto.Text) + Convert.ToDecimal(txtmora.Text)
        End If
    End Sub

    Private Sub txtfecha_TextChanged_1(sender As Object, e As EventArgs) Handles txtfecha.TextChanged
        calcularMora()
    End Sub

    Private Sub chekmora_CheckedChanged_1(sender As Object, e As EventArgs) Handles chekmora.CheckedChanged
        If chekmora.Checked = True Then
            calcularMora()
        Else

            txtmora.Text = "0.00"
            If CheckBox1.Checked = True Then
                If IsNumeric(txtmonto2.Text) Then
                    lbltotal.Text = Convert.ToDecimal(txtmonto2.Text) + Convert.ToDecimal(txtmora.Text)
                End If
            Else
                If IsNumeric(txtmonto.Text) Then
                    lbltotal.Text = Convert.ToDecimal(txtmonto.Text) + Convert.ToDecimal(txtmora.Text)
                End If
            End If

        End If
    End Sub

    Private Sub txtmonto_TextChanged_1(sender As Object, e As EventArgs) Handles txtmonto.TextChanged
        calcularMora()
    End Sub

    Private Sub lblmontofaltante_TextChanged_1(sender As Object, e As EventArgs) Handles lblmontofaltante.TextChanged
        Try
            If IsNumeric(lblmontofaltante.Text) Then
                txtrestante2.Text = Convert.ToDecimal(txtrestante.Text) + Convert.ToDecimal(lblmontofaltante.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtmonto2_TextChanged_1(sender As Object, e As EventArgs) Handles txtmonto2.TextChanged
        Try
            If IsNumeric(txtmonto2.Text) Then
                If Convert.ToDecimal(txtmonto2.Text) > Convert.ToDecimal(txtmonto.Text) Then
                    MsgBox("EL MONTO A PAGAR NO PUEDE SER SUPERIOR AL PROGRAMADO!", MsgBoxStyle.Critical, Title:="MENSAJE")
                    txtmonto2.Clear()
                    lblmontofaltante.Text = "0"
                    txtrestante2.Clear()
                    txtmonto2.Focus()
                Else

                    lblmontofaltante.Text = txtmonto.Text - txtmonto2.Text

                    lbltotal.Text = Convert.ToDecimal(txtmonto2.Text) + Convert.ToDecimal(txtmora.Text)
                End If

            Else
                lbltotal.Text = "0.00"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Pagar_credito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class