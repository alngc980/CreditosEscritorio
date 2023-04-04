Public Class entidad_creditodetalle
    Private _cdd_id As Integer
    Private _Id_cr_pccorrelativo As Integer
    Private _cdd_numero As Integer
    Private _cdd_fecha As DateTime
    Private _cdd_fecha_pago As DateTime
    Private _tipo_pago As String
    Private _cdd_abono As Decimal
    Private _cdd_saldo As Decimal
    Private _cdd_estado As Integer
    Private _cdd_caja As Integer
    Private _cdd_mora As Decimal

    Public Property Cdd_id As Integer
        Get
            Return _cdd_id
        End Get
        Set(value As Integer)
            _cdd_id = value
        End Set
    End Property

    Public Property Id_Cr_pccorrelativo As Integer
        Get
            Return _Id_cr_pccorrelativo
        End Get
        Set(value As Integer)
            _Id_cr_pccorrelativo = value
        End Set
    End Property

    Public Property tipo_pago As String
        Get
            Return _tipo_pago
        End Get
        Set(value As String)
            _tipo_pago = value
        End Set
    End Property

    Public Property Cdd_abono As Decimal
        Get
            Return _cdd_abono
        End Get
        Set(value As Decimal)
            _cdd_abono = value
        End Set
    End Property

    Public Property Cdd_saldo As Decimal
        Get
            Return _cdd_saldo
        End Get
        Set(value As Decimal)
            _cdd_saldo = value
        End Set
    End Property

    Public Property Cdd_fecha As Date
        Get
            Return _cdd_fecha
        End Get
        Set(value As Date)
            _cdd_fecha = value
        End Set
    End Property

    Public Property Cdd_numero As Integer
        Get
            Return _cdd_numero
        End Get
        Set(value As Integer)
            _cdd_numero = value
        End Set
    End Property

    Public Property Cdd_estado As Integer
        Get
            Return _cdd_estado
        End Get
        Set(value As Integer)
            _cdd_estado = value
        End Set
    End Property

    Public Property Cdd_caja As Integer
        Get
            Return _cdd_caja
        End Get
        Set(value As Integer)
            _cdd_caja = value
        End Set
    End Property

    Public Property Cdd_fecha_pago As Date
        Get
            Return _cdd_fecha_pago
        End Get
        Set(value As Date)
            _cdd_fecha_pago = value
        End Set
    End Property

    Public Property Cdd_mora As Decimal
        Get
            Return _cdd_mora
        End Get
        Set(value As Decimal)
            _cdd_mora = value
        End Set
    End Property
End Class
