Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Net
Imports System.Web
Imports System.Web.Mvc

Namespace CL515App
    Public Class Tag_ListController
        Inherits System.Web.Mvc.Controller

        Private db As New TagModel

        ' GET: Tag_List
        Async Function Index() As Task(Of ActionResult)
            Return View(Await db.Tag_List.ToListAsync())
        End Function

        ' GET: Tag_List/Details/5
        Async Function Details(ByVal id As String) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tag_List As Tag_List = Await db.Tag_List.FindAsync(id)
            If IsNothing(tag_List) Then
                Return HttpNotFound()
            End If
            Return View(tag_List)
        End Function

        ' GET: Tag_List/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Tag_List/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Create(<Bind(Include:="PartNumber,Tag1,Tag2,Tag3,Tag4,Tag5,Tag6,Tag7,Tag8,Tag9,Tag10,Tag11,Tag12,Tag13,Tag14,Tag15,Tag16,Tag17,Tag18,Tag19,Tag20")> ByVal tag_List As Tag_List) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.Tag_List.Add(tag_List)
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(tag_List)
        End Function

        ' GET: Tag_List/Edit/5
        Async Function Edit(ByVal id As String) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tag_List As Tag_List = Await db.Tag_List.FindAsync(id)
            If IsNothing(tag_List) Then
                Return HttpNotFound()
            End If
            Return View(tag_List)
        End Function

        ' POST: Tag_List/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Edit(<Bind(Include:="PartNumber,Tag1,Tag2,Tag3,Tag4,Tag5,Tag6,Tag7,Tag8,Tag9,Tag10,Tag11,Tag12,Tag13,Tag14,Tag15,Tag16,Tag17,Tag18,Tag19,Tag20")> ByVal tag_List As Tag_List) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.Entry(tag_List).State = EntityState.Modified
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(tag_List)
        End Function

        ' GET: Tag_List/Delete/5
        Async Function Delete(ByVal id As String) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tag_List As Tag_List = Await db.Tag_List.FindAsync(id)
            If IsNothing(tag_List) Then
                Return HttpNotFound()
            End If
            Return View(tag_List)
        End Function

        ' POST: Tag_List/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Async Function DeleteConfirmed(ByVal id As String) As Task(Of ActionResult)
            Dim tag_List As Tag_List = Await db.Tag_List.FindAsync(id)
            db.Tag_List.Remove(tag_List)
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
