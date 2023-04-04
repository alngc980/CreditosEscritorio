Public Class Reporte_Pc_A5
    Public var As String
    Public NUMERO As String

    Public fec1, fec2 As Date
    Private Sub Reporte_Pc_A5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor = Cursors.WaitCursor

        Select Case NUMERO
            Case "1"
                Me.Text = "REPORTE DE CRONOGRAMA DE PAGOS"

                Dim Report As New ReportesBD()
                Report.MostrarReporte("rptPC.rpt", "@cr_pccorrelativo", var, "", "", "", "", "", "", "", "")
                Me.CrystalReportViewer1.Refresh()
                Me.CrystalReportViewer1.ReportSource = Report.informe

                'Dim repor As New rptPC
                'repor.SetParameterValue("@cr_pccorrelativo", var)
                'CrystalReportViewer1.ReportSource = repor
            Case "2"
                Me.Text = "REPORTE DE PAGO"

                Dim Report As New ReportesBD()
                Report.MostrarReporte("rpt_pagodecredito.rpt", "@var", var, "", "", "", "", "", "", "", "")
                Me.CrystalReportViewer1.Refresh()
                Me.CrystalReportViewer1.ReportSource = Report.informe

                'Dim repor As New rpt_pagodecredito
                'repor.SetParameterValue("@var", var)
                'CrystalReportViewer1.ReportSource = repor
            Case "3"
                Me.Text = "REPORTE DE CLIENTES"

                Dim Report As New ReportesBD()
                Report.MostrarReporte("rpt_clientes.rpt", "", "", "", "", "", "", "", "", "", "")
                Me.CrystalReportViewer1.Refresh()
                Me.CrystalReportViewer1.ReportSource = Report.informe

                'Dim repor As New rpt_clientes
                'CrystalReportViewer1.ReportSource = repor
            Case "4"
                Me.Text = "REPORTE DE CLIENTES AL DIA"

                Dim Report As New ReportesBD()
                Report.MostrarReporte("rpt_CreditosAlDia.rpt", "", "", "", "", "", "", "", "", "", "")
                Me.CrystalReportViewer1.Refresh()
                Me.CrystalReportViewer1.ReportSource = Report.informe

                'Dim repor As New rpt_CreditosAlDia
                'CrystalReportViewer1.ReportSource = repor
            Case "5"
                Me.Text = "REPORTE DE CLIENTES EN MORA"

                Dim Report As New ReportesBD()
                Report.MostrarReporte("rpt_creditosMorosos.rpt", "", "", "", "", "", "", "", "", "", "")
                Me.CrystalReportViewer1.Refresh()
                Me.CrystalReportViewer1.ReportSource = Report.informe

                'Dim repor As New rpt_creditosMorosos
                'CrystalReportViewer1.ReportSource = repor
            Case "09"
                Me.Text = "REPORTE DE PAGOS"

                Dim Report As New ReportesBD()
                Report.MostrarReporte("rpt_pagos_ingresos.rpt", "@fecha1", fec1, "@fecha2", fec2, "", "", "", "", "", "")
                Me.CrystalReportViewer1.Refresh()
                Me.CrystalReportViewer1.ReportSource = Report.informe

                'Dim repor As New rpt_pagos_ingresos
                'repor.SetParameterValue("@fecha1", fec1)
                'repor.SetParameterValue("@fecha2", fec2)
                'CrystalReportViewer1.ReportSource = repor
            Case "10"
                Me.Text = "TICKET DE GIRO"

                Dim Report As New ReportesBD()
                Report.MostrarReporte("rpt_giro_detalle.rpt", "@id", var, "", "", "", "", "", "", "", "")
                Me.CrystalReportViewer1.Refresh()
                Me.CrystalReportViewer1.ReportSource = Report.informe

                'Dim repor As New rpt_giro_detalle
                'repor.SetParameterValue("@id", var)
                'CrystalReportViewer1.ReportSource = repor
            Case "11"
                Me.Text = "REPORTE DE GIROS"

                Dim Report As New ReportesBD()
                Report.MostrarReporte("rpt_giro.rpt", "@fecha1", fec1, "@fecha2", fec2, "", "", "", "", "", "")
                Me.CrystalReportViewer1.Refresh()
                Me.CrystalReportViewer1.ReportSource = Report.informe

                'Dim repor As New rpt_giro
                'repor.SetParameterValue("@fecha1", fec1)
                'repor.SetParameterValue("@fecha2", fec2)
                'CrystalReportViewer1.ReportSource = repor
        End Select

        Cursor = Cursors.Default
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case NUMERO
            Case "1"
                Me.Text = "REPORTE DE CRONOGRAMA DE PAGOS"
                'Dim repor As New rptPC
                'repor.SetParameterValue("@cr_pccorrelativo", var)
                'repor.PrintOptions.PrinterName = "CAJA"
                'repor.PrintToPrinter(2, True, 0, 0)

                Dim Report1 As New ReportesBD()
                Report1.MostrarReporte("rptPC.rpt", "@cr_pccorrelativo", var, "", "", "", "", "", "", "", "")
                Report1.informe.PrintOptions.PrinterName = "CAJA"
                Report1.informe.PrintToPrinter(2, True, 0, 0)
            Case "2"
                Me.Text = "REPORTE DE PAGO"
                'Dim repor As New rpt_pagodecredito
                'repor.SetParameterValue("@var", var)
                'repor.PrintOptions.PrinterName = "CAJA"
                'repor.PrintToPrinter(2, True, 0, 0)

                Dim Report1 As New ReportesBD()
                Report1.MostrarReporte("rpt_pagodecredito.rpt", "@var", var, "", "", "", "", "", "", "", "")
                Report1.informe.PrintOptions.PrinterName = "CAJA"
                Report1.informe.PrintToPrinter(2, True, 0, 0)
            Case "3"
                Me.Text = "REPORTE DE CLIENTES"
                'Dim repor As New rpt_clientes
                'repor.PrintOptions.PrinterName = "CAJA"
                'repor.PrintToPrinter(2, True, 0, 0)

                Dim Report1 As New ReportesBD()
                Report1.MostrarReporte("rpt_clientes.rpt", "", "", "", "", "", "", "", "", "", "")
                Report1.informe.PrintOptions.PrinterName = "CAJA"
                Report1.informe.PrintToPrinter(2, True, 0, 0)
            Case "4"
                Me.Text = "REPORTE DE CLIENTES AL DIA"
                'Dim repor As New rpt_CreditosAlDia
                'repor.PrintOptions.PrinterName = "CAJA"
                'repor.PrintToPrinter(2, True, 0, 0)

                Dim Report1 As New ReportesBD()
                Report1.MostrarReporte("rpt_CreditosAlDia.rpt", "", "", "", "", "", "", "", "", "", "")
                Report1.informe.PrintOptions.PrinterName = "CAJA"
                Report1.informe.PrintToPrinter(2, True, 0, 0)
            Case "5"
                Me.Text = "REPORTE DE CLIENTES EN MORA"
                'Dim repor As New rpt_creditosMorosos
                'repor.PrintOptions.PrinterName = "CAJA"
                'repor.PrintToPrinter(2, True, 0, 0)

                Dim Report1 As New ReportesBD()
                Report1.MostrarReporte("rpt_creditosMorosos.rpt", "", "", "", "", "", "", "", "", "", "")
                Report1.informe.PrintOptions.PrinterName = "CAJA"
                Report1.informe.PrintToPrinter(2, True, 0, 0)
            Case "09"
                Me.Text = "REPORTE DE PAGOS"
                'Dim repor As New rpt_pagos_ingresos
                'repor.SetParameterValue("@fecha1", fec1)
                'repor.SetParameterValue("@fecha2", fec2)
                'repor.PrintOptions.PrinterName = "CAJA"
                'repor.PrintToPrinter(2, True, 0, 0)

                Dim Report1 As New ReportesBD()
                Report1.MostrarReporte("rpt_pagos_ingresos.rpt", "@fecha1", fec1, "@fecha2", fec2, "", "", "", "", "", "")
                Report1.informe.PrintOptions.PrinterName = "CAJA"
                Report1.informe.PrintToPrinter(2, True, 0, 0)
            Case "10"
                Me.Text = "TICKET DE GIRO"
                'Dim repor As New rpt_giro_detalle
                'repor.SetParameterValue("@id", var)
                'repor.PrintOptions.PrinterName = "CAJA"
                'repor.PrintToPrinter(2, True, 0, 0)

                Dim Report1 As New ReportesBD()
                Report1.MostrarReporte("rpt_giro_detalle.rpt", "@id", var, "", "", "", "", "", "", "", "")
                Report1.informe.PrintOptions.PrinterName = "CAJA"
                Report1.informe.PrintToPrinter(2, True, 0, 0)
            Case "11"
                Me.Text = "REPORTE DE GIROS"
                'Dim repor As New rpt_giro
                'repor.SetParameterValue("@fecha1", fec1)
                'repor.SetParameterValue("@fecha2", fec2)
                'repor.PrintOptions.PrinterName = "CAJA"
                'repor.PrintToPrinter(2, True, 0, 0)

                Dim Report1 As New ReportesBD()
                Report1.MostrarReporte("rpt_giro.rpt", "@fecha1", fec1, "@fecha2", fec2, "", "", "", "", "", "")
                Report1.informe.PrintOptions.PrinterName = "CAJA"
                Report1.informe.PrintToPrinter(2, True, 0, 0)
        End Select
    End Sub

End Class