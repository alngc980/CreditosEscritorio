Imports System.Data.SqlClient
Imports Capa_Datos
Imports Capa_Entidad
Public Class Reporte_Credito
    Dim scn As New SqlConnection
    Dim cn As New conexion
    Dim entidad As New entidad_creditodetalle
    Dim datos As New datos_creditodetalle
    Dim sda As New SqlDataAdapter

    Public idcaja As String
    Public interes As String

    Private Sub lblid_TextChanged(sender As Object, e As EventArgs) Handles lblid.TextChanged
        If IsNumeric(lblid.Text) Then
            Listar_estado_cuenta()

            'Dim repor As New rptPC
            'repor.SetParameterValue("@cr_pccorrelativo", lblid.Text)
            'CrystalReportViewer1.ReportSource = repor

            Dim Report As New ReportesBD()
            Report.MostrarReporte("rptPC.rpt", "@cr_pccorrelativo", lblid.Text, "", "", "", "", "", "", "", "")
            Me.CrystalReportViewer1.Refresh()
            Me.CrystalReportViewer1.ReportSource = Report.informe
        End If
    End Sub

    Private Sub btnpagar_Click(sender As Object, e As EventArgs) Handles btnpagar.Click
        Try
            Dim HayPagos As Boolean = False
            If dgvpagos.Rows.Count > 0 Then
                ''AVERIGUAR EL ULTIMO PAGO REALIZADO    (( CARGADO EN LAS SIGUIENTES VARIABLES ))
                Dim id As String = ""
                Dim numero As String = ""
                Dim fecha As String = ""
                Dim monto As String = ""
                Dim restante As String = ""
                Dim estado As String = ""

                For Renglones As Integer = 0 To dgvpagos.RowCount - 1
                    If dgvpagos.Item(5, Renglones).Value = "PAGADO" Then
                        id = dgvpagos.Item(0, Renglones).Value
                        numero = dgvpagos.Item(1, Renglones).Value
                        fecha = dgvpagos.Item(2, Renglones).Value
                        monto = dgvpagos.Item(3, Renglones).Value
                        restante = dgvpagos.Item(4, Renglones).Value
                        estado = dgvpagos.Item(5, Renglones).Value
                        HayPagos = True
                    End If
                Next ''HASTA AQUI YA TENGO EL ULTIMO PAGO REALIZADO        


                ''AVERIGUAR EN LA LISTA PAGOS POR REALIZAR    (( CARGADO EN LAS SIGUIENTES VARIABLES ))
                Dim idP As String = ""
                Dim numeroP As String = ""
                Dim fechaP As String = ""
                Dim montoP As String = ""
                Dim restanteP As String = ""
                Dim estadoP As String = ""
                If HayPagos Then
                    If restante > 0 Then  ''SI EL ULTIMO PAGO REALIZADO TIENE SALDO RESTANTE
                        Dim encontrado As String = "FALSE"
                        For Renglones As Integer = 0 To dgvpagos.RowCount - 1
                            If dgvpagos.Item(5, Renglones).Value = "-" And encontrado = "FALSE" Then
                                idP = dgvpagos.Item(0, Renglones).Value
                                numeroP = dgvpagos.Item(1, Renglones).Value
                                fechaP = dgvpagos.Item(2, Renglones).Value
                                montoP = dgvpagos.Item(3, Renglones).Value
                                restanteP = dgvpagos.Item(4, Renglones).Value
                                estadoP = dgvpagos.Item(5, Renglones).Value
                                encontrado = "TRUE"
                            End If
                        Next
                    End If ''HASTA AQUI YA TENGO EL SIGIENTE PAGO POR REALIZAR
                Else
                    Dim encontrado As String = "FALSE"
                    For Renglones As Integer = 0 To dgvpagos.RowCount - 1
                        If dgvpagos.Item(5, Renglones).Value = "-" And encontrado = "FALSE" Then
                            idP = dgvpagos.Item(0, Renglones).Value
                            numeroP = dgvpagos.Item(1, Renglones).Value
                            fechaP = dgvpagos.Item(2, Renglones).Value
                            montoP = dgvpagos.Item(3, Renglones).Value
                            restanteP = dgvpagos.Item(4, Renglones).Value
                            estadoP = dgvpagos.Item(5, Renglones).Value
                            encontrado = "TRUE"
                        End If
                    Next
                End If


                ''AVERIGUAR EN LA LISTA EL SIGUIENTE PAGO DESPUES DE LA PRIMERA    (( CARGADO EN LAS SIGUIENTES VARIABLES ))
                Dim idP2 As String = ""
                Dim numeroP2 As String = ""
                Dim fechaP2 As String = ""
                Dim montoP2 As String = ""
                Dim restanteP2 As String = ""
                Dim estadoP2 As String = ""
                If HayPagos Then
                    If restante > 0 Then  ''SI EL ULTIMO PAGO REALIZADO TIENE SALDO RESTANTE
                        Dim encontrado2 As Integer = 0
                        For Renglones As Integer = 0 To dgvpagos.RowCount - 1

                            If encontrado2 = 1 Then
                                idP2 = dgvpagos.Item(0, Renglones).Value
                                numeroP2 = dgvpagos.Item(1, Renglones).Value
                                fechaP2 = dgvpagos.Item(2, Renglones).Value
                                montoP2 = dgvpagos.Item(3, Renglones).Value
                                restanteP2 = dgvpagos.Item(4, Renglones).Value
                                estadoP2 = dgvpagos.Item(5, Renglones).Value
                                encontrado2 = 2
                            End If

                            If Convert.ToString(dgvpagos.Item(0, Renglones).Value) = idP And encontrado2 = 0 Then
                                encontrado2 = 1
                            End If
                        Next
                    End If ''HASTA AQUI YA TENGO EL SIGIENTE PAGO POR REALIZAR despues del primero
                Else
                    Dim encontrado2 As Integer = 0
                    For Renglones As Integer = 0 To dgvpagos.RowCount - 1

                        If encontrado2 = 1 Then
                            idP2 = dgvpagos.Item(0, Renglones).Value
                            numeroP2 = dgvpagos.Item(1, Renglones).Value
                            fechaP2 = dgvpagos.Item(2, Renglones).Value
                            montoP2 = dgvpagos.Item(3, Renglones).Value
                            restanteP2 = dgvpagos.Item(4, Renglones).Value
                            estadoP2 = dgvpagos.Item(5, Renglones).Value
                            encontrado2 = 2
                        End If

                        If Convert.ToString(dgvpagos.Item(0, Renglones).Value) = idP And encontrado2 = 0 Then
                            encontrado2 = 1
                        End If
                    Next
                End If


                If HayPagos Then
                    If restante > 0 Then  '' SI EL MONTO RESTANTE ES MAS MAYOR A CERO 0
                        If idP <> "" Then  ''SI HAY UN SIGUIENTE PAGO PROGRAMADO DESPUES DEL ULTIMO PAGO REALIZADO
                            Dim pagar As New Pagar_credito

                            pagar.monto = lbldineroprestado.Text
                            pagar.interess = interes

                            pagar.cod_caja = idcaja
                            pagar.id_credi = lblid.Text
                            pagar.txtid.Text = idP
                            pagar.txtnumero.Text = numeroP
                            pagar.txtfecha.Text = fechaP
                            pagar.txtmonto.Text = montoP
                            pagar.txtrestante.Text = restanteP
                            pagar.txtnombre.Text = lblnombrecliente.Text
                            pagar.lbid.Text = idP2
                            pagar.lbnumero.Text = numeroP2
                            pagar.lbfecha.Text = fechaP2
                            pagar.lbmonto.Text = montoP2
                            pagar.lbrestante.Text = restanteP2

                            pagar.ShowDialog()
                            Listar_estado_cuenta()
                        Else
                            'Dim pagar As New Pagar_credito2
                            'pagar.cod_caja = idcaja
                            'pagar.id_credi = lblid.Text
                            'pagar.txtmontorestante.Text = restante
                            'pagar.txtnumero.Text = Convert.ToInt32(numero) + 1
                            'pagar.txtfecha.Text = DateTime.Now
                            'pagar.txtmonto.Text = ""
                            'pagar.txtrestante.Text = ""
                            'pagar.ShowDialog()
                            Listar_estado_cuenta()
                        End If

                    Else
                        MsgBox("EL PRESTAMO YA FUE PAGADO TOTALMENTE!", MsgBoxStyle.Information, Title:="MENSAJE")
                    End If
                Else
                    If idP <> "" Then  ''SI HAY UN SIGUIENTE PAGO PROGRAMADO DESPUES DEL ULTIMO PAGO REALIZADO
                        Dim pagar As New Pagar_credito
                        pagar.monto = lbldineroprestado.Text
                        pagar.interess = interes

                        pagar.cod_caja = idcaja
                        pagar.id_credi = lblid.Text
                        pagar.txtid.Text = idP
                        pagar.txtnumero.Text = numeroP
                        pagar.txtfecha.Text = fechaP
                        pagar.txtmonto.Text = montoP
                        pagar.txtrestante.Text = restanteP
                        pagar.txtnombre.Text = lblnombrecliente.Text
                        pagar.lbid.Text = idP2
                        pagar.lbnumero.Text = numeroP2
                        pagar.lbfecha.Text = fechaP2
                        pagar.lbmonto.Text = montoP2
                        pagar.lbrestante.Text = restanteP2



                        pagar.ShowDialog()
                        Listar_estado_cuenta()
                    Else
                        'Dim pagar As New Pagar_credito2
                        'pagar.cod_caja = idcaja
                        'pagar.id_credi = lblid.Text
                        'pagar.txtmontorestante.Text = restante
                        'pagar.txtnumero.Text = Convert.ToInt32(numero) + 1
                        'pagar.txtfecha.Text = DateTime.Now
                        'pagar.txtmonto.Text = ""
                        'pagar.txtrestante.Text = ""
                        'pagar.ShowDialog()
                        Listar_estado_cuenta()
                    End If
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub Listar_estado_cuenta()
        datos.listar_estadocuenta(lblid.Text, dgvpagos)
        dgvpagos.Columns(0).Visible = False
        dgvpagos.Columns(1).Width = 40
        dgvpagos.Columns(2).Width = 80
        dgvpagos.Columns(3).Width = 80
        dgvpagos.Columns(4).Width = 80
        dgvpagos.Columns(5).Width = 100
        dgvpagos.Columns(6).Width = 50
        dgvpagos.Columns(7).Width = 100
    End Sub

    Dim dcredito As New datos_credito
    Private Sub BTNANULAR_Click(sender As Object, e As EventArgs) Handles BTNANULAR.Click
        If MsgBox("¿Estas seguro que desea anular este credito y los pagos?", vbYesNo, Title:="MENSAJE") = MsgBoxResult.Yes Then
            If dcredito.Anular_Credito(lblid.Text) = True Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        Try
            Dim reporte As New Reporte_Pc_A5
            reporte.var = (dgvpagos.Rows(dgvpagos.CurrentRow.Index).Cells(0).Value).ToString
            reporte.NUMERO = 2
            reporte.ShowDialog()

            'Dim Report1 As New ReportesBD()
            'Report1.MostrarReporte("Reporte_Pc_A5.rpt", "@cr_pccorrelativo", lblid.Text, "", "", "", "", "", "", "", "")
            'Report1.informe.PrintOptions.PrinterName = "CAJA"
            'Report1.informe.PrintToPrinter(1, True, 0, 0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Reporte_Credito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Dim repor As New rptPC
            'repor.SetParameterValue("@cr_pccorrelativo", lblid.Text)
            'repor.PrintOptions.PrinterName = "CAJA"
            'repor.PrintToPrinter(1, True, 0, 0)

            Dim Report1 As New ReportesBD()
            Report1.MostrarReporte("rptPC.rpt", "@cr_pccorrelativo", lblid.Text, "", "", "", "", "", "", "", "")
            Report1.informe.PrintOptions.PrinterName = "CAJA"
            Report1.informe.PrintToPrinter(1, True, 0, 0)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnmontolibre_Click(sender As Object, e As EventArgs) Handles btnmontolibre.Click
        Dim mas As New MontoLibre
        mas.credito = lblid.Text
        mas.ShowDialog()

        If mas.EJEC Then
            Listar_estado_cuenta()


            'Dim repor As New rptPC
            'repor.SetParameterValue("@cr_pccorrelativo", lblid.Text)
            'CrystalReportViewer1.ReportSource = repor

            Dim Report As New ReportesBD()
            Report.MostrarReporte("rptPC.rpt", "@cr_pccorrelativo", lblid.Text, "", "", "", "", "", "", "", "")
            Me.CrystalReportViewer1.Refresh()
            Me.CrystalReportViewer1.ReportSource = Report.informe
        End If
    End Sub
End Class