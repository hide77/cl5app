Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class TagModel
    Inherits DbContext

    Public Sub New()
        'MyBase.New("name=TagModel")
        MyBase.New("name=LocalModel")
    End Sub

    Public Overridable Property Tag_Choices As DbSet(Of Tag_Choices)
    Public Overridable Property Tag_Info As DbSet(Of Tag_Info)
    Public Overridable Property Tag_List As DbSet(Of Tag_List)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)

    End Sub
End Class
