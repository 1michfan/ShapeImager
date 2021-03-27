Public Class EquilTriangle
    Inherits Equilateral
    Public Sub New()

    End Sub
    Public Sub New(centerX As Decimal, centerY As Decimal, orientation As Decimal, sideLength As Decimal)
        Center = New Vertice(centerX, centerY)
        MyBase.Orientation = orientation
        MyBase.SideLength = sideLength
    End Sub

    Public Overrides Property Sides As Integer = 3

    Public Overrides Function GetArea() As Decimal
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetPerimeter() As Decimal()
        Throw New NotImplementedException()
    End Function
End Class
