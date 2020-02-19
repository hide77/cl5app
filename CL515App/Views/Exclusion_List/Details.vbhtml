@ModelType CL515App.Exclusion_List
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Exclusion List Part Details</h4>
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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.PartNumber }) |
    @Html.ActionLink("Back to List", "Index")
</p>
