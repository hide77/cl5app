@ModelType CL515App.PartNumberModified
@Code
    ViewData("Title") = "Synthetic Part Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Synthetic Part Details</h2>

<div>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.PartNumber)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.PartNumber)
        </dd>
        <dt>
            @Html.DisplayNameFor(Function(model) model.OriginalPartNumber)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.OriginalPartNumber)
        </dd>
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
</div>
<p>
    @*@Html.ActionLink("Edit", "Edit", New With {.id = Model.PrimaryKey}) |*@
    @Html.ActionLink("Back to List", "Index")
</p>
