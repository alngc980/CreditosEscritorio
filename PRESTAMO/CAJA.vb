


Imports System.Data.SqlClient
Imports Capa_Datos

Public Class CAJA

    Dim scn As New SqlConnection
    Dim cn As New conexion
    Dim sda As New SqlDataAdapter
    Dim dt As New DataTable
    Dim ds As New DataSet
    Private Sub CAJA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()
        Cargar_Datos_Montos()
    End Sub

    Sub listar()
        CargarList_caja(dgvcaja)
        dgvcaja.Columns(0).Visible = False
    End Sub
    Sub limpiar()
        txtcobrado.Clear()
        txtmontocaja.Clear()
        txtmontocaja.Focus()
    End Sub

    Public Sub Cargar_Datos_Montos()
        Try
            scn = cn.conectar
            scn.Open()
            Dim comand As SqlCommand
            comand = New SqlCommand("exec list_caja", scn)
            sda = New SqlDataAdapter(comand)
            Dim dt As New DataTable()
            sda.Fill(dt)
            If dt.Rows.Count > 0 Then
                txtmontocaja.Text = dt.Rows(0)(2).ToString()
                txtcobrado.Text = dt.Rows(0)(3).ToString()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function GuardarCaja()
        Try
            scn = cn.conectar
            scn.Open()
            sda = New SqlDataAdapter("Guardar_Caja", scn)
            sda.SelectCommand.CommandType = CommandType.StoredProcedure
            With sda.SelectCommand.Parameters
                .Add("@monto_caja", SqlDbType.VarChar).Value = txtmontocaja.Text
                .Add("@monto_cobrado", SqlDbType.VarChar).Value = txtcobrado.Text
            End With
            If sda.SelectCommand.ExecuteNonQuery() Then
                MsgBox("Registro Guardado Exitosamente!", MsgBoxStyle.Information, "MENSAJE")
            End If

        Catch ex As Exception
            MsgBox(ex)
        Finally
            scn.Close()
            scn.Dispose()
            sda.Dispose()
        End Try
        Return False
    End Function

    Public Function CargarList_caja(tabla As DataGridView)
        Try
            scn = cn.conectar
            scn.Open()
            dt.Clear()
            sda = New SqlDataAdapter("listar_caja", scn)
            sda.SelectCommand.CommandType = CommandType.StoredProcedure
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

    Private Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click
        If IsNumeric(txtcobrado.Text) And IsNumeric(txtmontocaja.Text) Then
            GuardarCaja()
        End If
        listar()
        Cargar_Datos_Montos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncerrarcaja.Click
        Dim res As DialogResult = MsgBox("¿Estas seguro de cerrar caja?", MsgBoxStyle.YesNo, Title:="MENSAJE")
        If res = DialogResult.Yes Then
            CerrarCaja("update caja set monto_caja = monto_caja + monto_cobrado where id_caja = ( select top 1 id_caja from caja order by id_caja desc)")
            CerrarCaja("update caja set monto_cobrado = 0 where id_caja = ( select top 1 id_caja from caja order by id_caja desc) ")
        End If
        listar()
        Cargar_Datos_Montos()
    End Sub

    Sub CerrarCaja(comando As String)
        Try
            scn = cn.conectar
            scn.Open()
            sda = New SqlDataAdapter(comando, scn)
            sda.SelectCommand.CommandType = CommandType.Text

            sda.SelectCommand.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex)
        Finally
            scn.Close()
            scn.Dispose()
            sda.Dispose()
            scn.Close()
        End Try
    End Sub

End Class