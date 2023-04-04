Imports System.Data.SqlClient
Imports Capa_Entidad
Imports System.Windows.Forms
Public Class datos_credito
    Dim scn As New SqlConnection
    Dim cn As New conexion
    Dim dt As New DataTable
    Dim scmd As New SqlCommand
    Dim sda As New SqlDataAdapter
    Dim ds As New DataSet
    Public Function registrar_credito(ByVal credito As entidad_credito)
        Try
            scn = cn.conectar
            scn.Open()
            sda = New SqlDataAdapter("registrarcredito", scn)
            sda.SelectCommand.CommandType = CommandType.StoredProcedure
            With sda.SelectCommand.Parameters
                .Add("@cr_pccorrelativo", SqlDbType.VarChar).Value = credito.Cr_pccorrelativo
                .Add("@cr_fecha", SqlDbType.SmallDateTime).Value = credito.Cr_fecha
                .Add("@usu_id", SqlDbType.VarChar).Value = credito.Usu_id
                .Add("@cli_id", SqlDbType.VarChar).Value = credito.Cli_id
                .Add("@cr_monto", SqlDbType.Decimal).Value = credito.Cr_monto
                .Add("@cr_interes", SqlDbType.Decimal).Value = credito.Cr_interes
                .Add("@cr_moratotal", SqlDbType.Decimal).Value = credito.Cr_moraTotal
                .Add("@cr_total", SqlDbType.Decimal).Value = credito.Cr_total
                .Add("@cv_id", SqlDbType.Int).Value = credito.Cv_id
                .Add("@vendedor", SqlDbType.VarChar).Value = credito.Vendedor
                .Add("@id_caja", SqlDbType.Int).Value = credito.Id_caja
            End With
            sda.SelectCommand.ExecuteNonQuery()
            MsgBox("Registro Guardado", MsgBoxStyle.Information, "MENSAJE")
        Catch ex As Exception
            Throw ex
        Finally
            scn.Close()
            scn.Dispose()
            sda.Dispose()
        End Try
        Return False
    End Function


    Public Function listar_credito(tabla As DataGridView)
        Try
            scn = cn.conectar
            scn.Open()
            dt.Clear()
            sda = New SqlDataAdapter("listarcredito", scn)
            sda.SelectCommand.CommandType = CommandType.StoredProcedure
            sda.Fill(dt)
            tabla.DataSource = dt
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            scn.Close()
            sda.Dispose()
            ds.Dispose()
        End Try
    End Function

    Public Function generarcredito(vendedor As String) As Integer

        Try
            scn = cn.conectar
            scn.Open()
            sda = New SqlDataAdapter("generarcredito", scn)

            sda.SelectCommand.CommandType = CommandType.StoredProcedure
            'sda.SelectCommand.Parameters.AddWithValue("@vende", vendedor)

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

    Public Function buscar_credito_detalle(ByVal credito As entidad_credito, tabla As DataGridView)
        Try
            scn = cn.conectar
            scn.Open()
            dt.Clear()
            sda = New SqlDataAdapter("buscarcredito", scn)
            sda.SelectCommand.CommandType = CommandType.StoredProcedure
            sda.SelectCommand.Parameters.AddWithValue("@cliente", credito.Cr_pccorrelativo)
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

    Public Function Anular_Credito(id As String) As Boolean
        scn = cn.conectar
        scn.Open()
        Dim command As SqlCommand
        command = scn.CreateCommand()
        command.CommandText = "update credito set bestado = 0 where id = " & id
        If command.ExecuteNonQuery() Then
            MsgBox("Se ha anulado el credito!", MsgBoxStyle.Information, "MENSAJE")
            Return True
        Else
            Return False
        End If
    End Function


    Public Function Distribucion_monto(id As Integer, monto As Decimal) As Decimal
        scn = cn.conectar
        scn.Open()
        Dim command As SqlCommand
        command = scn.CreateCommand()
        command.CommandText = "exec Distribucion_Pago " & id & ", " & monto

        sda = New SqlDataAdapter(command)
        Dim dt As New DataTable()
        sda.Fill(dt)
        Return dt.Rows(0)(0).ToString()

    End Function

    Public Function Ultimo_credito()
        Try
            scn = cn.conectar
            scn.Open()
            Dim comand As SqlCommand

            comand = New SqlCommand("select top 1 id from credito order by id desc", scn)
            sda = New SqlDataAdapter(comand)
            Dim dt As New DataTable()
            sda.Fill(dt)
            If dt.Rows.Count() > 0 Then
                Return dt.Rows(0)(0).ToString()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
