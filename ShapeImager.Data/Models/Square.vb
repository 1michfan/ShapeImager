Public Class Square
    Inherits Equilateral
    Public Sub New()

    End Sub

    Public Sub New(orientation As Decimal, sideLength As Decimal)
        MyBase.Orientation = orientation
        MyBase.SideLength = sideLength
    End Sub

    Public Overrides Property Sides As Integer = 4

    Public Overrides ReadOnly Property Area As Decimal
        Get
            Return 0
        End Get
    End Property

    Public Overrides ReadOnly Property Perimeter As Decimal
        Get
            Return 0
        End Get
    End Property
End Class
