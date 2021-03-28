Public Class Polygon
    Inherits Shape
    Public Sub New()
        Vertices = New List(Of Vertice)
    End Sub
    Public Overridable Property Vertices As ICollection(Of Vertice)
    Public Overrides ReadOnly Property Area As Decimal
        Get
            Dim verts As List(Of Vertice)
            Using db As New ShapeDbContext()
                verts = db.Vertices.Where(Function(v) v.Polygon.Id = Id).ToList
            End Using
            Dim sides As Integer = verts.Count
            Dim a As Decimal = 0
            For i = 0 To sides - 1
                Dim nextVert = (i + 1) Mod sides
                a = a + verts(i).X * verts(nextVert).Y
                a = a - verts(i).Y * verts(nextVert).X
            Next
            Return a
        End Get
    End Property

    Public Overrides ReadOnly Property Perimeter As Decimal
        Get
            Dim verts As List(Of Vertice)
            Using db As New ShapeDbContext()
                verts = db.Vertices.Where(Function(v) v.Polygon.Id = Id).ToList
            End Using
            Dim sides As Integer = verts.Count
            Dim p As Decimal = 0
            For i = 0 To sides - 1
                Dim nextVert = (i + 1) Mod sides
                p += GetDistance(verts(i), verts(nextVert))
            Next
            Return p
        End Get
    End Property

    Private Function GetDistance(p1 As Vertice, p2 As Vertice) As Decimal
        Return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2))
    End Function
End Class
