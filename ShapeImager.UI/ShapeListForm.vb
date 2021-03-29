Imports System.Data.Entity
Imports ShapeImager.Data
Public Class ShapeListForm
    ReadOnly _db As New ShapeDbContext()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillData()
    End Sub

    Private Sub FillData()
        RemoveHandler gvShape.SelectionChanged, AddressOf gvShape_SelectionChanged
        _db.Shapes.Load()
        ShapeBindingSource.DataSource = _db.Shapes.Local.ToBindingList()
        gvShape.ClearSelection()
        AddHandler gvShape.SelectionChanged, AddressOf gvShape_SelectionChanged
    End Sub

    Private Sub btnImportCsv_Click(sender As Object, e As EventArgs) Handles btnImportCsv.Click
        'TODO ask user if they want to clear existing data first.
        Dim filePath As String = "C:\Users\matto\source\repos\ShapeImager\ShapeImager.UI\ShapeList.csv" 'TODO get path from user - verify that it exists and isn't in use
        Dim parser As New CsvParser(filePath)
        parser.ParseFile()
        FillData()
    End Sub

    Private Sub gvShape_SelectionChanged(sender As Object, e As EventArgs)
        If gvShape.SelectedRows.Count = 1 Then
            Dim row As DataGridViewRow = gvShape.SelectedRows().Item(0)
            If row IsNot Nothing Then
                Dim shp As Shape = row.DataBoundItem
                ucShapePainter.PaintShape(shp)
            End If
        End If
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        _db.SaveChanges()
    End Sub

    Private Sub gvShape_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles gvShape.CellFormatting
        If e.ColumnIndex = colColor.Index Then
            Dim row As DataGridViewRow = gvShape.Rows(e.RowIndex)
            Dim shp As Shape = row.DataBoundItem
            If shp IsNot Nothing Then
                e.CellStyle.BackColor = Color.FromArgb(shp.Color)
                e.CellStyle.ForeColor = Color.FromArgb(shp.Color)
                e.CellStyle.SelectionBackColor =  Color.FromArgb(shp.Color)
                e.CellStyle.SelectionForeColor = Color.FromArgb(shp.Color)
            End If
        End If
    End Sub

    Private Sub gvShape_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gvShape.CellClick
        If e.ColumnIndex = colColor.Index Then
            Dim row As DataGridViewRow = gvShape.Rows(e.RowIndex)
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
End Class
