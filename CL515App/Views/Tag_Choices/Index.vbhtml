@ModelType IEnumerable(Of CL515App.Tag_Choices)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.TagDescription)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TagActive)
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
            @Html.DisplayFor(Function(modelItem) item.TagDescription)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TagActive)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.AddedBy)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.AddedAt)
        </td>
        <td>
            @*@Html.ActionLink("Edit", "Edit", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.PrimaryKey}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PrimaryKey})*@
        </td>
    </tr>
Next

</table>
