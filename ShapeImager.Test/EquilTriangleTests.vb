Imports ShapeImager.Data

<TestClass()>
Public Class EquilTriangleTests

    <TestMethod()>
    Public Sub TestArea()
        Dim tri As New EquilTriangle(0, 0, sideLength:=1, 0)
        Dim area = Decimal.Round(tri.Area, 2)
        Dim exp As Decimal = 0.43
        Assert.AreEqual(exp, area)
    End Sub

    <TestMethod()>
    Public Sub TestPerimeter()
        Dim tri As New EquilTriangle(0, 0, sideLength:=1, 0)
        Dim exp As Decimal = 3
        Assert.AreEqual(exp, tri.Perimeter)
    End Sub
End Class