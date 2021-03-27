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
        'modelBuilder.Entity(Of Shape)().ToTable("Shapes")
        'modelBuilder.Entity(Of Circle)().ToTable("Circles")
        'modelBuilder.Entity(Of Ellipse)().ToTable("Ellipses")
        'modelBuilder.Entity(Of EquilTriangle)().ToTable("EquilTriangles")
        'modelBuilder.Entity(Of Square)().ToTable("Squares")
        'modelBuilder.Entity(Of Vertice)().ToTable("Vertices")
    End Sub

    Public Overridable Property Circles As DbSet(Of Circle)
    Public Overridable Property Ellipses As DbSet(Of Ellipse)
    Public Overridable Property EquilTriangles As DbSet(Of EquilTriangle)
    Public Overridable Property Polygons As DbSet(Of Polygon)
    Public Overridable Property Shapes As DbSet(Of Shape)
    Public Overridable Property Squares As DbSet(Of Square)
    Public Overridable Property Vertices As DbSet(Of Vertice)

End Class
