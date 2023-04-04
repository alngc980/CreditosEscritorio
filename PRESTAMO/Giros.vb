Imports System.Data.SqlClient
Imports Capa_Datos
Imports Capa_Entidad
Public Class Giros
    Dim scn As New SqlConnection
    Dim cn As New conexion
    Dim sda As New SqlDataAdapter

    Dim datos As New datos_giro
    Dim entidad As New entidad_giro


    Private Sub Giros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.Text = datos.generarCodigoGiro

        lblcodiforet.Text = Aleatorio()
        Label14.Text = DateTime.Now

    End Sub


    Public Function Aleatorio() As String
        Dim codigo As String = ""
        Dim rand As New Random()
        For index = 1 To 4
            codigo = Convert.ToString(codigo) & Convert.ToString(numAleatorioEntre(0, 9))
        Next
        Return codigo
    End Function

    Function numAleatorioEntre(ByVal minimo As Integer, ByVal maximo As Integer) As Integer
        Randomize()
        Return CLng((minimo - maximo) * Rnd() + maximo)
    End Function

    Private Sub txtmontogiro_TextChanged(sender As Object, e As EventArgs) Handles txtmontogiro.TextChanged
        Try
            If IsNumeric(txtmontogiro.Text) Then
                If txtmontogiro.Text <= 300 Then
                    txtcomision.Text = Convert.ToDecimal("15")
                Else
                    txtcomision.Text = txtmontogiro.Text * 0.05
                End If

                txttotal.Text = Convert.ToDecimal(txtmontogiro.Text) + Convert.ToDecimal(txtcomision.Text)
            End If
        Catch ex As Exception
            txtcomision.Text = Convert.ToDecimal("0")
            txttotal.Text = Convert.ToDecimal("0")
        End Try
    End Sub

    Private Sub btngiro_Click(sender As Object, e As EventArgs) Handles btngiro.Click
        If txtdniemisor.Text.Trim = "" Or txtonombremisor.Text.Trim = "" Or txtdnireceptor.Text.Trim = "" Or txtnombrereceptor.Text.Trim = "" And IsNumeric(txtmontogiro.Text) And IsNumeric(txttotal.Text) Then
            MsgBox("Ingrese todos los campos requeridos!", MsgBoxStyle.Information, Title:="Mensaje")
        Else
            entidad.Id = txtid.Text
            entidad.Emisor_origen = txtorigen.Text
            entidad.Emisor_dni = txtdniemisor.Text
            entidad.Emisor_nombre = txtonombremisor.Text
            entidad.Destino_origen = txtdestino.Text
            entidad.Destino_dni = txtdnireceptor.Text
            entidad.Destino_nombre = txtnombrereceptor.Text
            entidad.Monto_giro = txtmontogiro.Text
            entidad.Monto_comision = txtcomision.Text
            entidad.Codigo_retiro = lblcodiforet.Text
            datos.registrar_giro(entidad)

            'Dim Report As New ReportesBD()
            'Report.MostrarReporte("rptPC.rpt", "@cr_pccorrelativo", entidad.Id, "", "", "", "", "", "", "", "")
            'Me.CrystalReportViewer1.Refresh()
            'Me.CrystalReportViewer1.ReportSource = Report.informe

            'Dim repor As New rptPC
            'repor.SetParameterValue("@cr_pccorrelativo", var)
            'CrystalReportViewer1.ReportSource = repor


            Dim report As New Reporte_Pc_A5
            report.NUMERO = "10"
            report.var = entidad.Id
            report.ShowDialog()
        End If
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class