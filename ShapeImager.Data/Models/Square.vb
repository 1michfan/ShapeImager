Public Class Square
    Inherits Equilateral

    ReadOnly _sides As Integer = 4
    Public Sub New()

    End Sub

    Public Sub New(centerX As Decimal, centerY As Decimal, orientation As Decimal, sideLength As Decimal)
        Center = New Vertice(centerX, centerY)
        MyBase.Orientation = orientation
        MyBase.SideLength = sideLength
    End Sub

    Public Overrides ReadOnly Property Area As Decimal
        Get
            Return Math.Pow(SideLength, 2)
        End Get
    End Property

    Public Overrides ReadOnly Property Perimeter As Decimal
        Get
            Return _sides * SideLength
        End Get
    End Property
End Class
