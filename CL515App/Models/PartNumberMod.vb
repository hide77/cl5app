Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class PartNumberMod
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=PartNumberMod")
    End Sub



    Public Overridable Property Exclusion_List As DbSet(Of Exclusion_List)
    Public Overridable Property PartNumberModifieds As DbSet(Of PartNumberModified)
    Public Overridable Property Tag_List As DbSet(Of Tag_List)


    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)


        modelBuilder.Entity(Of Exclusion_List)() _
            .Property(Function(e) e.PartNumber) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Exclusion_List)() _
            .Property(Function(e) e.ReasonForExclusion) _
            .IsUnicode(False)


        modelBuilder.Entity(Of PartNumberModified)() _
            .Property(Function(e) e.PartNumber) _
            .IsUnicode(False)

        modelBuilder.Entity(Of PartNumberModified)() _
            .Property(Function(e) e.OriginalPartNumber) _
            .IsUnicode(False)

    End Sub
End Class
