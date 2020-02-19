Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Exclusion_List
    <Key>
    <StringLength(255)>
    <Display(Name:="Part Number")>
    Public Property PartNumber As String

    <Required>
    <StringLength(255)>
    <Display(Name:="Reason For Exclusion")>
    Public Property ReasonForExclusion As String

    <StringLength(255)>
    <Display(Name:="Added By")>
    Public Property AddedBy As String

    <Display(Name:="Added At")>
    Public Property AddedAt As Date?
End Class
