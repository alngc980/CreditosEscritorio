Imports System.Data.SqlClient
Imports Capa_Entidad
Imports System.Windows.Forms
Public Class datos_creditodetalle
    Dim scn As New SqlConnection
    Dim cn As New conexion
    Dim dt As New DataTable
    Dim scmd As New SqlCommand
    Dim sda As New SqlDataAdapter
    Dim ds As New DataSet


    Public Function registrar_creditodetalle(ByVal cre As entidad_creditodetalle)
        Try
            scn = cn.conectar
            scn.Open()
            sda = New SqlDataAdapter("registrarcreditodetalle", scn)
            sda.SelectCommand.CommandType = CommandType.StoredProcedure
            With sda.SelectCommand.Parameters
                .Add("@cr_pccorrelativo", SqlDbType.Int).Value = cre.Id_Cr_pccorrelativo
                .Add("@cdd_numero", SqlDbType.Int).Value = cre.Cdd_numero
                .Add("@cdd_fecha", SqlDbType.SmallDateTime).Value = cre.Cdd_fecha
                '.Add("@cdd_fecha_pago", SqlDbType.SmallDateTime).Value = cre.Cdd_fecha_pago
                .Add("@tipo_pago", SqlDbType.VarChar).Value = cre.tipo_pago
                .Add("@cdd_abono", SqlDbType.Decimal).Value = cre.Cdd_abono
                .Add("@cdd_saldo", SqlDbType.Decimal).Value = cre.Cdd_saldo
                .Add("@cdd_estado", SqlDbType.Int).Value = cre.Cdd_estado
                .Add("@id_caja", SqlDbType.Int).Value = cre.Cdd_caja
            End With
            sda.SelectCommand.ExecuteNonQuery()
            ' MsgBox("Registro Guardado", MsgBoxStyle.Information, "MENSAJE")

        Catch ex As Exception
            Throw ex
        Finally
            scn.Close()
            scn.Dispose()
            sda.Dispose()
        End Try
        Return False
    End Function

    Public Function generar_creditodetalle() As Integer

        Try
            scn = cn.conectar
            scn.Open()
            sda = New SqlDataAdapter("generarcreditodetalle", scn)

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

    Public Function eliminar_pagos_de_credito_ANULACION(N_orden As String) As Boolean
        Try
            scn = cn.conectar
            scn.Open()

            scmd = New SqlCommand("eliminar_credito_detalle_pagos_ANULACION", scn)
            scmd.CommandType = CommandType.StoredProcedure
            scmd.Parameters.AddWithValue("@cr_pccorrelativo", N_orden)

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

    Public Function listar_estadocuenta(id_cr_pc As Integer, tabla As DataGridView)
        Try
            scn = cn.conectar
            scn.Open()
            dt.Clear()
            sda = New SqlDataAdapter("listarcreditodetalle", scn)
            sda.SelectCommand.CommandType = CommandType.StoredProcedure
            sda.SelectCommand.Parameters.AddWithValue("@idcre", id_cr_pc)
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


    Public Function actualizar_credito_detalle(ByVal ent As entidad_creditodetalle) ''' PAGOSSSSS
        Try
            scn = cn.conectar
            scn.Open()

            scmd = New SqlCommand("actualizar_credito_detalle", scn)
            scmd.CommandType = CommandType.StoredProcedure

            With scmd.Parameters
                .AddWithValue("@cdd_fecha_pago", ent.Cdd_fecha_pago)
                .AddWithValue("@tipo_pago", ent.tipo_pago)
                .AddWithValue("@cdd_abono", ent.Cdd_abono)
                .AddWithValue("@cdd_saldo", ent.Cdd_saldo)
                .AddWithValue("@ccd_mora", ent.Cdd_mora)
                .AddWithValue("@cdd_estado", ent.Cdd_estado)
                .AddWithValue("@id_caja", ent.Cdd_caja)
            End With
            scmd.Parameters.AddWithValue("@cdd_id", ent.Cdd_id)
            scmd.ExecuteNonQuery()
            MsgBox("Pago Realizado Con Éxito!", MsgBoxStyle.Information, "Mortal Burguer")

        Catch ex As Exception
            MsgBox("Error al actualizar", MsgBoxStyle.Exclamation, "Vuelva a Intentar!")
        Finally
            scn.Close()
            scn.Dispose()
            scmd.Dispose()
        End Try
        Return scmd
    End Function

End Class
