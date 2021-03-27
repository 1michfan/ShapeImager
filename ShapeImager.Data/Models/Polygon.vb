Public Class Polygon
    Inherits Shape
    Public Property Vertices As List(Of Vertice)
    Public Overrides Function GetArea() As Decimal
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetPerimater() As Decimal()
        Throw New NotImplementedException()
    End Function
End Class
