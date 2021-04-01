Imports ShapeImager.Data

<TestClass()>
Public Class PolygonTests

    <TestMethod()>
    Public Sub TestPolygonArea()
        Dim poly As Polygon = CreateTestPolygon()
        Dim exp As Decimal = 99
        Assert.AreEqual(exp, poly.Area)
    End Sub

    <TestMethod()>
    Public Sub TestPolygonPerimeter()
        Dim poly As Polygon = CreateTestPolygon()
        Dim exp As Decimal = 201.8
        Dim perim = Decimal.Round(poly.Perimeter, 1)
        Assert.AreEqual(exp, perim)
    End Sub

    Private Shared Function CreateTestPolygon() As Polygon
        Dim poly As New Polygon()
        poly.Vertices.Add(New Vertex(1, 1))
        poly.Vertices.Add(New Vertex(7, 20))
        poly.Vertices.Add(New Vertex(15, 75))
        poly.Vertices.Add(New Vertex(20, 100))
        poly.Vertices.Add(New Vertex(10, 50))
        poly.Vertices.Add(New Vertex(1, 1))
        Return poly
    End Function
End Class