Imports System.Data.Entity

Public Class ShapeDbContect
    Inherits DbContext

    Public Sub New()
        MyBase.New("ShapeDB")
        Database.SetInitializer(New DropCreateDatabaseIfModelChanges(Of ShapeDbContect))
        Database.Initialize(True)
    End Sub

    Public Overridable Property Shapes As DbSet(Of Shape)

End Class
