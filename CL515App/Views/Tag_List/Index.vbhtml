@ModelType IEnumerable(Of CL515App.Tag_List)
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
            @Html.DisplayNameFor(Function(model) model.Tag1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag2)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag3)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag4)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag5)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag6)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag7)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag8)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag9)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag10)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag11)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag12)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag13)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag14)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag15)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag16)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag17)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag18)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag19)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Tag20)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag2)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag3)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag4)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag5)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag6)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag7)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag8)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag9)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag10)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag11)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag12)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag13)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag14)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag15)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag16)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag17)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag18)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag19)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Tag20)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.PartNumber }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.PartNumber }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.PartNumber })
        </td>
    </tr>
Next

</table>
