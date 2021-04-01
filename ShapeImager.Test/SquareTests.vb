Imports ShapeImager.Data

<TestClass()>
Public Class SquareTests

    <TestMethod()>
    Public Sub TestArea()
        Dim sq As New Square(0, 0, sideLength:=1, 0)
        Dim exp As Decimal = 1
        Assert.AreEqual(exp, sq.Area)
    End Sub

    <TestMethod()>
    Public Sub TestPerimeter()
        Dim sq As New Square(0, 0, sideLength:=1, 0)
        Dim exp As Decimal = 4
        Assert.AreEqual(exp, sq.Perimeter)
    End Sub

End Class