Imports System.Data.SqlClient
Imports System.Configuration
Public Class conexion
    Dim conexion As SqlConnection

    'CADENAS DE CONEXION DE LA APLICACION
    Public ServerName As String = "SERVER"  '192.168.43.189, 1433
    Public DataBaseName As String = "Sis_optica"
    Public UserID As String = ""
    Public Password As String = ""
    Public IntSec As Boolean = True

    'SERVER=SERVER; DATABASE=Sis_optica_Grand; Integrated Security=true
    Function ObtenerCadena() As String
        Dim Cadena As String = ""
        Cadena = "SERVER=" + ServerName + "; "
        Cadena = Cadena + "DATABASE=" + DataBaseName + "; "
        If UserID <> "" Then
            Cadena = Cadena + "User ID=" + UserID + "; "
        End If
        If Password <> "" Then
            Cadena = Cadena + "Password=" + Password + "; "
        End If
        If IntSec Then
            Cadena = Cadena + "Integrated Security=true"
        Else
            Cadena = Cadena + "Integrated Security=false"
        End If
        Return Cadena
    End Function

    Public Function conectar() As SqlConnection
        conexion = New SqlConnection(ObtenerCadena())
        Return conexion
    End Function

    'OTRAS VARIABLES PUBLICAS USADAS

    Public GenTxtBOL As Boolean = False
    Public GenTxtFAC As Boolean = True

End Class
