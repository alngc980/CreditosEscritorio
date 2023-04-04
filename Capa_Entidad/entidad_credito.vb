Public Class entidad_credito
    Private _id As Integer
    Private _cr_pccorrelativo As String
    Private _cr_fecha As DateTime
    Private _usu_id As String
    Private _cli_id As String
    Private _cr_monto As Decimal
    Private _cr_interes As Decimal
    Private _cr_moraTotal As Decimal
    Private _cr_total As Decimal
    Private _cv_id As Integer
    Private _vendedor As String
    Private _id_caja As Integer

    Public Property Cr_pccorrelativo As String
        Get
            Return _cr_pccorrelativo
        End Get
        Set(value As String)
            _cr_pccorrelativo = value
        End Set
    End Property
    Public Property Usu_id As String
        Get
            Return _usu_id
        End Get
        Set(value As String)
            _usu_id = value
        End Set
    End Property

    Public Property Cli_id As String
        Get
            Return _cli_id
        End Get
        Set(value As String)
            _cli_id = value
        End Set
    End Property

    Public Property Cr_total As Decimal
        Get
            Return _cr_total
        End Get
        Set(value As Decimal)
            _cr_total = value
        End Set
    End Property

    Public Property Cr_fecha As Date
        Get
            Return _cr_fecha
        End Get
        Set(value As Date)
            _cr_fecha = value
        End Set
    End Property

    Public Property Cv_id As Integer
        Get
            Return _cv_id
        End Get
        Set(value As Integer)
            _cv_id = value
        End Set
    End Property

    Public Property Vendedor As String
        Get
            Return _vendedor
        End Get
        Set(value As String)
            _vendedor = value
        End Set
    End Property

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Id_caja As Integer
        Get
            Return _id_caja
        End Get
        Set(value As Integer)
            _id_caja = value
        End Set
    End Property

    Public Property Cr_monto As Decimal
        Get
            Return _cr_monto
        End Get
        Set(value As Decimal)
            _cr_monto = value
        End Set
    End Property

    Public Property Cr_interes As Decimal
        Get
            Return _cr_interes
        End Get
        Set(value As Decimal)
            _cr_interes = value
        End Set
    End Property

    Public Property Cr_moraTotal As Decimal
        Get
            Return _cr_moraTotal
        End Get
        Set(value As Decimal)
            _cr_moraTotal = value
        End Set
    End Property
End Class
