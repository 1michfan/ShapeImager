
Public MustInherit Class Shape
    Public Property Id As Integer
    'TODO store as int but convert to color?
    Public Property Center As Vertice
    Public Property Color As Integer
    Public Property Orientation As Decimal

    MustOverride Function GetArea() As Decimal
    MustOverride Function GetPerimeter() As Decimal()
End Class
