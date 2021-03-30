Imports ShapeImager.Data
Public Class ShapeSelectForm
    Public SelectedShape As Type
    Dim _types As New List(Of Type) From {GetType(Circle), GetType(Ellipse), GetType(EquilTriangle), GetType(Polygon), GetType(Square)}

    Public Sub New()
        InitializeComponent()
        For Each type In _types
            Dim btn As New Button() With {
                .Text = type.Name,
                .Tag = type
                }
            AddHandler btn.Click, Sub() btn_ShapeSelected(type)
            FlowLayoutPanelButtons.Controls.Add(btn)
        Next
    End Sub

    Private Sub btn_ShapeSelected(type As Type)
        SelectedShape = type
        Close()
    End Sub
End Class