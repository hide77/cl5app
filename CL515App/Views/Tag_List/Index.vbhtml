@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Assign Tags to Parts</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>Part Number</th>
        @For Each item In ViewBag.tag_Info
            @<th>@item.TagName</th>
        Next
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        @For Each sub_item In item
            @<td>@sub_item</td>
        Next
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item(0)}) |
            @Html.ActionLink("Details", "Details", New With {.id = item(0)}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item(0)})
        </td>
    </tr>
Next

</table>
