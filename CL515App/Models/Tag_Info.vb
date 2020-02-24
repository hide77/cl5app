Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial
Public Class Tag_Info
    <Key>
    <Display(Name:="Tag ID")>
    Public Property Tag_InfoID As Integer

    <StringLength(50)>
    <Display(Name:="Tag Name")>
    Public Property TagName As String

    <Display(Name:="Tag Status")>
    Public Property TagStatus As Boolean?

    <StringLength(50)>
    <Display(Name:="Tag Created/Modified By")>
    Public Property AddedBy As String

    <Display(Name:="Tag Created/Modified At")>
    Public Property AddedAt As Date?

    Public Overridable Property Tag_Choice As ICollection(Of Tag_Choices)
End Class
