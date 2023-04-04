Imports System.Data.SqlClient
Imports Capa_Entidad
Imports System.Windows.Forms
Public Class datos_giro
    Dim scn As New SqlConnection
    Dim cn As New conexion
    Dim dt As New DataTable
    Dim scmd As New SqlCommand
    Dim sda As New SqlDataAdapter
    Dim ds As New DataSet

    Public Function registrar_giro(ByVal giro As entidad_giro)
        Try
            scn = cn.conectar
            scn.Open()
            sda = New SqlDataAdapter("registrar_giro", scn)
            sda.SelectCommand.CommandType = CommandType.StoredProcedure
            With sda.SelectCommand.Parameters
                .Add("@id", SqlDbType.VarChar).Value = giro.Id
                .Add("@emisor_origen", SqlDbType.VarChar).Value = giro.Emisor_origen
                .Add("@emisor_dni", SqlDbType.VarChar).Value = giro.Emisor_dni
                .Add("@emisor_nombre", SqlDbType.VarChar).Value = giro.Emisor_nombre
                .Add("@destino_origen", SqlDbType.VarChar).Value = giro.Destino_origen
                .Add("@destino_dni", SqlDbType.VarChar).Value = giro.Destino_dni
                .Add("@destino_nombre", SqlDbType.VarChar).Value = giro.Destino_nombre
                .Add("@monto_giro", SqlDbType.Decimal).Value = giro.Monto_giro
                .Add("@monto_comision", SqlDbType.Decimal).Value = giro.Monto_comision
                .Add("@codigo_retiro", SqlDbType.VarChar).Value = giro.Codigo_retiro
            End With
            sda.SelectCommand.ExecuteNonQuery()
            MsgBox("Giro Realizado exitosamente!", MsgBoxStyle.Information, "Mortal Burger Giros")

        Catch ex As Exception
            MsgBox(ex)
        Finally
            scn.Close()
            scn.Dispose()
            sda.Dispose()
        End Try
        Return False
    End Function

    Public Function generar_Giro() As Integer

        Try
            scn = cn.conectar
            scn.Open()
            sda = New SqlDataAdapter("GenerarGiro", scn)

            Dim cod As Integer
            cod = sda.SelectCommand.ExecuteScalar
            Return cod + 1
        Catch ex As Exception
            Throw ex
        Finally
            scn.Close()
            scn.Dispose()
            sda.Dispose()
        End Try
    End Function


    Public Function generarCodigoGiro() As String
        Try
            Dim r, retu As String
            r = "000000"
            retu = r & generar_Giro()

            If retu > 9 Then
                r = "00000"
                retu = r & generar_Giro()
            End If

            If retu > 99 Then
                r = "0000"
                retu = r & generar_Giro()
            End If

            If retu > 999 Then
                r = "CLI000"
                retu = r & generar_Giro()
            End If
            If retu > 9999 Then
                r = "00"
                retu = r & generar_Giro()
            End If

            If retu > 99999 Then
                r = "0"
                retu = r & generar_Giro()
            End If

            If retu > 999999 Then
                r = ""
                retu = r & generar_Giro()
            End If
            Return retu
        Catch ex As Exception
            Return ""
            'MsgBox("LLAMA AL PROGRAMADOR")
        End Try
    End Function


End Class
