@ModelType CL515App.Tag_Choices
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Show", New With {.id = ViewBag.tag_InfoID})
        </div>
    End Using
</div>
