Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("PartNumberModified")>
Partial Public Class PartNumberModified
    <Key>
    <Column(Order:=0)>
    <StringLength(30)>
    <Display(Name:="Part Number")>
    Public Property PartNumber As String

    <Key>
    <Column(Order:=1)>
    <StringLength(30)>
    <Display(Name:="Original Part Number")>
    Public Property OriginalPartNumber As String

    <StringLength(255)>
    <Display(Name:="Reason For Modification")>
    Public Property ReasonForMod As String

    <StringLength(50)>
    <Display(Name:="Modified By")>
    Public Property ModBy As String

    <Display(Name:="Modified At")>
    Public Property ModAt As Date?
End Class
