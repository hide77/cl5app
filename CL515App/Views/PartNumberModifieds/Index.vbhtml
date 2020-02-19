@ModelType IEnumerable(Of CL515App.PartNumberModified)
@Code
    ViewData("Title") = "Synthetic Parts"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>List of Synthetic Parts</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.PartNumber)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.OriginalPartNumber)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ReasonForMod)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ModBy)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ModAt)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
    <td>
        @Html.DisplayFor(Function(modelItem) item.PartNumber)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.OriginalPartNumber)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.ReasonForMod)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.ModBy)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.ModAt)
    </td>
    <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.PartNumber, .id2 = item.OriginalPartNumber}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.PartNumber, .id2 = item.OriginalPartNumber}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PartNumber, .id2 = item.OriginalPartNumber})
    </td>
</tr>
Next

</table>
