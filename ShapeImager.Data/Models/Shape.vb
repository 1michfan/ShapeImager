
Public MustInherit Class Shape
    Public Property Id As Integer
    'TODO store as int but convert to color?
    Public Property Center As Vertice
    Public Property Color As Integer

    MustOverride Function GetArea() As Decimal
    MustOverride Function GetPerimater() As Decimal()
End Class
