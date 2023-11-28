Public Class Product

    Private _id As Integer
    Private _name As String
    Private _description As String
    Private _price As Double
    Private _isIVA As Boolean

    Public Sub New()

    End Sub

    Public Sub New(id As Integer, name As String, description As String, price As Double, isIVA As Boolean)
        Me.Id = id
        Me.Name = name
        Me.Description = description
        Me.Price = price
        Me.IsIVA = isIVA
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Public Property Price As Double
        Get
            Return _price
        End Get
        Set(value As Double)
            _price = value
        End Set
    End Property

    Public Property IsIVA As Boolean
        Get
            Return _isIVA
        End Get
        Set(value As Boolean)
            _isIVA = value
        End Set
    End Property

    Public Function GetIVA() As Double
        If IsIVA Then
            Return Price * 0.15
        Else
            Return 0
        End If
    End Function

    Public Function GetAmount() As Double
        Return Price + GetIVA()
    End Function

End Class
