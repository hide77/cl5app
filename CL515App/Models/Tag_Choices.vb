Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Tag_Choices
    <Key>
    <Column(Order:=0)>
    <Display(Name:="Tag Id")>
    Public Property Tag_ChoicesID As Integer

    <Key>
    <Column(Order:=1)>
    <StringLength(50)>
    <Display(Name:="Tag Value")>
    Public Property TagValue As String

    <Required>
    <StringLength(255)>
    <Display(Name:="Tag Description")>
    Public Property TagDescription As String

    <Display(Name:="Active")>
    Public Property TagActive As Boolean

    <Required>
    <StringLength(50)>
    <Display(Name:="Added By")>
    Public Property AddedBy As String

    <Display(Name:="Added At")>
    Public Property AddedAt As Date

End Class
