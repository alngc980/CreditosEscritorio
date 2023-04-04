Public Class Reportes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case ComboBox1.Text
            Case "REPORTE DE CLIENTE"
                Dim asd As New Reporte_Pc_A5
                asd.NUMERO = "3"
                asd.var = ""
                asd.ShowDialog()
            Case "REPORTE DE CLIENTES AL DIA"
                Dim asd As New Reporte_Pc_A5
                asd.NUMERO = "4"
                asd.var = ""
                asd.ShowDialog()
            Case "REPORTE DE CLIENTE MOROSOS"
                Dim asd As New Reporte_Pc_A5
                asd.NUMERO = "5"
                asd.var = ""
                asd.ShowDialog()
            Case "REPORTE DE PAGOS"
                Dim asd As New Reporte_Pc_A5
                asd.NUMERO = "09"
                asd.fec1 = DateTimePicker1.Text
                asd.fec2 = DateTimePicker2.Text
                asd.ShowDialog()

            Case "REPORTE DE GIROS"
                Dim asd As New Reporte_Pc_A5
                asd.NUMERO = "11"
                asd.fec1 = DateTimePicker1.Text
                asd.fec2 = DateTimePicker2.Text
                asd.ShowDialog()

            Case Else
                MsgBox("seleccione un Reporte")
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "REPORTE DE CLIENTE"
                Label2.Visible = False
                Label3.Visible = False
                DateTimePicker1.Visible = False
                DateTimePicker2.Visible = False
            Case "REPORTE DE CLIENTES AL DIA"
                Label2.Visible = False
                Label3.Visible = False
                DateTimePicker1.Visible = False
                DateTimePicker2.Visible = False
            Case "REPORTE DE CLIENTE MOROSOS"
                Label2.Visible = False
                Label3.Visible = False
                DateTimePicker1.Visible = False
                DateTimePicker2.Visible = False
            Case "REPORTE DE GIROS"
                Label2.Visible = True
                Label3.Visible = True
                DateTimePicker1.Visible = True
                DateTimePicker2.Visible = True
        End Select
    End Sub
End Class