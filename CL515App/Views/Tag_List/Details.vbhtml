@ModelType CL515App.Tag_List
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Tag_List</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag2)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag2)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag3)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag3)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag4)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag4)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag5)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag5)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag6)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag6)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag7)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag7)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag8)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag8)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag9)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag9)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag10)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag10)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag11)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag11)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag12)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag12)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag13)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag13)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag14)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag14)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag15)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag15)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag16)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag16)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag17)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag17)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag18)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag18)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag19)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag19)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Tag20)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Tag20)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.PartNumber }) |
    @Html.ActionLink("Back to List", "Index")
</p>
