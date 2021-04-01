Imports System.Drawing

Public Class Polygon
    Inherits Shape

    Public Sub New()
        Vertices = New List(Of Vertex)
    End Sub
    Public Overridable Property Vertices As ICollection(Of Vertex)
    Private ReadOnly Property Sides As Integer
        Get
            'last vertices is repeat of the first one
            Return Vertices.Count - 1
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
            Return a / 2
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

    Private Function GetDistance(p1 As Vertex, p2 As Vertex) As Decimal
        Return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2))
    End Function

    Public Function FindCentroid() As Vertex
        If Sides < 3 Then Return New Vertex(0, 0)
        Dim num_points As Integer = Sides
        Dim pts As PointF() = New PointF(num_points + 1) {}
        For i = 0 To num_points
            pts(i) = New PointF(Vertices(i).X, Vertices(i).Y)
        Next
        Dim X As Single = 0
        Dim Y As Single = 0
        Dim second_factor As Single

        For i As Integer = 0 To num_points - 1
            second_factor = pts(i).X * pts(i + 1).Y - pts(i + 1).X * pts(i).Y
            X += (pts(i).X + pts(i + 1).X) * second_factor
            Y += (pts(i).Y + pts(i + 1).Y) * second_factor
        Next

        Dim polygon_area As Single = Area
        X /= (6 * polygon_area)
        Y /= (6 * polygon_area)

        If X < 0 Then
            X = -X
            Y = -Y
        End If

        Return New Vertex(X, Y)
    End Function

End Class
