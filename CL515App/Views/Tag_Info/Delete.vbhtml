@ModelType CL515App.Tag_Info
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
