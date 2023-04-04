Imports Capa_Datos
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class ReportesBD
    Dim asd As New conexion

    Dim DataBaseName As String = asd.DataBaseName
    'Dim UserID As String = "sa"
    'Dim Password As String = "123456"
    Dim ServerName As String = asd.ServerName       '"DESKTOP-4QGTLKB"
    Dim IntegratedSecurity As Boolean = True

    Private MyPath As String
    Public informe As New ReportDocument
    Public miConexionInfo As ConnectionInfo

    Dim conex As New conexion
    Public Sub MostrarReporte(NombreReporte As String,
                              nVar1 As String, vVar1 As String,
                              nVar2 As String, vVar2 As String,
                              nVar3 As String, vVar3 As String,
                              nVar4 As String, vVar4 As String,
                              nVar5 As String, vVar5 As String)
        Try
            Dim NombreReport As String = NombreReporte

            miConexionInfo = New ConnectionInfo()
            miConexionInfo.DatabaseName = conex.DataBaseName    ' DataBaseName
            miConexionInfo.UserID = conex.UserID                ' UserID
            miConexionInfo.Password = conex.Password            ' Password
            miConexionInfo.ServerName = conex.ServerName        ' ServerName
            miConexionInfo.IntegratedSecurity = conex.IntSec    ' IntegratedSecurity

            If informe.IsLoaded Then
                informe.Close()
                informe.Dispose()
            End If

            informe = New ReportDocument()
            Dim reportPath As String = Application.StartupPath & "\rpt\" & NombreReporte
            informe.Load(reportPath)

            If nVar1 <> "" And nVar1 <> "" Then
                informe.SetParameterValue(nVar1, vVar1)
            End If

            If nVar2 <> "" And nVar2 <> "" Then
                informe.SetParameterValue(nVar2, vVar2)
            End If

            If nVar3 <> "" And nVar3 <> "" Then
                informe.SetParameterValue(nVar3, vVar3)
            End If

            If nVar4 <> "" And nVar4 <> "" Then
                informe.SetParameterValue(nVar4, vVar4)
            End If

            If nVar5 <> "" And nVar5 <> "" Then
                informe.SetParameterValue(nVar5, vVar5)
            End If

            Loguearse(informe)

        Catch ex As Exception
            Cursor.Current = Cursors.Default
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Try
            Exit Sub
        End Try
    End Sub

    Public Sub Loguearse(ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = miConexionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

End Class
