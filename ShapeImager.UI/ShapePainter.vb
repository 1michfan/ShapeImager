﻿Imports ShapeImager.Data

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
        'e.Graphics.RotateTransform(_shape.Orientation)
        Select Case _shape.ShapeType
            Case GetType(Ellipse), GetType(Circle)
                Dim ell As Ellipse = DirectCast(_shape, Ellipse)
                Dim x As Decimal = ell.Center.X - (ell.Radius1 / 2)
                Dim y As Decimal = ell.Center.Y - (ell.Radius2 / 2)
                Dim rect As New Rectangle(x, y, ell.Radius1, ell.Radius2)
                e.Graphics.DrawEllipse(pen, rect)
            Case GetType(Square)
                Dim sq As Square = DirectCast(_shape, Square)
                Dim rect As New Rectangle(sq.Center.X - (sq.SideLength / 2), sq.Center.Y + (sq.SideLength / 2), sq.SideLength, sq.SideLength)
                e.Graphics.DrawRectangle(pen, rect)
        End Select
    End Sub

    Private Sub ShapePainter_PaintGrid(sender As Object, e As PaintEventArgs) Handles Me.Paint

        Dim pen As New Pen(Color.Black)
        e.Graphics.DrawLine(pen, 100, 0, 100, 600)
        e.Graphics.DrawLine(pen, 200, 0, 200, 600)
        e.Graphics.DrawLine(pen, 300, 0, 300, 600)
        e.Graphics.DrawLine(pen, 400, 0, 400, 600)
        e.Graphics.DrawLine(pen, 500, 0, 500, 600)
        e.Graphics.DrawLine(pen, 600, 0, 600, 600)
        e.Graphics.DrawLine(pen, 0, 100, 600, 100)
        e.Graphics.DrawLine(pen, 0, 200, 600, 200)
        e.Graphics.DrawLine(pen, 0, 300, 600, 300)
        e.Graphics.DrawLine(pen, 0, 400, 600, 400)
        e.Graphics.DrawLine(pen, 0, 500, 600, 500)
        e.Graphics.DrawLine(pen, 0, 600, 600, 600)

    End Sub
End Class