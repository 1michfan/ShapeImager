Imports Microsoft.VisualBasic.FileIO

Public Class CsvParser
    Dim _path As String

    Public Sub New(csvPath As String)
        _path = csvPath
    End Sub

    Public Function ParseFile() As Boolean
        Dim file As New TextFieldParser(_path)
        file.TextFieldType = FieldType.Delimited
        file.Delimiters = New String() {","}
        Dim records As List(Of String()) = ReadAllRecords(file)

        Using db As New ShapeDbContext()
            For Each rec In records
                Dim type As String = rec(0)
                Select Case type
                    Case "Polygon"
                        db.Polygons.Add(CreatePolygon(rec))
                    Case "Equilateral Triangle"
                        db.EquilTriangles.Add(CreateEquilTri(rec))
                End Select
            Next
            Return db.SaveChanges() > 0
        End Using
    End Function

    Private Function CreateEquilTri(rec() As String) As EquilTriangle
        Dim tri As New EquilTriangle(rec(2), rec(4), rec(6), rec(8))
        Return tri
    End Function

    Private Function CreatePolygon(rec() As String) As Polygon
        Dim poly As New Polygon()
        Dim i As Integer = 0
        While i < rec.Count - 1
            i += 2 'data is in every other column
            Dim x = rec(i)
            i += 2
            Dim y = rec(i)
            poly.AddVertice(x, y)
        End While
        Return poly
    End Function

    Private Shared Function ReadAllRecords(file As TextFieldParser) As List(Of String())
        Dim records As New List(Of String())

        Do While Not file.EndOfData
            Try
                records.Add(file.ReadFields)
            Catch ex As MalformedLineException
                Stop
            End Try
        Loop

        Return records
    End Function
End Class
