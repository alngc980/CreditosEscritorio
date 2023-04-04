Imports System.Data.SqlClient
Imports Capa_Datos

Public Class MontoLibre
    Dim scn As New SqlConnection
    Dim cn As New conexion
    Dim sda As New SqlDataAdapter
    Dim d_cred As New datos_credito

    Public credito As Integer
    Public EJEC As Boolean = False
    Private Sub MontoLibre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos(credito)
    End Sub

    Sub CargarDatos(id As Integer)

        Try
            scn = cn.conectar
            scn.Open()
            Dim comand As SqlCommand
            comand = New SqlCommand("exec Obtener_Deuda_total " & id, scn)

            sda = New SqlDataAdapter(comand)
            Dim dt As New DataTable()

            sda.Fill(dt)

            If dt.Rows.Count() > 0 Then
                txtmora.Text = dt.Rows(0)(0).ToString()
                txtdeuda.Text = dt.Rows(0)(1).ToString()
                txtsuma.Text = CDec(dt.Rows(0)(0).ToString()) + CDec(dt.Rows(0)(1).ToString())
            Else
                MsgBox("ERROR AL CARGAR DATOS", MsgBoxStyle.Critical, Title:="Mensaje")
                Me.Close()
            End If

        Catch ex As Exception
            Throw ex
        Finally
            scn.Close()
        End Try

    End Sub

    Private Sub btnpagar_Click(sender As Object, e As EventArgs) Handles btnpagar.Click
        If IsNumeric(txtmontopagar.Text) Then
            If CDec(txtmontopagar.Text) <= CDec(txtsuma.Text) Then
                Dim vuelto As Decimal
                vuelto = d_cred.Distribucion_monto(credito, txtmontopagar.Text)

                If vuelto > 0 Then
                    MsgBox("VUELTO :" & vuelto.ToString, MsgBoxStyle.Critical, Title:="Mensaje")
                End If
                MsgBox("POR FAVOR REIMPRIME EL NUEVO CRONOGRAMA DE PAGO", MsgBoxStyle.Information, Title:="Mensaje")
                EJEC = True
                Me.Close()
            Else
                MsgBox("POR FAVOR INGRESE UN MONTO MENOR O IGUAL A LA DEUDA", MsgBoxStyle.Critical, Title:="Mensaje")
            End If
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        txtmontopagar.Text = txtsuma.Text
    End Sub
End Class
