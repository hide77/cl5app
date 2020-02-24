Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class update_foreignkey_name
        Inherits DbMigration
    
        Public Overrides Sub Up()
            RenameColumn(table := "dbo.Tag_Choices", name := "Tag_InfoID", newName := "Tag_Info_Tag_InfoID")
            RenameIndex(table := "dbo.Tag_Choices", name := "IX_Tag_InfoID", newName := "IX_Tag_Info_Tag_InfoID")
        End Sub
        
        Public Overrides Sub Down()
            RenameIndex(table := "dbo.Tag_Choices", name := "IX_Tag_Info_Tag_InfoID", newName := "IX_Tag_InfoID")
            RenameColumn(table := "dbo.Tag_Choices", name := "Tag_Info_Tag_InfoID", newName := "Tag_InfoID")
        End Sub
    End Class
End Namespace
