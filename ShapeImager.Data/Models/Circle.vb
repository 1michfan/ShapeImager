Public Class Circle
    Inherits Ellipse
    Public Sub New()

    End Sub
    Public Sub New(centerX As Decimal, centerY As Decimal, radius As Decimal)
        MyBase.New(centerX, centerY, 0, radius, radius)
    End Sub

    Public Overrides Function GetArea() As Decimal
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetPerimeter() As Decimal()
        Throw New NotImplementedException()
    End Function
End Class
