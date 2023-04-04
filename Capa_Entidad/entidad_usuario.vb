Public Class entidad_usuario
    Private _usu_id As String
    Private _usu_dni As String
    Private _usu_nombre As String
    Private _usu_direccion As String
    Private _usu_telefono As String
    Private _usu_usuario As String
    Private _usu_clave As String
    Private _tipo_id As Integer

    Public Property Usu_id As String
        Get
            Return _usu_id
        End Get
        Set(value As String)
            _usu_id = value
        End Set
    End Property

    Public Property Usu_dni As String
        Get
            Return _usu_dni
        End Get
        Set(value As String)
            _usu_dni = value
        End Set
    End Property

    Public Property Usu_nombre As String
        Get
            Return _usu_nombre
        End Get
        Set(value As String)
            _usu_nombre = value
        End Set
    End Property

    Public Property Usu_direccion As String
        Get
            Return _usu_direccion
        End Get
        Set(value As String)
            _usu_direccion = value
        End Set
    End Property

    Public Property Usu_telefono As String
        Get
            Return _usu_telefono
        End Get
        Set(value As String)
            _usu_telefono = value
        End Set
    End Property

    Public Property Usu_usuario As String
        Get
            Return _usu_usuario
        End Get
        Set(value As String)
            _usu_usuario = value
        End Set
    End Property

    Public Property Usu_clave As String
        Get
            Return _usu_clave
        End Get
        Set(value As String)
            _usu_clave = value
        End Set
    End Property

    Public Property Tipo_id As Integer
        Get
            Return _tipo_id
        End Get
        Set(value As Integer)
            _tipo_id = value
        End Set
    End Property
End Class
