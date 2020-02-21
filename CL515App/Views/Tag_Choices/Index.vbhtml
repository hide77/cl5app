@ModelType IEnumerable(Of CL515App.Tag_Choices)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Manage Tag Field Choices</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<select>
    @For Each item In ViewBag.tag_Info
        @<option value="@item.Tag_InfoID">@item.TagName</option>
    Next
</select>
<br/>
<br/>
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
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Tag_ChoicesID}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Tag_ChoicesID}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Tag_ChoicesID})
        </td>
    </tr>
Next

</table>
