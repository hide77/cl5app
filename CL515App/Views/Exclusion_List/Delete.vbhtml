@ModelType CL515App.Exclusion_List
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Are you sure you want to delete this Part from the Exclusion List?</h2>

<div>
    <h4>Exclusion List Delete For : </h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.PartNumber)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PartNumber)
        </dd>
        <dt>
            @Html.DisplayNameFor(Function(model) model.ReasonForExclusion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ReasonForExclusion)
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
