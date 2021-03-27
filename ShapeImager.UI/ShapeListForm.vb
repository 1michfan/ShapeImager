Public Class ShapeListForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillData()
    End Sub

    Private Sub FillData()
        Dim db As New Data.ShapeDbContext()
        ShapeBindingSource.DataSource = db.Shapes.ToList()

    End Sub

    Private Sub btnImportCsv_Click(sender As Object, e As EventArgs) Handles btnImportCsv.Click
        'TODO ask user if they want to clear existing data first.
        Dim filePath As String = "C:\Users\matto\source\repos\ShapeImager\ShapeImager.UI\ShapeList.csv" 'TODO get path from user - verify that it exists and isn't in use
        Dim parser As New Data.CsvParser(filePath)
        parser.ParseFile()
        FillData()
    End Sub
End Class
