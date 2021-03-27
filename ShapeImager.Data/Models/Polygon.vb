Public Class Polygon
    Inherits Shape
    Public Sub New()
        Vertices = New List(Of Vertice)
    End Sub
    Public Property Vertices As ICollection(Of Vertice)
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
