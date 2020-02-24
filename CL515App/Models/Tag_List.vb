Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial
Public Class Tag_List
    <Key>
    <StringLength(255)>
    <Display(Name:="Part Number")>
    Public Property PartNumber As String

End Class
