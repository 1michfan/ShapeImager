
Imports System.ComponentModel

Public MustInherit Class Shape
    Public Property Id As Integer
    'TODO store as int but convert to color?
    Public Overridable Property Center As Vertice
    Public Property Color As Integer
    Public Property Orientation As Decimal

    MustOverride ReadOnly Property Area As Decimal
    MustOverride ReadOnly Property Perimeter As Decimal

    <[ReadOnly](True)>
    Public ReadOnly Property ShapeType As Type
        Get
            Return Me.GetType().BaseType
        End Get
    End Property

    <[ReadOnly](True)>
    Public ReadOnly Property ShapeTypeName As String
        Get
            Return ShapeType.Name
        End Get
    End Property

End Class
