Imports System.Data.Entity

Public Class ShapeDbContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("ShapeDB")
        Database.SetInitializer(New DropCreateDatabaseIfModelChanges(Of ShapeDbContext))
        Database.Initialize(True)
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        MyBase.OnModelCreating(modelBuilder)
    End Sub

    Public Overridable Property Circles As DbSet(Of Circle)
    Public Overridable Property Ellipses As DbSet(Of Ellipse)
    Public Overridable Property EquilTriangles As DbSet(Of EquilTriangle)
    Public Overridable Property Polygons As DbSet(Of Polygon)
    Public Overridable Property Shapes As DbSet(Of Shape)
    Public Overridable Property Squares As DbSet(Of Square)
    Public Overridable Property Vertices As DbSet(Of Vertice)

End Class
