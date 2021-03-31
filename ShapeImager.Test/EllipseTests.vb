Imports ShapeImager.Data

<TestClass()> Public Class EllipseTests

    <TestMethod()>
    Public Sub TestArea()
        Dim ell As New Ellipse(0, 0, radius1:=1, radius2:=2, 0)
        Dim area = Decimal.Round(ell.Area, 2)
        Dim exp As Decimal = 6.28
        Assert.AreEqual(exp, area)
    End Sub

    <TestMethod()>
    Public Sub TestPerimeter()
        Dim ell As New Ellipse(0, 0, radius1:=1, radius2:=2, 0)
        Dim perim = Decimal.Round(ell.Perimeter, 2)
        Dim exp As Decimal = 9.93
        Assert.AreEqual(exp, perim)
    End Sub

End Class