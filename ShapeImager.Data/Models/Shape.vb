
Public MustInherit Class Shape
    Public Property Id As Integer
    'TODO store as int but convert to color?
    Public Property CenterX As Decimal
    Public Property CenterY As Decimal
    Public Property Color As Integer

    MustOverride Function GetArea() As Decimal
    MustOverride Function GetPerimater() As Decimal()
End Class
