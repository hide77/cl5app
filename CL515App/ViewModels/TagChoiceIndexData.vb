Imports CL515App.TagModel
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial
Namespace ViewModels
    Public Class TagChoiceIndexData

        Public Property tag_Choices As IEnumerable(Of Tag_Choices)

    End Class
End Namespace