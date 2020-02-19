Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Initial
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
                        .AddedAt = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) New With { t.Tag_ChoicesID, t.TagValue })
            
            CreateTable(
                "dbo.Tag_Info",
                Function(c) New With
                    {
                        .Tag_InfoID = c.Int(nullable := False, identity := True),
                        .TagName = c.String(maxLength := 50),
                        .TagStatus = c.Boolean(),
                        .AddedBy = c.String(maxLength := 50),
                        .AddedAt = c.DateTime(),
                        .Tag_Choices_Tag_ChoicesID = c.Int(),
                        .Tag_Choices_TagValue = c.String(maxLength := 50)
                    }) _
                .PrimaryKey(Function(t) t.Tag_InfoID) _
                .ForeignKey("dbo.Tag_Choices", Function(t) New With { t.Tag_Choices_Tag_ChoicesID, t.Tag_Choices_TagValue }) _
                .Index(Function(t) New With { t.Tag_Choices_Tag_ChoicesID, t.Tag_Choices_TagValue })
            
            CreateTable(
                "dbo.Tag_List",
                Function(c) New With
                    {
                        .PartNumber = c.String(nullable := False, maxLength := 255, unicode := false),
                        .Tag1 = c.String(maxLength := 50, unicode := false),
                        .Tag2 = c.String(maxLength := 50, unicode := false),
                        .Tag3 = c.String(maxLength := 50, unicode := false),
                        .Tag4 = c.String(maxLength := 50, unicode := false),
                        .Tag5 = c.String(maxLength := 50, unicode := false),
                        .Tag6 = c.String(maxLength := 50, unicode := false),
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
            DropForeignKey("dbo.Tag_Info", New String() { "Tag_Choices_Tag_ChoicesID", "Tag_Choices_TagValue" }, "dbo.Tag_Choices")
            DropIndex("dbo.Tag_Info", New String() { "Tag_Choices_Tag_ChoicesID", "Tag_Choices_TagValue" })
            DropTable("dbo.Tag_List")
            DropTable("dbo.Tag_Info")
            DropTable("dbo.Tag_Choices")
        End Sub
    End Class
End Namespace
