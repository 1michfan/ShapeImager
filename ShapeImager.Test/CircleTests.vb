Imports ShapeImager.Data

<TestClass()> Public Class CircleTests

    <TestMethod()>
    Public Sub TestPerimeter()
        Dim circle As New Circle(0, 0, 1)
        Dim perimeter = Decimal.Round(circle.Perimeter, 2)
        Dim radian As Decimal = 6.28
        Assert.AreEqual(radian, perimeter)
    End Sub

    <TestMethod()>
    Public Sub TestRadius1EqualsRadius2()
        Dim radius As Decimal = 1
        Dim circle As New Circle(0, 0, radius)
        Assert.AreEqual(circle.Radius1, circle.Radius2)
    End Sub

    <TestMethod()>
    Public Sub TestArea()
        Dim circle As New Circle(0, 0, 1)
        Dim area = Decimal.Round(circle.Area, 2)
        Dim exp As Decimal = 3.14
        Assert.AreEqual(exp, area)
    End Sub

End Class