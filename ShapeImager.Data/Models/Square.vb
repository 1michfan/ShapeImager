Public Class Square
    Inherits Equilateral
    Public Sub New()

    End Sub

    Public Sub New(orientation As Decimal, sideLength As Decimal)
        MyBase.Orientation = orientation
        MyBase.SideLength = sideLength
    End Sub

    Public Overrides Property Sides As Integer = 4

    Public Overrides Function GetArea() As Decimal
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetPerimeter() As Decimal()
        Throw New NotImplementedException()
    End Function
End Class
