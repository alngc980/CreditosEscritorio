Public Class EntidadInicioSesion
    Private _is_id As Integer
    Private _u_id As String
    Private _fec_hor_inicio As Date
    Private _fec_hor_salida As Date
    Private _inicio_caja As Decimal
    Private _caja_ventas As Decimal
    Private _caja_gastos As Decimal
    Private _caja_final As Decimal
    Private _caja_sobrantes As Decimal
    Private _caja_faltantes As Decimal
    Private _vendedor_id As String


    Public Property U_id As String
        Get
            Return _u_id
        End Get
        Set(value As String)
            _u_id = value
        End Set
    End Property

    Public Property Fec_hor_inicio As Date
        Get
            Return _fec_hor_inicio
        End Get
        Set(value As Date)
            _fec_hor_inicio = value
        End Set
    End Property

    Public Property Fec_hor_salida As Date
        Get
            Return _fec_hor_salida
        End Get
        Set(value As Date)
            _fec_hor_salida = value
        End Set
    End Property

    Public Property Inicio_caja As Decimal
        Get
            Return _inicio_caja
        End Get
        Set(value As Decimal)
            _inicio_caja = value
        End Set
    End Property

    Public Property Caja_ventas As Decimal
        Get
            Return _caja_ventas
        End Get
        Set(value As Decimal)
            _caja_ventas = value
        End Set
    End Property

    Public Property Caja_gastos As Decimal
        Get
            Return _caja_gastos
        End Get
        Set(value As Decimal)
            _caja_gastos = value
        End Set
    End Property

    Public Property Caja_final As Decimal
        Get
            Return _caja_final
        End Get
        Set(value As Decimal)
            _caja_final = value
        End Set
    End Property

    Public Property Caja_sobrantes As Decimal
        Get
            Return _caja_sobrantes
        End Get
        Set(value As Decimal)
            _caja_sobrantes = value
        End Set
    End Property

    Public Property Caja_faltantes As Decimal
        Get
            Return _caja_faltantes
        End Get
        Set(value As Decimal)
            _caja_faltantes = value
        End Set
    End Property

    Public Property Is_id As Integer
        Get
            Return _is_id
        End Get
        Set(value As Integer)
            _is_id = value
        End Set
    End Property

    Public Property Vendedor_id As String
        Get
            Return _vendedor_id
        End Get
        Set(value As String)
            _vendedor_id = value
        End Set
    End Property
End Class
