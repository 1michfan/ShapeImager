Imports System.Data.Entity

Public Class ShapeDbContect
    Inherits DbContext

    Public Sub New()
        MyBase.New("ShapeDB")
        Database.SetInitializer(New DropCreateDatabaseIfModelChanges(Of ShapeDbContect))
        Database.Initialize(True)
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        MyBase.OnModelCreating(modelBuilder)
        modelBuilder.Entity(Of Shape)().ToTable("Shapes")
        modelBuilder.Entity(Of EquilTriangle)().ToTable("EquilTriangles")
    End Sub

    Public Overridable Property Shapes As DbSet(Of Shape)
    Public Overridable Property EquilTriangle As DbSet(Of EquilTriangle)

End Class
