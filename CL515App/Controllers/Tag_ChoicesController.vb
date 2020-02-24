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
            Dim tag_Info = Await db.Tag_Info.FirstAsync()
            Return RedirectToAction("Show", New With {.id = tag_Info.Tag_InfoID})
        End Function
        Async Function Show(ByVal id As Integer) As Task(Of ActionResult)
            ViewBag.tag_Info = Await db.Tag_Info.ToListAsync()
            ViewBag.tag_InfoID = id
            Return View(Await db.Tag_Choices.Where(Function(item) item.Tag_Info.Tag_InfoID = id).ToListAsync())
        End Function

        ' GET: Tag_Choices/Details/5
        Function Details(ByVal tag_InfoID As Integer, ByVal id As Integer?) As ActionResult
            ViewBag.tag_InfoID = tag_InfoID
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tag_Choices As Tag_Choices = db.Tag_Choices.Where(Function(item) item.Tag_ChoicesID = id).First()
            If IsNothing(tag_Choices) Then
                Return HttpNotFound()
            End If
            Return View(tag_Choices)
        End Function

        ' GET: Tag_Choices/Create
        Function Create(ByVal id As Integer?) As ActionResult
            ViewBag.tag_InfoID = id
            Return View()
        End Function

        ' POST: Tag_Choices/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Create(<Bind(Include:="Tag_ChoicesID,TagValue,TagDescription,TagActive,AddedBy,AddedAt")> ByVal tag_Choices As Tag_Choices, ByVal tag_InfoID As Integer) As Task(Of ActionResult)
            Dim tag_Info As Tag_Info = Await db.Tag_Info.FindAsync(tag_InfoID)
            tag_Choices.Tag_Info_Tag_InfoID = tag_InfoID
            If ModelState.IsValid Then
                db.Tag_Choices.Add(tag_Choices)
                Await db.SaveChangesAsync()
                Return RedirectToAction("Show", New With {.id = tag_InfoID})
            End If
            Return View(tag_Choices)
        End Function

        ' GET: Tag_Choices/Edit/5
        Function Edit(ByVal tag_InfoID As Integer, ByVal id As Integer?) As ActionResult
            ViewBag.tag_InfoID = tag_InfoID
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tag_Choices As Tag_Choices = db.Tag_Choices.Where(Function(item) item.Tag_ChoicesID = id).First()
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
        Async Function Edit(ByVal tag_InfoID As Integer, <Bind(Include:="Tag_ChoicesID,TagValue,TagDescription,TagActive,AddedBy,AddedAt")> ByVal tag_Choices As Tag_Choices) As Task(Of ActionResult)
            tag_Choices.Tag_Info_Tag_InfoID = tag_InfoID
            If ModelState.IsValid Then
                db.Entry(tag_Choices).State = EntityState.Modified
                Await db.SaveChangesAsync()
                Return RedirectToAction("Show", New With {.id = tag_InfoID})
            End If
            Return View(tag_Choices)
        End Function

        ' GET: Tag_Choices/Delete/5
        Function Delete(ByVal tag_InfoID As Integer, ByVal id As Integer?) As ActionResult
            ViewBag.tag_InfoID = tag_InfoID
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tag_Choices As Tag_Choices = db.Tag_Choices.Where(Function(item) item.Tag_ChoicesID = id).First()
            If IsNothing(tag_Choices) Then
                Return HttpNotFound()
            End If
            Return View(tag_Choices)
        End Function

        ' POST: Tag_Choices/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Async Function DeleteConfirmed(ByVal tag_InfoID As Integer, ByVal id As Integer) As Task(Of ActionResult)
            Dim tag_Choices As Tag_Choices = db.Tag_Choices.Where(Function(item) item.Tag_ChoicesID = id).First()
            db.Tag_Choices.Remove(tag_Choices)
            Await db.SaveChangesAsync()
            Return RedirectToAction("Show", New With {.id = tag_InfoID})
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
