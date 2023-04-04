Imports System.Data.SqlClient
Imports Capa_Datos
Imports Capa_Entidad
Public Class Clientes_Mantenimiento
    Dim scn As New SqlConnection
    Dim cn As New conexion
    Dim sda As New SqlDataAdapter

    Dim datos As New datos_clientes
    Dim entidad As New entidad_cliente

    Public Sub generarCliente()
        Try
            Dim r As String
            r = "CLI000000"
            txtid.Text = r & datos.generar_clientes

            If datos.generar_clientes > 9 Then
                r = "CLI00000"
                txtid.Text = r & datos.generar_clientes
            End If

            If datos.generar_clientes > 99 Then
                r = "CLI0000"
                txtid.Text = r & datos.generar_clientes
            End If

            If datos.generar_clientes > 999 Then
                r = "CLI000"
                txtid.Text = r & datos.generar_clientes
            End If
            If datos.generar_clientes > 9999 Then
                r = "CLI00"
                txtid.Text = r & datos.generar_clientes
            End If

            If datos.generar_clientes > 99999 Then
                r = "CLI0"
                txtid.Text = r & datos.generar_clientes
            End If

            If datos.generar_clientes > 999999 Then
                r = "CLI"
                txtid.Text = r & datos.generar_clientes
            End If
        Catch ex As Exception
            MsgBox("LLAMA AL PROGRAMADOR")
        End Try
    End Sub

    Private Sub btnregistrar_Click(sender As Object, e As EventArgs) Handles btnregistrar.Click
        If txtnumero.Text = "" Or txtnombre.Text = "" Then
            MsgBox("Es Necesario llenar algunos campos!", MsgBoxStyle.Information, Title:="Mensaje")
        Else
            entidad.Cli_id = txtid.Text
            entidad.Cli_numero = txtnumero.Text
            entidad.Cli_razon = txtnombre.Text
            entidad.Cli_ocupacion = txtocupacion.Text
            entidad.Cli_sexo = cbsexo.Text
            entidad.Cli_direccion = txtdireccion.Text
            entidad.Cli_telefono = txttelefono.Text

            entidad.Nombre = txtnombreg.Text
            entidad.Direccion = txtdirecciong.Text
            entidad.Telefono = txttelefonog.Text
            entidad.Garantia = txtgarantia.Text
            datos.registrar_cliente(entidad)
            Clientes.listar()
            Me.Close()
        End If
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        If txtnumero.Text = "" Or txtnombre.Text = "" Then
            MsgBox("Es Necesario llenar algunos campos!", MsgBoxStyle.Information, Title:="Mensaje")
        Else
            entidad.Cli_id = txtid.Text
            entidad.Cli_numero = txtnumero.Text
            entidad.Cli_razon = txtnombre.Text
            entidad.Cli_ocupacion = txtocupacion.Text
            entidad.Cli_sexo = cbsexo.Text
            entidad.Cli_direccion = txtdireccion.Text
            entidad.Cli_telefono = txttelefono.Text

            entidad.Nombre = txtnombreg.Text
            entidad.Direccion = txtdirecciong.Text
            entidad.Telefono = txttelefonog.Text
            entidad.Garantia = txtgarantia.Text
            datos.actualizar_cliente(entidad)
            Clientes.listar()
            Me.Close()
        End If
    End Sub

    Sub limpiar()
        txtid.Clear()
        txtnumero.Clear()
        txtnombre.Clear()
        txtocupacion.Clear()
        cbsexo.Text = "M"
        txtdireccion.Clear()
        txttelefono.Clear()

        txtnombreg.Clear()
        txtdirecciong.Clear()
        txttelefonog.Clear()
        txtgarantia.Clear()
    End Sub

    Public Sub buscarcliente(dni_cliente As String)
        Try
            scn = cn.conectar
            scn.Open()
            Dim comand As SqlCommand
            If dni_cliente = "" Then
                MsgBox("Seleccione un cliente", MsgBoxStyle.Information, Title:="Mensaje")
            Else
                comand = New SqlCommand("select cli_id, cli_razon, cli_direccion from clientes where cli_numero='" & dni_cliente & "'", scn)

                sda = New SqlDataAdapter(comand)
                Dim dt As New DataTable()

                sda.Fill(dt)

                If dt.Rows.Count() > 0 Then
                    txtid.Text = dt.Rows(0)(0).ToString()
                    txtnombre.Text = dt.Rows(0)(1).ToString()
                    txtdireccion.Text = dt.Rows(0)(2).ToString()
                Else
                    txtid.Text = ""
                    txtnombre.Text = ""
                    txtdireccion.Text = ""
                    MsgBox("Cliente no encontrado!", MsgBoxStyle.Critical, Title:="Mensaje")
                End If

            End If
        Catch ex As Exception
            Throw ex
        Finally
            scn.Close()
        End Try
    End Sub

    Private Sub txtdnig_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Clientes_Mantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class