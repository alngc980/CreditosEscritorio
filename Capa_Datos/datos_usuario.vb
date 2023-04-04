Imports System.Data.SqlClient
Imports Capa_Entidad
Imports System.Windows.Forms
Public Class datos_usuario
    Dim scn As New SqlConnection
    Dim cn As New conexion
    Dim dt As New DataTable
    Dim scmd As New SqlCommand
    Dim sda As New SqlDataAdapter
    Dim ds As New DataSet

    Public Function registrar_usuario(ByVal usuario As entidad_usuario)
        Try
            scn = cn.conectar
            scn.Open()
            sda = New SqlDataAdapter("registrarusuario", scn)
            sda.SelectCommand.CommandType = CommandType.StoredProcedure
            With sda.SelectCommand.Parameters
                .Add("@usu_id", SqlDbType.VarChar).Value = usuario.Usu_id
                .Add("@usu_dni", SqlDbType.VarChar).Value = usuario.Usu_dni
                .Add("@usu_nombre", SqlDbType.VarChar).Value = usuario.Usu_nombre
                .Add("@usu_direccion", SqlDbType.VarChar).Value = usuario.Usu_direccion
                .Add("@usu_telefono", SqlDbType.VarChar).Value = usuario.Usu_telefono
                .Add("@usu_usuario", SqlDbType.VarChar).Value = usuario.Usu_usuario
                .Add("@usu_clave", SqlDbType.VarChar).Value = usuario.Usu_clave
                .Add("@tipo_id", SqlDbType.Int).Value = usuario.Tipo_id
            End With
            sda.SelectCommand.ExecuteNonQuery()
            MsgBox("Registro Guardado", MsgBoxStyle.Information, "MENSAJE")

        Catch ex As Exception
            MsgBox(ex)
        Finally
            scn.Close()
            scn.Dispose()
            sda.Dispose()
        End Try
        Return False
    End Function

    Public Function listar_usuario() As DataSet
        Try
            scn = cn.conectar
            scn.Open()
            ds.Clear()
            sda = New SqlDataAdapter("listarusuario", scn)
            sda.Fill(ds, "usuarios")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            scn.Close()
            sda.Dispose()
            ds.Dispose()
        End Try
    End Function

    Public Function actualizar_usuario(ByVal usuario As entidad_usuario)
        Try
            scn = cn.conectar
            scn.Open()

            scmd = New SqlCommand("actualizarusuario", scn)
            scmd.CommandType = CommandType.StoredProcedure

            With scmd.Parameters
                .AddWithValue("@usu_dni", usuario.Usu_dni)
                .AddWithValue("@usu_nombre", usuario.Usu_nombre)
                .AddWithValue("@usu_direccion", usuario.Usu_direccion)
                .AddWithValue("@usu_telefono", usuario.Usu_telefono)
                .AddWithValue("@usu_usuario", usuario.Usu_usuario)
                .AddWithValue("@usu_clave", usuario.Usu_clave)
                .AddWithValue("@tipo_id", usuario.Tipo_id)
            End With
            scmd.Parameters.AddWithValue("@usu_id", usuario.Usu_id)
            scmd.ExecuteNonQuery()
            MsgBox("Registro Actualizado", MsgBoxStyle.Information, "MENSAJE")
            Return scmd
        Catch ex As Exception
            Throw ex
        Finally
            scn.Close()
            scn.Dispose()
            scmd.Dispose()
        End Try
    End Function

    Public Function eliminar_usuario(ByVal usuario As entidad_usuario) As Boolean
        Try
            scn = cn.conectar
            scn.Open()

            scmd = New SqlCommand("eliminarusuario", scn)
            scmd.CommandType = CommandType.StoredProcedure
            scmd.Parameters.AddWithValue("@usu_id", usuario.Usu_id)

            If scmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("El registro no se puede eliminar!", Title:="Mensaje")
            Return False
        Finally
            scn.Close()
            scn.Dispose()
            scmd.Dispose()
        End Try
    End Function

    Public Function generar_usuario() As Integer

        Try
            scn = cn.conectar
            scn.Open()
            sda = New SqlDataAdapter("generarusuario", scn)

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
End Class
