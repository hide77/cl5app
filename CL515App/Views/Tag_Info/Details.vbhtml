@ModelType CL515App.Tag_Info
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Tag_Info</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.TagName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TagName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TagStatus)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TagStatus)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.AddedBy)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.AddedBy)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.AddedAt)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.AddedAt)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Tag_InfoID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
