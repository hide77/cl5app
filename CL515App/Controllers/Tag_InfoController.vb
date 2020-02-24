Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace CL515App
    Public Class Tag_InfoController
        Inherits System.Web.Mvc.Controller

        Private db As New TagModel

        ' GET: Tag_Info
        Async Function Index() As Task(Of ActionResult)
            Return View(Await db.Tag_Info.ToListAsync())
        End Function

        ' GET: Tag_Info/Details/5
        Async Function Details(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tag_Info As Tag_Info = Await db.Tag_Info.FindAsync(id)
            If IsNothing(tag_Info) Then
                Return HttpNotFound()
            End If
            Return View(tag_Info)
        End Function

        ' GET: Tag_Info/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Tag_Info/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Create(<Bind(Include:="Tag_InfoID,TagName,TagStatus,AddedBy,AddedAt")> ByVal tag_Info As Tag_Info) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.Tag_Info.Add(tag_Info)
                Await db.SaveChangesAsync()
                'Dim command As String = String.Concat("ALTER TABLE dbo.Tag_List Add tag_", tag_Info.Tag_InfoID, " nvarchar(50) NOT NULL")
                Dim command As String = String.Concat("ALTER TABLE dbo.Tag_List Add tag_", tag_Info.Tag_InfoID, " nvarchar(50)")
                Await db.Database.ExecuteSqlCommandAsync(command)
                'command = String.Concat("ALTER TABLE dbo.Tag_List Add CONSTRAINT FK_Tag_List_Tag_Info", tag_Info.Tag_InfoID, " FOREIGN KEY ([", tag_Info.Tag_InfoID, "]) REFERENCES dbo.Tag_Choices (TagValue) ON DELETE CASCADE")
                'Await db.Database.ExecuteSqlCommandAsync(command)
                Return RedirectToAction("Index")
            End If
            Return View(tag_Info)
        End Function

        ' GET: Tag_Info/Edit/5
        Async Function Edit(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tag_Info As Tag_Info = Await db.Tag_Info.FindAsync(id)
            If IsNothing(tag_Info) Then
                Return HttpNotFound()
            End If
            Return View(tag_Info)
        End Function

        ' POST: Tag_Info/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Edit(<Bind(Include:="Tag_InfoID,TagName,TagStatus,AddedBy,AddedAt")> ByVal tag_Info As Tag_Info) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.Entry(tag_Info).State = EntityState.Modified
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(tag_Info)
        End Function

        ' GET: Tag_Info/Delete/5
        Async Function Delete(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tag_Info As Tag_Info = Await db.Tag_Info.FindAsync(id)
            If IsNothing(tag_Info) Then
                Return HttpNotFound()
            End If
            Return View(tag_Info)
        End Function

        ' POST: Tag_Info/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Async Function DeleteConfirmed(ByVal id As Integer) As Task(Of ActionResult)
            Dim tag_Info As Tag_Info = Await db.Tag_Info.FindAsync(id)
            'Dim command As String = String.Concat("ALTER TABLE dbo.Tag_List Drop CONSTRAINT FK_Tag_List_Tag_Info", tag_Info.Tag_InfoID)
            Dim command As String = String.Concat("ALTER TABLE dbo.Tag_List DROP COLUMN tag_", tag_Info.Tag_InfoID)
            Await db.Database.ExecuteSqlCommandAsync(command)
            db.Tag_Info.Remove(tag_Info)
            Await db.SaveChangesAsync()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
