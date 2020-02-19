Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class TagModel
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=TagModel")
    End Sub

    Public Overridable Property Tag_Choices As DbSet(Of Tag_Choices)
    Public Overridable Property Tag_Info As DbSet(Of Tag_Info)
    Public Overridable Property Tag_List As DbSet(Of Tag_List)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Tag_List)() _
            .Property(Function(e) e.PartNumber) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Tag_List)() _
            .Property(Function(e) e.Tag1) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Tag_List)() _
            .Property(Function(e) e.Tag2) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Tag_List)() _
            .Property(Function(e) e.Tag3) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Tag_List)() _
            .Property(Function(e) e.Tag4) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Tag_List)() _
            .Property(Function(e) e.Tag5) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Tag_List)() _
            .Property(Function(e) e.Tag6) _
            .IsUnicode(False)
    End Sub
End Class
