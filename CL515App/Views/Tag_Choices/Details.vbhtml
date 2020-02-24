@ModelType CL515App.Tag_Choices
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Tag_Choices</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.TagDescription)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TagDescription)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TagActive)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TagActive)
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
    @*@Html.ActionLink("Edit", "Edit", New With {.id = Model.PrimaryKey}) |*@
    @Html.ActionLink("Back to List", "Show", New With {.id = ViewBag.tag_InfoID})
</p>
