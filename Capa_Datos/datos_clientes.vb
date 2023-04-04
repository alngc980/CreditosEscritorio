Imports System.Data.SqlClient
Imports Capa_Entidad
Imports System.Windows.Forms
Public Class datos_clientes
    Dim scn As New SqlConnection
    Dim cn As New conexion
    Dim dt As New DataTable
    Dim scmd As New SqlCommand
    Dim sda As New SqlDataAdapter
    Dim ds As New DataSet


    Public Function registrar_cliente(ByVal cliente As entidad_cliente)
        Try
            scn = cn.conectar
            scn.Open()
            sda = New SqlDataAdapter("registrarclientes", scn)
            sda.SelectCommand.CommandType = CommandType.StoredProcedure
            With sda.SelectCommand.Parameters
                .Add("@cli_id", SqlDbType.VarChar).Value = cliente.Cli_id
                .Add("@cli_numero", SqlDbType.VarChar).Value = cliente.Cli_numero
                .Add("@cli_razon", SqlDbType.VarChar).Value = cliente.Cli_razon
                .Add("@cli_ocupacion", SqlDbType.VarChar).Value = cliente.Cli_ocupacion
                .Add("@cli_sexo", SqlDbType.VarChar).Value = cliente.Cli_sexo
                .Add("@cli_direccion", SqlDbType.VarChar).Value = cliente.Cli_direccion
                .Add("@cli_telefono", SqlDbType.VarChar).Value = cliente.Cli_telefono

                .Add("@nombre", SqlDbType.VarChar).Value = cliente.Nombre
                .Add("@direccion", SqlDbType.VarChar).Value = cliente.Direccion
                .Add("@telefono", SqlDbType.VarChar).Value = cliente.Telefono
                .Add("@garantia", SqlDbType.VarChar).Value = cliente.Garantia
            End With
            sda.SelectCommand.ExecuteNonQuery()
            MsgBox("Registro Guardado Exitosamente!", MsgBoxStyle.Information, "MENSAJE")

        Catch ex As Exception
            MsgBox(ex)
        Finally
            scn.Close()
            scn.Dispose()
            sda.Dispose()
        End Try
        Return False
    End Function

    Public Function listar_cliente() As DataSet
        Try
            scn = cn.conectar
            scn.Open()
            ds.Clear()
            sda = New SqlDataAdapter("listar_clientes", scn)
            sda.Fill(ds, "Clientes")
            Return ds
        Catch ex As Exception
            Throw ex
        Finally
            scn.Close()
            sda.Dispose()
            ds.Dispose()
        End Try
    End Function

    Public Function actualizar_cliente(ByVal cliente As entidad_cliente)
        Try
            scn = cn.conectar
            scn.Open()

            scmd = New SqlCommand("actualizarclientes", scn)
            scmd.CommandType = CommandType.StoredProcedure

            With scmd.Parameters
                .AddWithValue("@cli_numero", cliente.Cli_numero)
                .AddWithValue("@cli_razon", cliente.Cli_razon)
                .AddWithValue("@cli_ocupacion", cliente.Cli_ocupacion)
                .AddWithValue("@cli_sexo", cliente.Cli_sexo)
                .AddWithValue("@cli_direccion", cliente.Cli_direccion)
                .AddWithValue("@cli_telefono", cliente.Cli_telefono)

                .AddWithValue("@nombre", cliente.Nombre)
                .AddWithValue("@direccion", cliente.Direccion)
                .AddWithValue("@telefono", cliente.Telefono)
                .AddWithValue("@garantia", cliente.Garantia)
            End With
            scmd.Parameters.AddWithValue("@cli_id", cliente.Cli_id)
            scmd.ExecuteNonQuery()
            MsgBox("Registro Actualizado", MsgBoxStyle.Information, "MENSAJE")

        Catch ex As Exception
            MsgBox("Error al actualizar", MsgBoxStyle.Exclamation, "Vuelva a Intentar!")
        Finally
            scn.Close()
            scn.Dispose()
            scmd.Dispose()
        End Try
        Return scmd
    End Function

    Public Function eliminar_cliente(ByVal cliente As entidad_cliente) As Boolean
        Try
            scn = cn.conectar
            scn.Open()

            scmd = New SqlCommand("eliminarclientes", scn)
            scmd.CommandType = CommandType.StoredProcedure
            scmd.Parameters.AddWithValue("@var", cliente.Cli_id)

            If scmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("El registro no se puede eliminar!", MsgBoxStyle.Information, Title:="Mensaje")
            Return False
        Finally
            scn.Close()
            scn.Dispose()
            scmd.Dispose()
        End Try
    End Function

    Public Function generar_clientes() As Integer

        Try
            scn = cn.conectar
            scn.Open()
            sda = New SqlDataAdapter("generarclientes", scn)

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

    Public Function buscar_cliente(ByVal cliente As entidad_cliente, tabla As DataGridView)
        Try
            scn = cn.conectar
            scn.Open()
            dt.Clear()
            sda = New SqlDataAdapter("buscarcliente", scn)
            sda.SelectCommand.CommandType = CommandType.StoredProcedure
            sda.SelectCommand.Parameters.AddWithValue("@cli_razon", cliente.Cli_razon)
            sda.Fill(dt)
            tabla.DataSource = dt
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            scn.Close()
            sda.Dispose()
        End Try
    End Function

    Public Function buscar_clienteXcumpleaños(ByVal cliente As entidad_cliente, tabla As DataGridView)
        Try
            scn = cn.conectar
            scn.Open()
            dt.Clear()
            sda = New SqlDataAdapter("buscarclienteXcumpleaño", scn)
            sda.SelectCommand.CommandType = CommandType.StoredProcedure
            'sda.SelectCommand.Parameters.AddWithValue("@var", cliente.Cli_fechanac)
            sda.Fill(dt)
            tabla.DataSource = dt
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            scn.Close()
            sda.Dispose()
        End Try
    End Function
End Class
