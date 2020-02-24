
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Tag_List</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>Part Number</dt>
        <dd>@Model(0)</dd>
        @For i = 0 To ViewBag.tag_Info.count - 1
            @<dt>@ViewBag.tag_Info(i).TagName</dt>
            @<dd>@Model(i + 1)</dd>
        Next
    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With {.id = Model(0)}) |
    @Html.ActionLink("Back to List", "Index")
</p>
