Public Class entidad_tipousuario
    Private _tipo_id As Integer
    Private _tipo_nombre As String

    Public Property Tipo_id As Integer
        Get
            Return _tipo_id
        End Get
        Set(value As Integer)
            _tipo_id = value
        End Set
    End Property

    Public Property Tipo_nombre As String
        Get
            Return _tipo_nombre
        End Get
        Set(value As String)
            _tipo_nombre = value
        End Set
    End Property
End Class
