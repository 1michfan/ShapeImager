Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations.Schema

Public MustInherit Class Shape
    Public Sub New()
        Color = -5658199 'Default Color: Dark Gray
    End Sub

    Public Property Id As Integer
    Public Overridable Property Center As Vertice
    Public Property Color As Integer
    Public Property Orientation As Decimal

    <NotMapped>
    Public Property Degrees As Decimal
        Get
            Return Orientation * 180 / Math.PI
        End Get
        Set(value As Decimal)
            Orientation = value * Math.PI / 180
        End Set
    End Property

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
