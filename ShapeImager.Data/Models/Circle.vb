Public Class Circle
    Inherits Ellipse
    Public Sub New()

    End Sub
    Public Sub New(centerX As Decimal, centerY As Decimal, radius As Decimal)
        MyBase.New(centerX, centerY, 0, radius, radius)
    End Sub

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
