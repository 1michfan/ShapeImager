
Imports System.ComponentModel

Public MustInherit Class Shape
    Public Property Id As Integer
    'TODO store as int but convert to color?
    Public Property Center As Vertice
    Public Property Color As Integer
    Public Property Orientation As Decimal

    MustOverride ReadOnly Property Area As Decimal
    MustOverride ReadOnly Property Perimeter As Decimal

    <[ReadOnly](True)>
    Public ReadOnly Property ShapeType As String
        Get
            Return Me.GetType.Name
        End Get
    End Property
End Class
