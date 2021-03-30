Public Class Circle
    Inherits Ellipse
    Public Sub New()

    End Sub
    Public Sub New(centerX As Decimal, centerY As Decimal, radius As Decimal)
        MyBase.New(centerX, centerY, radius, radius, 0)
    End Sub

    Public Overrides ReadOnly Property Perimeter As Decimal
        Get
            Return Math.PI * 2 * Radius1
        End Get
    End Property

    Public Overrides Property Radius1 As Decimal
        Get
            Return MyBase.Radius1
        End Get
        Set(value As Decimal)
            MyBase.Radius1 = value
            MyBase.Radius2 = value
        End Set
    End Property

    Public Overrides Property Radius2 As Decimal
        Get
            Return MyBase.Radius2
        End Get
        Set(value As Decimal)
            MyBase.Radius1 = value
            MyBase.Radius2 = value
        End Set
    End Property
End Class
