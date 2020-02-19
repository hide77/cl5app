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

Namespace Controllers
    Public Class Exclusion_ListController
        Inherits System.Web.Mvc.Controller

        Private db As New ExclusionList

        ' GET: Exclusion_List
        Async Function Index() As Task(Of ActionResult)
            Return View(Await db.Exclusion_List.ToListAsync())
        End Function

        ' GET: Exclusion_List/Details/5
        Async Function Details(ByVal id As String) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim exclusion_List As Exclusion_List = Await db.Exclusion_List.FindAsync(id)
            If IsNothing(exclusion_List) Then
                Return HttpNotFound()
            End If
            Return View(exclusion_List)
        End Function

        ' GET: Exclusion_List/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Exclusion_List/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Create(<Bind(Include:="PartNumber,ReasonForExclusion")> ByVal exclusion_List As Exclusion_List) As Task(Of ActionResult)
            exclusion_List.AddedAt = Now()
            exclusion_List.AddedBy = HttpContext.User.Identity.Name
            If ModelState.IsValid Then
                db.Exclusion_List.Add(exclusion_List)
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(exclusion_List)
        End Function

        ' GET: Exclusion_List/Edit/5
        Async Function Edit(ByVal id As String) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim exclusion_List As Exclusion_List = Await db.Exclusion_List.FindAsync(id)
            If IsNothing(exclusion_List) Then
                Return HttpNotFound()
            End If
            Return View(exclusion_List)
        End Function

        ' POST: Exclusion_List/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Edit(<Bind(Include:="PartNumber,ReasonForExclusion")> ByVal exclusion_List As Exclusion_List) As Task(Of ActionResult)
            exclusion_List.AddedAt = Now()
            exclusion_List.AddedBy = HttpContext.User.Identity.Name
            If ModelState.IsValid Then
                db.Entry(exclusion_List).State = EntityState.Modified
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(exclusion_List)
        End Function

        ' GET: Exclusion_List/Delete/5
        Async Function Delete(ByVal id As String) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim exclusion_List As Exclusion_List = Await db.Exclusion_List.FindAsync(id)
            If IsNothing(exclusion_List) Then
                Return HttpNotFound()
            End If
            Return View(exclusion_List)
        End Function

        ' POST: Exclusion_List/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Async Function DeleteConfirmed(ByVal id As String) As Task(Of ActionResult)
            Dim exclusion_List As Exclusion_List = Await db.Exclusion_List.FindAsync(id)
            db.Exclusion_List.Remove(exclusion_List)
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
