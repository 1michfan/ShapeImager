Imports System.Data.Entity
Imports ShapeImager.Data
Public Class ShapeListForm
    ReadOnly _db As New ShapeDbContext()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillData()
    End Sub

    Private Sub FillData()
        RemoveHandler GvShape.SelectionChanged, AddressOf gvShape_SelectionChanged
        _db.Shapes.Load()
        BsShape.DataSource = _db.Shapes.Local.ToBindingList()
        GvShape.ClearSelection()
        AddHandler GvShape.SelectionChanged, AddressOf gvShape_SelectionChanged
    End Sub

    Private Sub btnImportCsv_Click(sender As Object, e As EventArgs) Handles btnImportCsv.Click
        'TODO ask user if they want to clear existing data first.
        Dim filePath As String = "C:\Users\matto\source\repos\ShapeImager\ShapeImager.UI\ShapeList.csv" 'TODO get path from user - verify that it exists and isn't in use
        Dim parser As New CsvParser(filePath)
        parser.ParseFile()
        FillData()
    End Sub

    Private Sub gvShape_SelectionChanged(sender As Object, e As EventArgs)
        If GvShape.SelectedRows.Count = 1 Then
            Dim shp As Shape = GetSelectedShape()
            If shp IsNot Nothing Then
                LoadSelectedShapeProps(shp)
                ucShapePainter.PaintShape(shp)
            End If
        End If
    End Sub

    Private Function GetSelectedShape() As Shape
        Dim row As DataGridViewRow = GvShape.SelectedRows().Item(0)
        If row Is Nothing Then
            Return Nothing
        Else
            Return row.DataBoundItem
        End If
    End Function

    Private Sub LoadSelectedShapeProps(shp As Shape)
        LoadCenter(shp)
        LoadEllipse(shp)
        LoadEquilateral(shp)
        LoadVertice(shp)
    End Sub

    Private Sub LoadVertice(shp As Shape)
        RemoveHandler GvVertice.CellValueChanged, AddressOf RefreshShape
        Dim poly As Polygon = TryCast(shp, Polygon)
        If poly IsNot Nothing Then
            BsVertice.DataSource = poly.Vertices
        Else
            BsVertice.Clear()
        End If
        AddHandler GvVertice.CellValueChanged, AddressOf RefreshShape
    End Sub

    Private Sub LoadEquilateral(shp As Shape)
        RemoveHandler TbSideLength.ValueChanged, AddressOf RefreshShape
        If shp.ShapeType.BaseType = GetType(Equilateral) Then
            BsEquilateral.DataSource = shp
            tlpEquil.Visible = True
        Else
            BsEquilateral.Clear()
            tlpEquil.Visible = False
        End If
        AddHandler TbSideLength.ValueChanged, AddressOf RefreshShape
    End Sub

    Private Sub LoadEllipse(shp As Shape)
        UnsubscribeEdits(TbRadius1)
        UnsubscribeEdits(TbRadius2)
        If shp.ShapeType = GetType(Ellipse) Or shp.ShapeType = GetType(Circle) Then
            BsEllipse.DataSource = shp
            tlpRadius1.Visible = True
            tlpRadius2.Visible = (shp.ShapeType = GetType(Ellipse))
        Else
            BsEllipse.Clear()
            tlpRadius1.Visible = False
            tlpRadius2.Visible = False
        End If
        SubscribeEdits(TbRadius1)
        SubscribeEdits(TbRadius2)
    End Sub

    Private Sub LoadCenter(shp As Shape)
        UnsubscribeEdits(TbX)
        UnsubscribeEdits(TbY)
        If shp.Center Is Nothing Then
            BsCenter.Clear()
            tlpCenter.Visible = False
        Else
            BsCenter.DataSource = shp.Center
            tlpCenter.Visible = True
        End If
        SubscribeEdits(TbX)
        SubscribeEdits(TbY)
    End Sub

    Private Sub UnsubscribeEdits(tb As NumericUpDown)
        RemoveHandler tb.ValueChanged, AddressOf RefreshShape
    End Sub

    Private Sub SubscribeEdits(tb As NumericUpDown)
        AddHandler tb.ValueChanged, AddressOf RefreshShape
    End Sub

    Private Sub RefreshShape(sender As Object, e As EventArgs)
        RefreshShape()
    End Sub

    Private Sub RefreshShape()
        BsCenter.EndEdit()
        BsEllipse.EndEdit()
        BsEquilateral.EndEdit()
        BsVertice.EndEdit()
        Dim shape = GetSelectedShape()
        If shape IsNot Nothing Then ucShapePainter.PaintShape(shape)
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        BsShape.EndEdit()
        _db.SaveChanges()
    End Sub

    Private Sub gvShape_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles GvShape.CellFormatting
        If e.ColumnIndex = colColor.Index Then
            Dim shp As Shape = GetShape(e.RowIndex)
            If shp IsNot Nothing Then
                Dim color As Color = Color.FromArgb(shp.Color)
                e.CellStyle.BackColor = color
                e.CellStyle.ForeColor = color
                e.CellStyle.SelectionBackColor = color
                e.CellStyle.SelectionForeColor = color
            End If
        End If
    End Sub

    Private Function GetShape(index As Integer) As Shape
        If index < 0 Then Return Nothing
        Dim row As DataGridViewRow = GvShape.Rows(index)
        Dim shp As Shape = row.DataBoundItem
        Return shp
    End Function

    Private Sub gvShape_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GvShape.CellClick
        If e.ColumnIndex = colColor.Index Then
            Dim row As DataGridViewRow = GvShape.Rows(e.RowIndex)
            Dim shp As Shape = row.DataBoundItem
            If shp IsNot Nothing Then
                Using cd As New ColorDialog()
                    cd.ShowDialog()
                    shp.Color = cd.Color.ToArgb
                    row.Cells(e.ColumnIndex).Style.BackColor = cd.Color
                    ucShapePainter.PaintShape(shp)
                End Using
            End If
        End If
    End Sub

    Private Sub GvShape_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles GvShape.CellValueChanged
        If e.ColumnIndex = colDegrees.Index Or e.ColumnIndex = colOrientation.Index Then
            Dim shape As Shape = GetShape(e.RowIndex)
            If shape IsNot Nothing Then
                ucShapePainter.PaintShape(shape)
            End If
        End If
    End Sub
End Class
