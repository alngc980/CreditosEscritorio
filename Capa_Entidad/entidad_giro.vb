Public Class entidad_giro
    Private _id As String
    Private _emisor_origen As String
    Private _emisor_dni As String
    Private _emisor_nombre As String
    Private _destino_origen As String
    Private _destino_dni As String
    Private _destino_nombre As String
    Private _monto_giro As Decimal
    Private _monto_comision As Decimal
    Private _codigo_retiro As String

    Public Property Id As String
        Get
            Return _id
        End Get
        Set(value As String)
            _id = value
        End Set
    End Property

    Public Property Emisor_origen As String
        Get
            Return _emisor_origen
        End Get
        Set(value As String)
            _emisor_origen = value
        End Set
    End Property

    Public Property Emisor_dni As String
        Get
            Return _emisor_dni
        End Get
        Set(value As String)
            _emisor_dni = value
        End Set
    End Property

    Public Property Emisor_nombre As String
        Get
            Return _emisor_nombre
        End Get
        Set(value As String)
            _emisor_nombre = value
        End Set
    End Property

    Public Property Destino_origen As String
        Get
            Return _destino_origen
        End Get
        Set(value As String)
            _destino_origen = value
        End Set
    End Property

    Public Property Destino_dni As String
        Get
            Return _destino_dni
        End Get
        Set(value As String)
            _destino_dni = value
        End Set
    End Property

    Public Property Destino_nombre As String
        Get
            Return _destino_nombre
        End Get
        Set(value As String)
            _destino_nombre = value
        End Set
    End Property

    Public Property Monto_giro As Decimal
        Get
            Return _monto_giro
        End Get
        Set(value As Decimal)
            _monto_giro = value
        End Set
    End Property

    Public Property Monto_comision As Decimal
        Get
            Return _monto_comision
        End Get
        Set(value As Decimal)
            _monto_comision = value
        End Set
    End Property

    Public Property Codigo_retiro As String
        Get
            Return _codigo_retiro
        End Get
        Set(value As String)
            _codigo_retiro = value
        End Set
    End Property
End Class
