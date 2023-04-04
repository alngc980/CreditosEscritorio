Imports System.Data.SqlClient
Imports Capa_Entidad
Imports System.Windows.Forms

Public Class datos_vendedores
    Dim scn As New SqlConnection
    Dim cn As New conexion
    Dim dt As New DataTable
    Dim scmd As New SqlCommand
    Dim sda As New SqlDataAdapter
    Dim ds As New DataSet

    Public Function listar_Vendedores() As DataSet
        Try
            scn = cn.conectar
            scn.Open()
            ds.Clear()
            sda = New SqlDataAdapter("listar_vendedores", scn)
            sda.Fill(ds, "Vendedores")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            scn.Close()
            sda.Dispose()
            ds.Dispose()
        End Try
    End Function

End Class
