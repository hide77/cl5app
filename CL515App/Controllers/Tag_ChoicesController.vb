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
    Public Class Tag_ChoicesController
        Inherits System.Web.Mvc.Controller

        Private db As New TagModel

        ' GET: Tag_Choices
        Async Function Index() As Task(Of ActionResult)
            Return View(Await db.Tag_Choices.ToListAsync())
        End Function

        ' GET: Tag_Choices/Details/5
        Async Function Details(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tag_Choices As Tag_Choices = Await db.Tag_Choices.FindAsync(id)
            If IsNothing(tag_Choices) Then
                Return HttpNotFound()
            End If
            Return View(tag_Choices)
        End Function

        ' GET: Tag_Choices/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Tag_Choices/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Create(<Bind(Include:="Tag_ChoicesID,TagValue,TagDescription,TagActive,AddedBy,AddedAt")> ByVal tag_Choices As Tag_Choices) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.Tag_Choices.Add(tag_Choices)
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(tag_Choices)
        End Function

        ' GET: Tag_Choices/Edit/5
        Async Function Edit(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tag_Choices As Tag_Choices = Await db.Tag_Choices.FindAsync(id)
            If IsNothing(tag_Choices) Then
                Return HttpNotFound()
            End If
            Return View(tag_Choices)
        End Function

        ' POST: Tag_Choices/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Edit(<Bind(Include:="Tag_ChoicesID,TagValue,TagDescription,TagActive,AddedBy,AddedAt")> ByVal tag_Choices As Tag_Choices) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.Entry(tag_Choices).State = EntityState.Modified
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(tag_Choices)
        End Function

        ' GET: Tag_Choices/Delete/5
        Async Function Delete(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tag_Choices As Tag_Choices = Await db.Tag_Choices.FindAsync(id)
            If IsNothing(tag_Choices) Then
                Return HttpNotFound()
            End If
            Return View(tag_Choices)
        End Function

        ' POST: Tag_Choices/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Async Function DeleteConfirmed(ByVal id As Integer) As Task(Of ActionResult)
            Dim tag_Choices As Tag_Choices = Await db.Tag_Choices.FindAsync(id)
            db.Tag_Choices.Remove(tag_Choices)
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
