Public Class ShapeListForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim db As New Data.ShapeDbContect()
        db.Circles.ToList()
    End Sub
End Class
