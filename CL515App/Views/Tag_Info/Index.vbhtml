@ModelType IEnumerable(Of CL515App.Tag_Info)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Manage Tag Fields</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag_InfoID)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TagName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TagStatus)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.AddedBy)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.AddedAt)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag_InfoID)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TagName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TagStatus)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.AddedBy)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.AddedAt)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Tag_InfoID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Tag_InfoID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Tag_InfoID })
        </td>
    </tr>
Next

</table>
