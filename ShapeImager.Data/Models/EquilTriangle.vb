Public Class EquilTriangle
    Inherits Equilateral

    ReadOnly _sides As Integer = 3
    Public Sub New()

    End Sub
    Public Sub New(centerX As Decimal, centerY As Decimal, sideLength As Decimal, orientation As Decimal)
        Center = New Vertice(centerX, centerY)
        MyBase.Orientation = orientation
        MyBase.SideLength = sideLength
    End Sub

    Public Overrides ReadOnly Property Area As Decimal
        Get
            Return 0.25 * Math.Sqrt(3) * Math.Pow(SideLength, 2)
        End Get
    End Property

    Public Overrides ReadOnly Property Perimeter As Decimal
        Get
            Return SideLength * _sides
        End Get
    End Property
End Class
