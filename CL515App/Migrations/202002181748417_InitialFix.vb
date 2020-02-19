Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialFix
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.Tag_Info", New String() { "Tag_Choices_Tag_ChoicesID", "Tag_Choices_TagValue" }, "dbo.Tag_Choices")
            DropIndex("dbo.Tag_Info", New String() { "Tag_Choices_Tag_ChoicesID", "Tag_Choices_TagValue" })
            AddColumn("dbo.Tag_Choices", "Tag_Info_Tag_InfoID", Function(c) c.Int())
            CreateIndex("dbo.Tag_Choices", "Tag_Info_Tag_InfoID")
            AddForeignKey("dbo.Tag_Choices", "Tag_Info_Tag_InfoID", "dbo.Tag_Info", "Tag_InfoID")
            DropColumn("dbo.Tag_Info", "Tag_Choices_Tag_ChoicesID")
            DropColumn("dbo.Tag_Info", "Tag_Choices_TagValue")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Tag_Info", "Tag_Choices_TagValue", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_Info", "Tag_Choices_Tag_ChoicesID", Function(c) c.Int())
            DropForeignKey("dbo.Tag_Choices", "Tag_Info_Tag_InfoID", "dbo.Tag_Info")
            DropIndex("dbo.Tag_Choices", New String() { "Tag_Info_Tag_InfoID" })
            DropColumn("dbo.Tag_Choices", "Tag_Info_Tag_InfoID")
            CreateIndex("dbo.Tag_Info", New String() { "Tag_Choices_Tag_ChoicesID", "Tag_Choices_TagValue" })
            AddForeignKey("dbo.Tag_Info", New String() { "Tag_Choices_Tag_ChoicesID", "Tag_Choices_TagValue" }, "dbo.Tag_Choices", New String() { "Tag_ChoicesID", "TagValue" })
        End Sub
    End Class
End Namespace
