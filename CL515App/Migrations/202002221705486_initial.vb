Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class initial
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Tag_Choices",
                Function(c) New With
                    {
                        .Tag_ChoicesID = c.Int(nullable := False),
                        .TagValue = c.String(nullable := False, maxLength := 50),
                        .TagDescription = c.String(nullable := False, maxLength := 255),
                        .TagActive = c.Boolean(nullable := False),
                        .AddedBy = c.String(nullable := False, maxLength := 50),
                        .AddedAt = c.DateTime(nullable := False),
                        .Tag_InfoID = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) New With { t.Tag_ChoicesID, t.TagValue }) _
                .ForeignKey("dbo.Tag_Info", Function(t) t.Tag_InfoID, cascadeDelete := True) _
                .Index(Function(t) t.Tag_InfoID)
            
            CreateTable(
                "dbo.Tag_Info",
                Function(c) New With
                    {
                        .Tag_InfoID = c.Int(nullable := False, identity := True),
                        .TagName = c.String(maxLength := 50),
                        .TagStatus = c.Boolean(),
                        .AddedBy = c.String(maxLength := 50),
                        .AddedAt = c.DateTime()
                    }) _
                .PrimaryKey(Function(t) t.Tag_InfoID)
            
            CreateTable(
                "dbo.Tag_List",
                Function(c) New With
                    {
                        .PartNumber = c.String(nullable := False, maxLength := 255),
                        .Tag1 = c.String(maxLength := 50),
                        .Tag2 = c.String(maxLength := 50),
                        .Tag3 = c.String(maxLength := 50),
                        .Tag4 = c.String(maxLength := 50),
                        .Tag5 = c.String(maxLength := 50),
                        .Tag6 = c.String(maxLength := 50),
                        .Tag7 = c.String(maxLength := 50),
                        .Tag8 = c.String(maxLength := 50),
                        .Tag9 = c.String(maxLength := 50),
                        .Tag10 = c.String(maxLength := 50),
                        .Tag11 = c.String(maxLength := 50),
                        .Tag12 = c.String(maxLength := 50),
                        .Tag13 = c.String(maxLength := 50),
                        .Tag14 = c.String(maxLength := 50),
                        .Tag15 = c.String(maxLength := 50),
                        .Tag16 = c.String(maxLength := 50),
                        .Tag17 = c.String(maxLength := 50),
                        .Tag18 = c.String(maxLength := 50),
                        .Tag19 = c.String(maxLength := 50),
                        .Tag20 = c.String(maxLength := 50)
                    }) _
                .PrimaryKey(Function(t) t.PartNumber)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Tag_Choices", "Tag_InfoID", "dbo.Tag_Info")
            DropIndex("dbo.Tag_Choices", New String() { "Tag_InfoID" })
            DropTable("dbo.Tag_List")
            DropTable("dbo.Tag_Info")
            DropTable("dbo.Tag_Choices")
        End Sub
    End Class
End Namespace
