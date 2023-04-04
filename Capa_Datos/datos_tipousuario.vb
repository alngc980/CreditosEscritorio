Imports System.Data.SqlClient
Imports Capa_Entidad
Imports System.Windows.Forms
Public Class datos_tipousuario
    Dim scn As New SqlConnection
    Dim cn As New conexion
    Dim dt As New DataTable
    Dim scmd As New SqlCommand
    Dim sda As New SqlDataAdapter
    Dim ds As New DataSet

    Public Function listar_tipousuario() As DataSet
        Try
            scn = cn.conectar
            scn.Open()
            ds.Clear()
            sda = New SqlDataAdapter("listar_tipo", scn)
            sda.Fill(ds, "tipo_usuario")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            scn.Close()
            sda.Dispose()
            ds.Dispose()
        End Try
    End Function
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    Sub combobox(ByVal cb As ComboBox)
        Try
            scn = cn.conectar
            scn.Open()
            cb.Items.Clear()
            enunciado = New SqlCommand("select tipo_nombre from tipo_usuario", scn)
            respuesta = enunciado.ExecuteReader

            While respuesta.Read
                cb.Items.Add(respuesta.Item("tipo_nombre"))
            End While
            respuesta.Close()
            scn.Dispose()
            scn.Close()
        Catch ex As Exception

        End Try
    End Sub
End Class
