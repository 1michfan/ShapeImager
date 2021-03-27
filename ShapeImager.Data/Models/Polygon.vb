Public Class Polygon
    Inherits Shape
    Public Property Vertices As New List(Of Vertice)
    Public Overridable Property Sides As Integer
    Public Sub AddVertice(x As Decimal, y As Decimal)
        Vertices.Add(New Vertice(x, y))
        Sides = Vertices.Count
    End Sub
    Public Overrides Function GetArea() As Decimal
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetPerimeter() As Decimal()
        Throw New NotImplementedException()
    End Function
End Class
