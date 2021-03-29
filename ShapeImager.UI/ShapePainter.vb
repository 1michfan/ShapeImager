Imports System.Drawing.Drawing2D
Imports ShapeImager.Data

Public Class ShapePainter
    Dim _shape As Shape
    Friend Sub PaintShape(shapeToDraw As Shape)
        Dim db As New ShapeDbContext()
        _shape = shapeToDraw
        AddHandler Paint, AddressOf ShapePainter_Paint
        Refresh()
        RemoveHandler Paint, AddressOf ShapePainter_Paint
    End Sub

    Private Sub ShapePainter_Paint(sender As Object, e As PaintEventArgs)
        If _shape Is Nothing Then Exit Sub
        Dim color As Color = Color.FromArgb(_shape.Color)
        Using brush As New SolidBrush(color)
            e = SetCoordOriginBottomLeft(e)
            RotateShape(e)

            Select Case _shape.ShapeType
                Case GetType(Ellipse), GetType(Circle)
                    DrawElippse(e, brush)
                Case GetType(Square)
                    DrawSquare(e, brush)
                Case GetType(Polygon)
                    DrawPolygon(e, brush)
                Case GetType(EquilTriangle)
                    DrawTriangle(e, brush)
            End Select
        End Using
    End Sub

    Private Sub RotateShape(e As PaintEventArgs)
        Dim center As Vertice = GetCenter()
        e.Graphics.TranslateTransform(center.X, center.Y)
        e.Graphics.RotateTransform(_shape.Degrees)
        e.Graphics.TranslateTransform(-center.X, -center.Y)
    End Sub

    Private Function GetCenter() As Vertice
        Dim center = _shape.Center
        If center Is Nothing Then
            Dim poly = TryCast(_shape, Polygon)
            If poly IsNot Nothing Then center = poly.FindCentroid()
        End If

        Return center
    End Function

    Private Shared Function SetCoordOriginBottomLeft(e As PaintEventArgs) As PaintEventArgs
        Dim mm As New Matrix(1, 0, 0, -1, 0, 600)
        e.Graphics.Transform = mm
        Return e
    End Function

    Private Sub DrawTriangle(e As PaintEventArgs, brush As Brush)
        Dim eqTri As EquilTriangle = DirectCast(_shape, EquilTriangle)
        Dim altitude As Decimal = 0.5 * Math.Sqrt(3) * eqTri.SideLength
        Dim half As Decimal = 0.5 * altitude
        Dim left As New Point(eqTri.Center.X - half, eqTri.Center.Y - half)
        Dim right As New Point(eqTri.Center.X + half, eqTri.Center.Y - half)
        Dim top As New Point(eqTri.Center.X, eqTri.Center.Y + half)
        Dim points As Point() = {left, right, top}
        e.Graphics.FillPolygon(brush, points)
    End Sub

    Private Sub DrawPolygon(e As PaintEventArgs, brush As Brush)
        Dim poly As Polygon = DirectCast(_shape, Polygon)
        Dim points As New List(Of Point)
        Using db As New ShapeDbContext()
            For Each vert In poly.Vertices
                points.Add(New Point(vert.X, vert.Y))
            Next
        End Using
        e.Graphics.FillPolygon(brush, points.ToArray)
    End Sub

    Private Sub DrawSquare(e As PaintEventArgs, brush As Brush)
        Dim sq As Square = DirectCast(_shape, Square)
        Dim rect As New Rectangle(sq.Center.X - (sq.SideLength / 2), sq.Center.Y - (sq.SideLength / 2), sq.SideLength, sq.SideLength)
        e.Graphics.FillRectangle(brush, rect)
    End Sub

    Private Sub DrawElippse(e As PaintEventArgs, brush As Brush)
        Dim ell As Ellipse = DirectCast(_shape, Ellipse)
        'TODO need to double check this math.
        Dim x As Decimal = ell.Center.X - (ell.Radius1 / 2)
        Dim y As Decimal = ell.Center.Y - (ell.Radius2 / 2)
        Dim rect As New Rectangle(x, y, ell.Radius1, ell.Radius2)
        e.Graphics.FillEllipse(brush, rect)
    End Sub

    Private Sub ShapePainter_PaintGrid(sender As Object, e As PaintEventArgs) Handles Me.Paint

        Dim pen As New Pen(Color.Black)
        e.Graphics.DrawLine(pen, 0, 0, 0, 600)
        e.Graphics.DrawLine(pen, 100, 0, 100, 600)
        e.Graphics.DrawLine(pen, 200, 0, 200, 600)
        e.Graphics.DrawLine(pen, 300, 0, 300, 600)
        e.Graphics.DrawLine(pen, 400, 0, 400, 600)
        e.Graphics.DrawLine(pen, 500, 0, 500, 600)
        e.Graphics.DrawLine(pen, 600, 0, 600, 600)
        e.Graphics.DrawLine(pen, 0, 0, 600, 0)
        e.Graphics.DrawLine(pen, 0, 100, 600, 100)
        e.Graphics.DrawLine(pen, 0, 200, 600, 200)
        e.Graphics.DrawLine(pen, 0, 300, 600, 300)
        e.Graphics.DrawLine(pen, 0, 400, 600, 400)
        e.Graphics.DrawLine(pen, 0, 500, 600, 500)
        e.Graphics.DrawLine(pen, 0, 600, 600, 600)

    End Sub
End Class
