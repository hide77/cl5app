
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
