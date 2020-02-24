Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class update_tag_list
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropColumn("dbo.Tag_List", "Tag1")
            DropColumn("dbo.Tag_List", "Tag2")
            DropColumn("dbo.Tag_List", "Tag3")
            DropColumn("dbo.Tag_List", "Tag4")
            DropColumn("dbo.Tag_List", "Tag5")
            DropColumn("dbo.Tag_List", "Tag6")
            DropColumn("dbo.Tag_List", "Tag7")
            DropColumn("dbo.Tag_List", "Tag8")
            DropColumn("dbo.Tag_List", "Tag9")
            DropColumn("dbo.Tag_List", "Tag10")
            DropColumn("dbo.Tag_List", "Tag11")
            DropColumn("dbo.Tag_List", "Tag12")
            DropColumn("dbo.Tag_List", "Tag13")
            DropColumn("dbo.Tag_List", "Tag14")
            DropColumn("dbo.Tag_List", "Tag15")
            DropColumn("dbo.Tag_List", "Tag16")
            DropColumn("dbo.Tag_List", "Tag17")
            DropColumn("dbo.Tag_List", "Tag18")
            DropColumn("dbo.Tag_List", "Tag19")
            DropColumn("dbo.Tag_List", "Tag20")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Tag_List", "Tag20", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_List", "Tag19", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_List", "Tag18", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_List", "Tag17", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_List", "Tag16", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_List", "Tag15", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_List", "Tag14", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_List", "Tag13", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_List", "Tag12", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_List", "Tag11", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_List", "Tag10", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_List", "Tag9", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_List", "Tag8", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_List", "Tag7", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_List", "Tag6", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_List", "Tag5", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_List", "Tag4", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_List", "Tag3", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_List", "Tag2", Function(c) c.String(maxLength := 50))
            AddColumn("dbo.Tag_List", "Tag1", Function(c) c.String(maxLength := 50))
        End Sub
    End Class
End Namespace
