Public Class Vertex
    Public Sub New()

    End Sub

    Public Sub New(x As Decimal, y As Decimal)
        Me.X = x
        Me.Y = y
    End Sub

    Public Property Id As Integer
    Public Property X As Decimal
    Public Property Y As Decimal
    Public Property Polygon As Polygon
End Class
