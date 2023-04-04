Imports System.Data.SqlClient
Imports Capa_Datos
Public Class Login
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult
        result = MessageBox.Show("¿Desea salir del Login Usuario?", "Sistema Prestamos", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
        If result = DialogResult.OK Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Dim codigo, pass, sql As String
        Dim com As SqlCommand, dr As SqlDataReader
        Dim scn As New SqlConnection
        Dim cn As New conexion
        scn = cn.conectar
        Try
            scn.Open()
            codigo = Txtusuario.Text
            pass = txtcontraseña.Text
            If Txtusuario.Text <> "" And txtcontraseña.Text <> "" Then
                sql = "select * from Usuarios where usu_usuario='" & Txtusuario.Text & "' and usu_clave='" & txtcontraseña.Text & "'"
                com = New SqlClient.SqlCommand(sql, scn)
                dr = com.ExecuteReader
                If dr.Read Then
                    If codigo = dr(5) Then
                        If pass = dr(6) Then
                            Principal_C.cod_user = dr(0)
                            'Principal.lblusuario.Text = "USUARIO: " & Convert.ToString(dr(2))
                            'If dr(7) = 1 Then
                            '    ''todos los permisos
                            'Else
                            '    'Principal.RibbonButton6.Enabled = False
                            '    Principal.RibbonButton7.Enabled = False
                            '    Principal.RibbonButton8.Enabled = False
                            '    Principal.RibbonButton9.Enabled = False
                            '    Principal.RibbonButton10.Enabled = False
                            '    Principal.RibbonButton12.Enabled = False
                            '    Principal.RibbonButton13.Enabled = False
                            '    Principal.RibbonButton14.Enabled = False
                            '    Principal.RibbonButton15.Enabled = False
                            '    Principal.RibbonButton16.Enabled = False
                            '    Principal.RibbonButton17.Enabled = False
                            'End If
                            Principal_C.Show()
                            Me.Hide()
                        Else
                            MsgBox("CONTRASEÑA INCORRECTA")
                            txtcontraseña.Focus()
                        End If
                    Else
                        MsgBox("DATOS INCORRECTOS")
                        Txtusuario.Focus()
                    End If
                Else
                    MsgBox("VERIFICA TUS DATOS", Title:="MENSAJE")
                    Txtusuario.Focus()
                End If
            Else
                MsgBox("LLENE TODOS LOS CAMPOS", MsgBoxStyle.Exclamation, Title:="MENSAJE")
                Txtusuario.Focus()
            End If
            scn.Close()
            scn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, Title:="ERROR DE CONEXION!")
            MsgBox("LLAME AL PROGRAMADOR URGENTE!", Title:="ERROR DE CONEXION!")
            ''MsgBox("No hay conexion a la base de datos", Title:="Error")
        End Try

    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.ExitThread()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txtusuario.Focus()
    End Sub

    Private Sub Txtusuario_KeyDown(sender As Object, e As KeyEventArgs) Handles Txtusuario.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btningresar.PerformClick()
        End Select
    End Sub

    Private Sub txtcontraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcontraseña.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btningresar.PerformClick()
        End Select
    End Sub


End Class