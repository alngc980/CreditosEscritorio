Imports System.Data.SqlClient
Imports Capa_Datos
Imports Capa_Entidad
Public Class Clientes
    Dim scn As New SqlConnection
    Dim cn As New conexion
    Dim datos As New datos_clientes
    Dim entidad As New entidad_cliente
    Public cod, numero, nombres, direccion, garante, garantia As String

    Sub listar()
        dgvclientes.DataSource = datos.listar_cliente.Tables("clientes")
        dgvclientes.Columns(0).Visible = False
        dgvclientes.Columns(1).Width = 70
        dgvclientes.Columns(2).Width = 200
        dgvclientes.Columns(3).Width = 100
        dgvclientes.Columns(4).Width = 30
        dgvclientes.Columns(5).Width = 200
        dgvclientes.Columns(6).Width = 100

        dgvclientes.Columns(7).Width = 200
        dgvclientes.Columns(8).Width = 200
        dgvclientes.Columns(9).Width = 100
        dgvclientes.Columns(10).Width = 200

        dgvclientes.RowHeadersVisible = False
        'dgvclientes.ColumnHeadersVisible = False
    End Sub
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()

        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(btnregistrarCliente, "Registra un Cliente!")

        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.SetToolTip(btnactualizarCliente, "Actualiza registro de Cliente!")

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        entidad.Cli_razon = txtbuscar.Text
        datos.buscar_cliente(entidad, dgvclientes)
    End Sub

    Sub buscarcliente()
        Try
            If dgvclientes.Rows.Count > 0 Then

                Dim sda As New SqlDataAdapter
                scn = cn.conectar
                scn.Open()
                Dim comand As SqlCommand
                comand = New SqlCommand("select top(1) c_id,c.cli_id,uso_lentes2,años2,od2,oi2,addd2,dip2,recomend2,
		c_fecha,od_esf,od_cil,od_eje,od_dip,id_esf,id_cil,id_eje,id_dip,addd,
		pio_od5,pio_oi5,pio_od10,pio_oi10,quera_od1,quera_od2,quera_oi1,quera_oi2,
		recomendaciones,sp.esp_nombre,sp.esp_id 
		from consultorio as c inner join clientes as cl on cl.cli_id=c.cli_id inner join especialista as sp on sp.esp_id=c.esp_id 
		where c.cli_id='" + (dgvclientes.Rows(dgvclientes.CurrentRow.Index).Cells(0).Value).ToString + "' order by c_id desc", scn)
                sda = New SqlDataAdapter(comand)
                Dim dt As New DataTable()
                sda.Fill(dt)
                If dt.Rows.Count() > 0 Then
                    'Consultorio.MdiParent = PRINCIPAL

                Else
                    MsgBox("El cliente no tiene registros", MsgBoxStyle.Information, Title:="Mensaje")
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub btnregistrarCliente_Click(sender As Object, e As EventArgs) Handles btnregistrarCliente.Click
        'Clientes_Mantenimiento.MdiParent = PRINCIPAL
        Clientes_Mantenimiento.limpiar()
        Clientes_Mantenimiento.btnregistrar.Visible = True
        Clientes_Mantenimiento.btnmodificar.Visible = False
        Clientes_Mantenimiento.generarCliente()
        Clientes_Mantenimiento.ShowDialog()
        listar()
    End Sub

    Private Sub dgvclientes_DoubleClick(sender As Object, e As EventArgs) Handles dgvclientes.DoubleClick
        Try
            cod = (dgvclientes.Rows(dgvclientes.CurrentRow.Index).Cells(0).Value).ToString
            numero = (dgvclientes.Rows(dgvclientes.CurrentRow.Index).Cells(1).Value).ToString

            nombres = (dgvclientes.Rows(dgvclientes.CurrentRow.Index).Cells(2).Value).ToString
            direccion = (dgvclientes.Rows(dgvclientes.CurrentRow.Index).Cells(5).Value).ToString

            garante = (dgvclientes.Rows(dgvclientes.CurrentRow.Index).Cells(7).Value).ToString
            garantia = (dgvclientes.Rows(dgvclientes.CurrentRow.Index).Cells(10).Value).ToString


            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnactualizarCliente_Click(sender As Object, e As EventArgs) Handles btnactualizarCliente.Click
        If dgvclientes.Rows.Count <> 0 Then
            'Clientes_Mantenimiento.MdiParent = PRINCIPAL
            Clientes_Mantenimiento.limpiar()
            Clientes_Mantenimiento.txtid.Text = (dgvclientes.Rows(dgvclientes.CurrentRow.Index).Cells(0).Value).ToString
            Clientes_Mantenimiento.txtnumero.Text = (dgvclientes.Rows(dgvclientes.CurrentRow.Index).Cells(1).Value).ToString
            Clientes_Mantenimiento.txtnombre.Text = (dgvclientes.Rows(dgvclientes.CurrentRow.Index).Cells(2).Value).ToString
            Clientes_Mantenimiento.txtocupacion.Text = (dgvclientes.Rows(dgvclientes.CurrentRow.Index).Cells(3).Value).ToString
            Clientes_Mantenimiento.cbsexo.Text = (dgvclientes.Rows(dgvclientes.CurrentRow.Index).Cells(4).Value).ToString
            Clientes_Mantenimiento.txtdireccion.Text = (dgvclientes.Rows(dgvclientes.CurrentRow.Index).Cells(5).Value).ToString
            Clientes_Mantenimiento.txttelefono.Text = (dgvclientes.Rows(dgvclientes.CurrentRow.Index).Cells(6).Value).ToString

            Clientes_Mantenimiento.txtnombreg.Text = (dgvclientes.Rows(dgvclientes.CurrentRow.Index).Cells(7).Value).ToString
            Clientes_Mantenimiento.txtdirecciong.Text = (dgvclientes.Rows(dgvclientes.CurrentRow.Index).Cells(8).Value).ToString
            Clientes_Mantenimiento.txttelefonog.Text = (dgvclientes.Rows(dgvclientes.CurrentRow.Index).Cells(9).Value).ToString
            Clientes_Mantenimiento.txtgarantia.Text = (dgvclientes.Rows(dgvclientes.CurrentRow.Index).Cells(10).Value).ToString

            Clientes_Mantenimiento.btnregistrar.Visible = False
            Clientes_Mantenimiento.btnmodificar.Visible = True
            Clientes_Mantenimiento.ShowDialog()
        End If
        listar()
    End Sub


End Class