Imports ShapeImager.Data

Public Class ShapePainter
    Dim _shape As Shape
    Friend Sub PaintShape(shapeToDraw As Shape)
        Dim db As New ShapeDbContext()
        _shape = shapeToDraw
        AddHandler Me.Paint, AddressOf ShapePainter_Paint
        Refresh()
        RemoveHandler Me.Paint, AddressOf ShapePainter_Paint
    End Sub

    Private Sub ShapePainter_Paint(sender As Object, e As PaintEventArgs)
        If _shape Is Nothing Then Exit Sub
        Dim pen As New Pen(Color.Black)
        'TODO customize color here
        'TODO orientation is currently store in radians, need to convert to degrees
        e.Graphics.RotateTransform(_shape.Orientation)
        Select Case _shape.ShapeType
            Case GetType(Ellipse)
                Dim ell As Ellipse = DirectCast(_shape, Ellipse)
                Dim x As Decimal = ell.Center.X - (ell.Radius1 / 2)
                Dim y As Decimal = ell.Center.Y - (ell.Radius2 / 2)
                Dim rect As New Rectangle(x, y, ell.Radius1, ell.Radius2)
                e.Graphics.DrawEllipse(pen, rect)
        End Select
    End Sub
End Class
