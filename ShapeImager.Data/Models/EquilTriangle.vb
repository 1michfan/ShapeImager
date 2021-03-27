Public Class EquilTriangle
    Inherits Shape
    Public Property SideLength As Decimal
    Public Property Orientation As Decimal
    Public Overrides Function GetArea() As Decimal
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetPerimater() As Decimal()
        Throw New NotImplementedException()
    End Function
End Class
