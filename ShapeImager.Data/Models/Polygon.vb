Public Class Polygon
    Inherits Shape

    Public Sub New()
        Vertices = New List(Of Vertice)
    End Sub
    Public Overridable Property Vertices As ICollection(Of Vertice)
    Private ReadOnly Property Sides As Integer
        Get
            Return Vertices.Count
        End Get
    End Property

    Public Overrides ReadOnly Property Area As Decimal
        Get
            Dim a As Decimal = 0
            For i = 0 To Sides - 1
                Dim nextVert = (i + 1) Mod Sides
                a += Vertices(i).X * Vertices(nextVert).Y
                a -= Vertices(i).Y * Vertices(nextVert).X
            Next
            Return a
        End Get
    End Property

    Public Overrides ReadOnly Property Perimeter As Decimal
        Get
            Dim p As Decimal = 0
            For i = 0 To Sides - 1
                Dim nextVert = (i + 1) Mod Sides
                p += GetDistance(Vertices(i), Vertices(nextVert))
            Next
            Return p
        End Get
    End Property

    Private Function GetDistance(p1 As Vertice, p2 As Vertice) As Decimal
        Return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2))
    End Function
End Class
