Imports ShapeImager.Data
Imports System.Data.Entity

Public Class ShapeListForm
    ReadOnly _bindingSources As New List(Of BindingSource)
    ReadOnly _db As New ShapeDbContext()

    Public Sub New()
        InitializeComponent()
        _bindingSources.AddRange({BsCenter, BsEllipse, BsEquilateral, BsShape, BsVertice})
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        FillData()
        LoadSelectedShapeProps(Nothing)
        ToggleButtonEnabled()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddHandler gvShape.RowsAdded, AddressOf gvShape_FocusNewRow
        Dim shapeType As Type
        shapeType = PromptUserForShape()

        If shapeType IsNot Nothing Then
            AddNewShape(shapeType)
        End If
        RemoveHandler gvShape.RowsAdded, AddressOf gvShape_FocusNewRow
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim rows = gvShape.SelectedRows
        If rows.Count = 0 Then
            MessageBox.Show("You must select a row first")
        Else
            Dim res As DialogResult = MessageBox.Show("Are you sure you wish to the selected row(s)", "Delete?", MessageBoxButtons.YesNo)
            If res = DialogResult.Yes Then
                DeleteSelectedRows(rows)
            End If
        End If
    End Sub

    Private Sub btnImportCsv_Click(sender As Object, e As EventArgs) Handles btnImportCsv.Click
        ClearFirstPrompt()
        Using fd As OpenFileDialog = New OpenFileDialog() With {
                .InitialDirectory = IO.Directory.GetCurrentDirectory(),
                .Filter = "CSV files (*.csv)|*.csv",
                .FileName = "ShapeList.csv",
                .FilterIndex = 2,
                .RestoreDirectory = False
            }
            If fd.ShowDialog = DialogResult.OK Then
                Dim file As New IO.FileInfo(fd.FileName)
                If file.Extension = ".csv" Then
                    ParseAndRefresh(fd)
                Else
                    MessageBox.Show("Invalid File Extension. Please choose a .csv file.")
                End If
            End If
        End Using
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        SaveChanges()
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

    Private Sub gvShape_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles gvShape.CellFormatting
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

    Private Sub gvShape_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles gvShape.CellValueChanged
        If e.ColumnIndex = colDegrees.Index Or e.ColumnIndex = colOrientation.Index Then
            Dim shape As Shape = GetShape(e.RowIndex)
            If shape IsNot Nothing Then
                ucShapePainter.PaintShape(shape)
            End If
        End If
    End Sub

    Private Sub gvShape_FocusNewRow(sender As Object, e As DataGridViewRowsAddedEventArgs)
        gvShape.ClearSelection()
        gvShape.CurrentCell = gvShape.Rows(e.RowIndex).Cells(0)
        gvShape.Rows(e.RowIndex).Selected = True
        BsShape.EndEdit()
        btnSaveChanges.Enabled = True
    End Sub

    Private Sub gvShape_SelectionChanged(sender As Object, e As EventArgs)
        Dim count As Integer = gvShape.SelectedRows.Count

        If count = 1 Then
            Dim shp As Shape = GetSelectedShape()
            If shp IsNot Nothing Then
                LoadSelectedShapeProps(shp)
                ucShapePainter.PaintShape(shp)
            End If
        End If
        btnDelete.Enabled = count > 0
    End Sub

    Private Sub RefreshShape(sender As Object, e As EventArgs)
        RefreshShape()
    End Sub

    Private Sub ShapeListForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If _db.ChangeTracker.HasChanges Then
            Dim res As DialogResult = MessageBox.Show("You have unsaved changes. Do you wish to save them before closing?", "Save Changes", MessageBoxButtons.YesNoCancel)
            Select Case res
                Case DialogResult.Cancel
                    e.Cancel = True
                Case DialogResult.Yes
                    SaveChanges()
            End Select
        End If
    End Sub

    Private Shared Function PromptUserForShape() As Type
        Dim shapeType As Type

        Using frm As New ShapeSelectForm()
            frm.ShowDialog()
            shapeType = frm.SelectedShape
        End Using

        Return shapeType
    End Function

    Private Sub AddNewShape(shapeType As Type)
        Dim shape = Activator.CreateInstance(shapeType)
        shape.Center = New Vertice()
        _db.Shapes.Add(shape)
        FillSumLabels()
    End Sub

    Private Sub ClearFirstPrompt()
        If gvShape.Rows.Count > 0 Then
            Dim res As DialogResult = MessageBox.Show("Do you wish to clear existing data first?", "Clear Data?", MessageBoxButtons.YesNo)
            If res = DialogResult.Yes Then
                gvShape.Rows.Clear()
                RefreshShape()
            End If
        End If
    End Sub

    Private Sub DeleteSelectedRows(rows As DataGridViewSelectedRowCollection)
        gvShape.ClearSelection()
        For Each row In rows
            gvShape.Rows.Remove(row)
        Next
        RefreshShape()
    End Sub

    Private Sub FillData()
        RemoveHandler gvShape.SelectionChanged, AddressOf gvShape_SelectionChanged
        _db.Shapes.Load()
        BsShape.DataSource = _db.Shapes.Local.ToBindingList()
        gvShape.ClearSelection()
        FillSumLabels()
        AddHandler gvShape.SelectionChanged, AddressOf gvShape_SelectionChanged
    End Sub

    Private Sub FillSumLabels()
        Dim area As Decimal
        Dim perim As Decimal
        Dim count As Integer = gvShape.Rows.Count

        SumAreaAndPerim(area, perim, count)
        lblRowCount.Text = count
        lblTotalArea.Text = Decimal.Round(area)
        lblTotalPerimeter.Text = Decimal.Round(perim)
        Dim avgArea As Decimal = If(count = 0, 0, area / count)
        Dim avgPerim As Decimal = If(count = 0, 0, perim / count)
        lblAvgArea.Text = Decimal.Round(avgArea)
        lblAvgPerim.Text = Decimal.Round(avgPerim)
    End Sub

    Private Function GetSelectedShape() As Shape
        If gvShape.SelectedRows.Count = 0 Then Return Nothing
        Dim row As DataGridViewRow = gvShape.SelectedRows().Item(0)
        If row Is Nothing Then
            Return Nothing
        Else
            Return row.DataBoundItem
        End If
    End Function

    Private Function GetShape(index As Integer) As Shape
        If index < 0 Then Return Nothing
        Dim row As DataGridViewRow = gvShape.Rows(index)
        Dim shp As Shape = row.DataBoundItem
        Return shp
    End Function

    Private Sub LoadCenter(shp As Shape)
        UnsubscribeEdits(tbX)
        UnsubscribeEdits(tbY)
        If shp?.Center Is Nothing Then
            tlpCenter.Visible = False
        Else
            BsCenter.DataSource = shp.Center
            tlpCenter.Visible = True
        End If
        SubscribeEdits(tbX)
        SubscribeEdits(tbY)
    End Sub

    Private Sub LoadEllipse(shp As Shape)
        UnsubscribeEdits(tbRadius1)
        UnsubscribeEdits(tbRadius2)
        Dim ell As Ellipse = TryCast(shp, Ellipse)
        If ell IsNot Nothing Then
            BsEllipse.DataSource = ell
            tlpRadius1.Visible = True
            tlpRadius2.Visible = (shp.ShapeType = GetType(Ellipse))
        Else
            tlpRadius1.Visible = False
            tlpRadius2.Visible = False
        End If
        SubscribeEdits(tbRadius1)
        SubscribeEdits(tbRadius2)
    End Sub

    Private Sub LoadEquilateral(shp As Shape)
        RemoveHandler tbSideLength.ValueChanged, AddressOf RefreshShape
        Dim eq As Equilateral = TryCast(shp, Equilateral)
        If eq IsNot Nothing Then
            BsEquilateral.DataSource = eq
            tlpEquil.Visible = True
        Else
            tlpEquil.Visible = False
        End If
        AddHandler tbSideLength.ValueChanged, AddressOf RefreshShape
    End Sub

    Private Sub LoadSelectedShapeProps(shp As Shape)
        LoadCenter(shp)
        LoadEllipse(shp)
        LoadEquilateral(shp)
        LoadVertice(shp)
    End Sub

    Private Sub LoadVertice(shp As Shape)
        RemoveHandler gvVertice.CellValueChanged, AddressOf RefreshShape
        If shp?.ShapeType = GetType(Polygon) Then
            Dim poly As Polygon = TryCast(shp, Polygon)
            BsVertice.DataSource = poly.Vertices
            gvVertice.Visible = True
        Else
            gvVertice.Visible = False
        End If
        AddHandler gvVertice.CellValueChanged, AddressOf RefreshShape
    End Sub

    Private Sub ParseAndRefresh(fd As OpenFileDialog)
        Dim parser As New CsvParser(fd.FileName)
        parser.ParseFile()
        FillData()
    End Sub

    Private Sub RefreshShape()
        For Each bs In _bindingSources
            bs.EndEdit()
        Next
        gvShape.Refresh()
        FillSumLabels()
        Dim shape = GetSelectedShape()
        If shape Is Nothing Then
            For Each bs In _bindingSources
                bs.Clear()
            Next
        End If
        ucShapePainter.PaintShape(shape)
        ToggleButtonEnabled()
    End Sub

    Private Sub SaveChanges()
        BsShape.EndEdit()
        _db.SaveChanges()
        gvShape.Refresh()
        ToggleButtonEnabled()
    End Sub

    Private Sub SubscribeEdits(tb As NumericUpDown)
        AddHandler tb.ValueChanged, AddressOf RefreshShape
    End Sub

    Private Sub SumAreaAndPerim(ByRef area As Decimal, ByRef perim As Decimal, count As Integer)
        For i = 0 To count - 1
            Dim shape = GetShape(i)
            If shape IsNot Nothing Then
                area += shape.Area
                perim += shape.Perimeter
            End If
        Next
    End Sub

    Private Sub ToggleButtonEnabled()
        Dim hasChanges = _db.ChangeTracker.HasChanges()
        btnSaveChanges.Enabled = hasChanges
    End Sub

    Private Sub UnsubscribeEdits(tb As NumericUpDown)
        RemoveHandler tb.ValueChanged, AddressOf RefreshShape
    End Sub
End Class
