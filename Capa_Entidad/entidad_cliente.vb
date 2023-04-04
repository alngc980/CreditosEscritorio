Public Class entidad_cliente
    Private _cli_id As String
    Private _cli_numero As String
    Private _cli_razon As String
    Private _cli_ocupacion As String
    Private _cli_sexo As String
    Private _cli_direccion As String
    Private _cli_telefono As String
    Private _nombre As String
    Private _direccion As String
    Private _telefono As String
    Private _garantia As String

    Public Property Cli_id As String
        Get
            Return _cli_id
        End Get
        Set(value As String)
            _cli_id = value
        End Set
    End Property

    Public Property Cli_numero As String
        Get
            Return _cli_numero
        End Get
        Set(value As String)
            _cli_numero = value
        End Set
    End Property

    Public Property Cli_razon As String
        Get
            Return _cli_razon
        End Get
        Set(value As String)
            _cli_razon = value
        End Set
    End Property

    Public Property Cli_direccion As String
        Get
            Return _cli_direccion
        End Get
        Set(value As String)
            _cli_direccion = value
        End Set
    End Property

    Public Property Cli_telefono As String
        Get
            Return _cli_telefono
        End Get
        Set(value As String)
            _cli_telefono = value
        End Set
    End Property

    Public Property Cli_ocupacion As String
        Get
            Return _cli_ocupacion
        End Get
        Set(value As String)
            _cli_ocupacion = value
        End Set
    End Property

    Public Property Cli_sexo As String
        Get
            Return _cli_sexo
        End Get
        Set(value As String)
            _cli_sexo = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Garantia As String
        Get
            Return _garantia
        End Get
        Set(value As String)
            _garantia = value
        End Set
    End Property
End Class

