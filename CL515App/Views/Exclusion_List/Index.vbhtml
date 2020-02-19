@ModelType IEnumerable(Of CL515App.Exclusion_List)
@Code
    ViewData("Title") = "Exclusion List Items"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Exclusion List Items</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.PartNumber)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ReasonForExclusion)
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
        @Html.DisplayFor(Function(modelItem) item.PartNumber)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.ReasonForExclusion)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.AddedBy)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.AddedAt)
    </td>
    <td>
        @Html.ActionLink("Edit", "Edit", New With {.id = item.PartNumber}) |
        @Html.ActionLink("Details", "Details", New With {.id = item.PartNumber}) |
        @Html.ActionLink("Delete", "Delete", New With {.id = item.PartNumber})
    </td>
</tr>
Next

</table>
