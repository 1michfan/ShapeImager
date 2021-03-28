﻿Imports System.Data.Entity
Imports ShapeImager.Data
Public Class ShapeListForm
    Dim _db As New ShapeDbContext()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillData()
    End Sub

    Private Sub FillData()
        _db.Shapes.Load()
        ShapeBindingSource.DataSource = _db.Shapes.Local.ToBindingList()
        gvShape.ClearSelection()
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

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        _db.SaveChanges()
    End Sub
End Class
