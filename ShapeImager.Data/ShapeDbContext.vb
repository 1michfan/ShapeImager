Imports System.Data.Entity

Public Class ShapeDbContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("ShapeDB")
        Configuration.LazyLoadingEnabled = True
        Database.SetInitializer(New DropCreateDatabaseIfModelChanges(Of ShapeDbContext))
        Database.Initialize(True)
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        MyBase.OnModelCreating(modelBuilder)
        modelBuilder.Entity(Of Polygon)() _
            .HasOptional(Function(s) s.Center) _
            .WithOptionalPrincipal(Function(s) s.Polygon) _
            .WillCascadeOnDelete(True)
    End Sub

    Public Overridable Property Circles As DbSet(Of Circle)
    Public Overridable Property Ellipses As DbSet(Of Ellipse)
    Public Overridable Property EquilTriangles As DbSet(Of EquilTriangle)
    Public Overridable Property Polygons As DbSet(Of Polygon)
    Public Overridable Property Shapes As DbSet(Of Shape)
    Public Overridable Property Squares As DbSet(Of Square)
    Public Overridable Property Vertices As DbSet(Of Vertice)

End Class
