@ModelType CL515App.PartNumberModified
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete Synthetic Part</h2>

<h3>Are you sure you want to delete this Synthetic Part?</h3>
<div>
    <h4></h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.ReasonForMod)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ReasonForMod)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ModBy)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ModBy)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ModAt)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ModAt)
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
