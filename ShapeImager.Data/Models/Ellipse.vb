Public Class Ellipse
    Inherits Shape
    Public Property Orientation As Decimal
    Public Property Radius1 As Decimal
    Public Property Radius2 As Decimal
    Public Overrides Function GetArea() As Decimal
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetPerimater() As Decimal()
        Throw New NotImplementedException()
    End Function
End Class
