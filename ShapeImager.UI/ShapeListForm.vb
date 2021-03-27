Imports ShapeImager.Data
Public Class ShapeListForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillData()
    End Sub

    Private Sub FillData()
        Dim db As New ShapeDbContext()
        ShapeBindingSource.DataSource = db.Shapes.ToList()

    End Sub

    Private Sub btnImportCsv_Click(sender As Object, e As EventArgs) Handles btnImportCsv.Click
        'TODO ask user if they want to clear existing data first.
        Dim filePath As String = "C:\Users\matto\source\repos\ShapeImager\ShapeImager.UI\ShapeList.csv" 'TODO get path from user - verify that it exists and isn't in use
        Dim parser As New CsvParser(filePath)
        parser.ParseFile()
        FillData()
    End Sub

    Private Sub gvShape_SelectionChanged(sender As Object, e As EventArgs) Handles gvShape.SelectionChanged
        If gvShape.SelectedRows.Count = 1 Then
            Dim row As DataGridViewRow = gvShape.SelectedRows().Item(0)
            If row IsNot Nothing Then
                Dim shp As Shape = row.DataBoundItem
                ucShapePainter.PaintShape(shp)
            End If
        End If
    End Sub

    Private Sub Chart1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
