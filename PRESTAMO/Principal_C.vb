Imports System.Data.SqlClient
Imports Capa_Datos
Imports Capa_Entidad
Public Class Principal_C
    Dim scn As New SqlConnection
    Dim cn As New conexion

    Dim datos_inicio_sesion As New DatosIniciosesion

    Dim datos_vendedores As New datos_vendedores


    Dim datoscredito As New datos_credito
    Dim entidadcredito As New entidad_credito
    Dim entidad As New entidad_credito
    Dim datos As New datos_credito

    Public cod_user As String

    Private Sub Principal_C_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EjecutarBusqueda("")

        totalCobrar()
        CapitalCobrar()

        'If Hay_Internet() Then
        '    MsgBox("HAY INTERNET")
        'Else
        '    MsgBox("HAY INTERNEadfsdfgsdfghsdfgsjdfhgdkljsfhgkjsdfhgkljdfT")
        'End If
    End Sub

    Sub totalCobrar()
        Dim total As Decimal = 0
        For Renglones As Integer = 0 To dgvlista.RowCount - 1
            total = total + Convert.ToDecimal(dgvlista.Item(9, Renglones).Value)
        Next
        lbltotal.Text = total
    End Sub

    Sub CapitalCobrar()
        Dim capital As Decimal = 0
        For Renglones As Integer = 0 To dgvlista.RowCount - 1
            capital = capital + Convert.ToDecimal(dgvlista.Item(5, Renglones).Value)
        Next
        lblcapitalprestado.Text = capital
    End Sub

    Private Sub btnclientes_Click(sender As Object, e As EventArgs)
        'Dim clientes As New Clientes
        'clientes.ShowDialog()
    End Sub


    Private Sub Principal_C_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Txtusuario.Clear()
        Login.txtcontraseña.Clear()
        Login.Txtusuario.Focus()
        Login.Show()
    End Sub

    Private Sub btnimprimirpagos_Click(sender As Object, e As EventArgs) Handles btnimprimirpagos.Click
        Try
            Dim id As String = (dgvlista.Rows(dgvlista.CurrentRow.Index).Cells(0).Value).ToString
            If IsNumeric(id) Then
                Dim pago As New Reporte_Credito
                pago.idcaja = 1 'lblcodcaja.Text
                pago.lblid.Text = (dgvlista.Rows(dgvlista.CurrentRow.Index).Cells(0).Value).ToString
                pago.lblnombrecliente.Text = (dgvlista.Rows(dgvlista.CurrentRow.Index).Cells(4).Value).ToString
                pago.lbldineroprestado.Text = (dgvlista.Rows(dgvlista.CurrentRow.Index).Cells(5).Value).ToString
                pago.interes = (dgvlista.Rows(dgvlista.CurrentRow.Index).Cells(6).Value).ToString
                pago.lbltotal.Text = (dgvlista.Rows(dgvlista.CurrentRow.Index).Cells(8).Value).ToString
                pago.lblgarante.Text = (dgvlista.Rows(dgvlista.CurrentRow.Index).Cells(10).Value).ToString
                pago.ShowDialog()
            Else
                MsgBox("SELECCIONE UN PRESTAMO DE LA LISTA", MsgBoxStyle.OkOnly, Title:="MENSAJE")
            End If
        Catch ex As Exception
            MsgBox("SELECCIONE UN PRESTAMO DE LA LISTA", MsgBoxStyle.OkOnly, Title:="MENSAJE")
        End Try
        TextBox1.Text = "a"
        TextBox1.Text = ""
    End Sub

    Function Hay_Internet() As Boolean
        If My.Computer.Network.IsAvailable Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
        Try
            If dgvlista.Rows.Count > 0 Then
                Dim total As Decimal = Convert.ToDecimal((dgvlista.Rows(dgvlista.CurrentRow.Index).Cells(6).Value).ToString)
                If total > 0 Then
                    Try
                        Cursor = Cursors.WaitCursor
                        Reporte_Pc_A5.NUMERO = "1"
                        Reporte_Pc_A5.var = (dgvlista.Rows(dgvlista.CurrentRow.Index).Cells(0).Value).ToString
                        Reporte_Pc_A5.ShowDialog()
                    Catch ex As Exception
                        Throw ex
                    End Try
                    Cursor = Cursors.Default
                Else
                    MsgBox("PROBABLEMENTE EL PRESATAMO FUE ANULADA!", MsgBoxStyle.OkOnly, Title:="MENSAJE DE INFORMACION")
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btnuevo.Click
        Dim asd As New Nuevo_Credito
        asd.ShowDialog()

        'datos.listar_credito(dgvlista)
        EjecutarBusqueda(TextBox1.Text)
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        EjecutarBusqueda(TextBox1.Text)
    End Sub
    Sub EjecutarBusqueda(stri As String)
        entidad.Cr_pccorrelativo = stri
        datos.buscar_credito_detalle(entidad, dgvlista)
        dgvlista.Columns(0).Visible = False
        dgvlista.Columns(10).Visible = False

        totalCobrar()
        CapitalCobrar()
    End Sub

    Private Sub btncompromisodepago_Click(sender As Object, e As EventArgs) Handles btncompromisodepago.Click
        Dim asd As New Reportes
        asd.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim asd As New Giros
        asd.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim caja As New CAJA
        caja.ShowDialog()
    End Sub
End Class