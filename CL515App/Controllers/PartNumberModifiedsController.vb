Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports CL515App

Namespace Views
    Public Class PartNumberModifiedsController
        Inherits System.Web.Mvc.Controller

        Private db As New ExclusionList

        ' GET: PartNumberModifieds
        Async Function Index() As Task(Of ActionResult)
            Return View(Await db.PartNumberModifieds.ToListAsync())
        End Function

        ' GET: PartNumberModifieds/Details/5
        Async Function Details(ByVal id As String, id2 As String) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim partNumberModified As PartNumberModified = Await db.PartNumberModifieds.FindAsync(id, id2)
            If IsNothing(partNumberModified) Then
                Return HttpNotFound()
            End If
            Return View(partNumberModified)
        End Function

        ' GET: PartNumberModifieds/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: PartNumberModifieds/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Create(<Bind(Include:="PartNumber,OriginalPartNumber,ReasonForMod")> ByVal partNumberModified As PartNumberModified) As Task(Of ActionResult)
            partNumberModified.ModAt = Now()
            partNumberModified.ModBy = HttpContext.User.Identity.Name
            If ModelState.IsValid Then
                db.PartNumberModifieds.Add(partNumberModified)
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(partNumberModified)
        End Function

        ' GET: PartNumberModifieds/Edit/5
        Async Function Edit(ByVal id As String, id2 As String) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim partNumberModified As PartNumberModified = Await db.PartNumberModifieds.FindAsync(id, id2)
            If IsNothing(partNumberModified) Then
                Return HttpNotFound()
            End If
            Return View(partNumberModified)
        End Function

        ' POST: PartNumberModifieds/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Edit(<Bind(Include:="PartNumber,OriginalPartNumber,ReasonForMod")> ByVal partNumberModified As PartNumberModified) As Task(Of ActionResult)
            partNumberModified.ModAt = Now()
            partNumberModified.ModBy = HttpContext.User.Identity.Name
            If ModelState.IsValid Then
                db.Entry(partNumberModified).State = EntityState.Modified
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(partNumberModified)
        End Function

        ' GET: PartNumberModifieds/Delete/5
        Async Function Delete(ByVal id As String, id2 As String) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim partNumberModified As PartNumberModified = Await db.PartNumberModifieds.FindAsync(id, id2)
            If IsNothing(partNumberModified) Then
                Return HttpNotFound()
            End If
            Return View(partNumberModified)
        End Function

        ' POST: PartNumberModifieds/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Async Function DeleteConfirmed(ByVal id As String, id2 As String) As Task(Of ActionResult)
            Dim partNumberModified As PartNumberModified = Await db.PartNumberModifieds.FindAsync(id, id2)
            db.PartNumberModifieds.Remove(partNumberModified)
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
