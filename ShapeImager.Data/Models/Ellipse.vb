Public Class Ellipse
    Inherits Shape
    Public Sub New()

    End Sub

    Public Sub New(centerX As Decimal, centerY As Decimal, orientation As Decimal, radius1 As Decimal, radius2 As Decimal)
        Center = New Vertice(centerX, centerY)
        MyBase.Orientation = orientation
        Me.Radius1 = radius1
        Me.Radius2 = radius2
    End Sub
    Public Property Radius1 As Decimal
    Public Property Radius2 As Decimal
    Public Overrides Function GetArea() As Decimal
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetPerimeter() As Decimal()
        Throw New NotImplementedException()
    End Function
End Class
