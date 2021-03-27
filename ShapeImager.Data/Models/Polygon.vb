Public Class Polygon
    Inherits Shape
    Public Property Vertices As New List(Of Vertice)
    Public Overridable Property Sides As Integer
    Public Sub AddVertice(x As Decimal, y As Decimal)
        Vertices.Add(New Vertice(x, y))
        Sides = Vertices.Count
    End Sub
    Public Overrides ReadOnly Property Area As Decimal
        Get
            Return 0
        End Get
    End Property

    Public Overrides ReadOnly Property Perimeter As Decimal
        Get
            Return 0
        End Get
    End Property
End Class
