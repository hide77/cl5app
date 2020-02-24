Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Entity
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Net
Imports System.Web
Imports System.Web.Configuration
Imports System.Web.Mvc

Namespace CL515App
    Public Class Tag_ListController
        Inherits System.Web.Mvc.Controller

        Private db As New TagModel

        ' GET: Tag_List
        Async Function Index() As Task(Of ActionResult)
            ViewBag.tag_Info = Await db.Tag_Info.ToListAsync()
            Dim connectionString As String = WebConfigurationManager.ConnectionStrings.Item("LocalModel").ConnectionString
            Dim conn As SqlConnection = New SqlConnection(connectionString)
            conn.Open()
            Dim command As SqlCommand = New SqlCommand("SELECT * FROM dbo.Tag_List", conn)
            Dim sqlDA As SqlDataAdapter = New SqlDataAdapter(command)
            Dim dataSet As DataSet = New DataSet()
            sqlDA.Fill(dataSet)
            Dim viewData As ArrayList = New ArrayList
            For Each rowData As DataRow In dataSet.Tables.Item(0).Rows
                viewData.Add(rowData.ItemArray)
            Next
            conn.Close()
            Return View(viewData)
        End Function
        Function get_TagList_ByID(ByVal id As Integer) As Object
            Dim connectionString As String = WebConfigurationManager.ConnectionStrings.Item("LocalModel").ConnectionString
            Dim conn As SqlConnection = New SqlConnection(connectionString)
            conn.Open()
            Dim command As SqlCommand = New SqlCommand("SELECT * FROM dbo.Tag_List WHERE PartNumber='" & id & "'", conn)
            Dim sqlDA As SqlDataAdapter = New SqlDataAdapter(command)
            Dim dataSet As DataSet = New DataSet()
            sqlDA.Fill(dataSet)
            conn.Close()
            Return dataSet.Tables.Item(0).Rows.Item(0).ItemArray
        End Function
        ' GET: Tag_List/Details/5
        Async Function Details(ByVal id As String) As Task(Of ActionResult)
            ViewBag.tag_Info = Await db.Tag_Info.ToListAsync()
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tag_List As Object = get_TagList_ByID(id)
            If IsNothing(tag_List) Then
                Return HttpNotFound()
            End If
            Return View(tag_List)
        End Function

        ' GET: Tag_List/Create
        Function Create() As ActionResult
            ViewBag.tag_Info = db.Tag_Info.ToList()
            Return View()
        End Function

        ' POST: Tag_List/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Create(ByVal formData As FormCollection) As Task(Of ActionResult)
            If ModelState.IsValid Then
                Dim command As String = "INSERT INTO dbo.Tag_List ("
                For i As Integer = 1 To formData.Count - 1
                    command = String.Concat(command, formData.AllKeys(i), ",")
                Next
                command = command.Remove(command.Length - 1)
                command = String.Concat(command, ") VALUES (")
                For i As Integer = 1 To formData.Count - 1
                    command = String.Concat(command, "'", formData.Get(i), "'", ",")
                Next
                command = command.Remove(command.Length - 1)
                command = String.Concat(command, ")")
                'db.Tag_List.SqlQuery(command)
                'Dim command As String = String.Concat("ALTER TABLE dbo.Tag_List Add tag", Tag_Info.Tag_InfoID, " nvarchar(50) NOT NULL")
                Await db.Database.ExecuteSqlCommandAsync(command)
                'Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View()
        End Function

        ' GET: Tag_List/Edit/5
        Async Function Edit(ByVal id As String) As Task(Of ActionResult)
            ViewBag.tag_Info = Await db.Tag_Info.ToListAsync()
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tag_List As Object = get_TagList_ByID(id)
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
        Async Function Edit(ByVal id As String, ByVal formData As FormCollection) As Task(Of ActionResult)
            If ModelState.IsValid Then
                Dim command As String = "UPDATE dbo.Tag_List SET "
                For i As Integer = 1 To formData.Count - 1
                    command = String.Concat(command, formData.AllKeys(i), "='", formData.Get(i), "',")
                Next
                command = command.Remove(command.Length - 1)
                command = String.Concat(command, " WHERE PartNumber='", id, "'")
                Await db.Database.ExecuteSqlCommandAsync(command)
                Return RedirectToAction("Index")
            End If
            Dim tag_List As Object = get_TagList_ByID(id)
            Return View(tag_List)
        End Function

        ' GET: Tag_List/Delete/5
        Async Function Delete(ByVal id As String) As Task(Of ActionResult)
            ViewBag.tag_Info = Await db.Tag_Info.ToListAsync()
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tag_List As Object = get_TagList_ByID(id)
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
