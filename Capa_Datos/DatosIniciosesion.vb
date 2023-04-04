Imports System.Data.SqlClient
Imports Capa_Entidad
Imports System.Windows.Forms
Public Class DatosIniciosesion

    Dim scn As New SqlConnection
    Dim cn As New conexion
    Dim scmd As New SqlCommand
    Dim sda As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable, dr As SqlDataReader

    Public Function registrar_inicio_sesion(ByVal inicio As EntidadInicioSesion)
        Try
            scn = cn.conectar()
            scn.Open()
            sda = New SqlDataAdapter("guardar_inicio_sesion", scn)
            sda.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure

            sda.SelectCommand.Parameters.Add("@u_id", SqlDbType.Char).Value = inicio.U_id
            sda.SelectCommand.Parameters.Add("@fec_hor_inicio", SqlDbType.SmallDateTime).Value = inicio.Fec_hor_inicio
            sda.SelectCommand.Parameters.Add("@inicio_caja", SqlDbType.Decimal).Value = inicio.Inicio_caja
            sda.SelectCommand.Parameters.Add("@caja_ventas", SqlDbType.Decimal).Value = inicio.Caja_ventas
            sda.SelectCommand.Parameters.Add("@caja_gastos", SqlDbType.Decimal).Value = inicio.Caja_gastos
            sda.SelectCommand.Parameters.Add("@caja_final", SqlDbType.Decimal).Value = inicio.Caja_final
            sda.SelectCommand.Parameters.Add("@vendedor", SqlDbType.VarChar).Value = inicio.Vendedor_id

            sda.SelectCommand.ExecuteNonQuery()
            MsgBox("APERTURA DE CAJA EXITOSO!", MsgBoxStyle.Information, "Registro guardado")
        Catch ex As Exception
            Throw ex
        Finally
            scn.Close()
            scn.Dispose()
            sda.Dispose()
        End Try
        Return False
    End Function

    Public Function actualizar_incio_sesion(ByVal inicio As EntidadInicioSesion)
        Try
            scn = cn.conectar()
            scn.Open()
            scmd = New SqlCommand("actualizar_inicio_sesion", scn)
            scmd.CommandType = CommandType.StoredProcedure

            scmd.Parameters.AddWithValue("@is_id", inicio.Is_id)
            scmd.Parameters.AddWithValue("@inicio_caja", inicio.Inicio_caja)
            scmd.Parameters.AddWithValue("@caja_ventas", inicio.Caja_ventas)
            scmd.Parameters.AddWithValue("@caja_gastos", inicio.Caja_gastos)
            scmd.Parameters.AddWithValue("@caja_final", inicio.Caja_final)
            scmd.Parameters.AddWithValue("@caja_sobrantes", inicio.Caja_sobrantes)
            scmd.Parameters.AddWithValue("@caja_faltantes", inicio.Caja_faltantes)

            scmd.ExecuteNonQuery()
            ''MsgBox("Registro Actualizado", MsgBoxStyle.Information, "MENSAJE")
            Return scmd
        Catch ex As Exception
            Throw ex
        Finally
            scn.Close()
            scn.Dispose()
            scmd.Dispose()
        End Try
    End Function

    Public Function registrar_fin_sesion(ByVal inicio As EntidadInicioSesion)
        Try
            scn = cn.conectar()
            scn.Open()
            sda = New SqlDataAdapter("guardar_cierre_inicio_sesion", scn)
            sda.SelectCommand.CommandType = CommandType.StoredProcedure

            sda.SelectCommand.Parameters.AddWithValue("@is_id", inicio.Is_id)
            sda.SelectCommand.Parameters.AddWithValue("@fec_salida", inicio.Fec_hor_salida)
            sda.SelectCommand.Parameters.AddWithValue("@inicio_caja", inicio.Inicio_caja)
            sda.SelectCommand.Parameters.AddWithValue("@caja_ventas", inicio.Caja_ventas)
            sda.SelectCommand.Parameters.AddWithValue("@caja_gastos", inicio.Caja_gastos)
            sda.SelectCommand.Parameters.AddWithValue("@caja_final", inicio.Caja_final)
            sda.SelectCommand.Parameters.AddWithValue("@caja_sobrantes", inicio.Caja_sobrantes)
            sda.SelectCommand.Parameters.AddWithValue("@caja_faltantes", inicio.Caja_faltantes)

            sda.SelectCommand.ExecuteNonQuery()
            MsgBox("REGISTRO DE CIERRE DE CAJA EXISTOSO", MsgBoxStyle.OkOnly, "MENSAJE")
        Catch ex As Exception
            Throw ex
        Finally
            scn.Close()
            scn.Dispose()
            sda.Dispose()
        End Try
        Return False
    End Function

    Public Function Caja_Aperturada(vendedor As String) As Boolean
        Try
            scn = cn.conectar
            scn.Open()
            scmd = New SqlCommand("select top 1 fec_hor_salida from inicio_sesion where vendedor_id='" & vendedor & "' order by is_id desc", scn)
            dr = scmd.ExecuteReader
            If dr.Read Then
                If IsDate(dr(0)) Then
                    'MsgBox("LA CAJA ESTA CERRADA", Title:="MENSAJE")
                    Return False
                Else
                    'MsgBox("LA CAJA ESTA ABIERTA", Title:="MENSAJE")
                    Return True
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("NO HAY NINGUN REGISTRO DE CAJA", Title:="Mensaje")
            Return False
        Finally
            scn.Close()
            scn.Dispose()
            scmd.Dispose()
        End Try
    End Function

    Public Function Obtener_id_caja(vendedor As String) As Integer
        Try
            scn = cn.conectar
            scn.Open()
            scmd = New SqlCommand("select top 1 is_id from inicio_sesion where vendedor_id='" & vendedor & "' order by is_id desc", scn)
            dr = scmd.ExecuteReader
            If dr.Read Then
                Return Convert.ToInt32(dr(0))
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox("NO HAY NINGUN REGISTRO DE CAJA", Title:="Mensaje")
            Return 0
        Finally
            scn.Close()
            scn.Dispose()
            scmd.Dispose()
        End Try
    End Function

    Public Function Obtener_Fecha_Apertura(id_sesion As String) As String
        Try
            scn = cn.conectar
            scn.Open()
            scmd = New SqlCommand("select top 1 fec_hor_inicio from inicio_sesion where is_id=" & id_sesion & " order by is_id desc", scn)
            dr = scmd.ExecuteReader
            If dr.Read Then
                Return Convert.ToString(dr(0))
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox("No se encontro de fecha de apertura!", Title:="Mensaje")
            Return 0
        Finally
            scn.Close()
            scn.Dispose()
            scmd.Dispose()
        End Try
    End Function
    Public Function Obtener_Monto_Apertura(id_sesion As String) As String
        Try
            scn = cn.conectar
            scn.Open()
            scmd = New SqlCommand("select top 1 inicio_caja from inicio_sesion where is_id=" & id_sesion & " order by is_id desc", scn)
            dr = scmd.ExecuteReader
            If dr.Read Then
                Return Convert.ToString(dr(0))
            Else
                Return 0
            End If
        Catch ex As Exception
            MsgBox("No se encontro de monto de apertura!", Title:="Mensaje")
            Return 0
        Finally
            scn.Close()
            scn.Dispose()
            scmd.Dispose()
        End Try
    End Function

End Class
