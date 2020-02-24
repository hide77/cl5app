
@ModelType IEnumerable(Of CL515App.Tag_Choices)
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Manage Tag Field Choices</h2>

<p>
    <a id="choice_create_link">Create New</a>
</p>

<select id="tag_name">
    @For Each item In ViewBag.tag_Info
        @If item.Tag_InfoID = ViewBag.tag_InfoID Then
            @<option value="@item.Tag_InfoID" selected>@item.TagName</option>
        Else
            @<option value="@item.Tag_InfoID">@item.TagName</option>
        End If
    Next
</select>

<br />
<br />
<Table Class="table">
    <tr>
            <th>
            Tag Name
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TagDescription)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TagActive)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.AddedBy)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.AddedAt)
        </th>
        <th></th>
    </tr>

    @For Each item In Model
        @<tr>
            <th>
                @Html.DisplayFor(Function(modelItem) item.Tag_Info.TagName)
            </th>
            <td>
                @Html.DisplayFor(Function(modelItem) item.TagDescription)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.TagActive)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.AddedBy)
            </td>
            <td>
                @Html.DisplayFor(Function(modelItem) item.AddedAt)
            </td>
            <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.Tag_ChoicesID, .tag_InfoID = ViewBag.tag_InfoID}) |
                @Html.ActionLink("Details", "Details", New With {.id = item.Tag_ChoicesID, .tag_InfoID = ViewBag.tag_InfoID}) |
                @Html.ActionLink("Delete", "Delete", New With {.id = item.Tag_ChoicesID, .tag_InfoID = ViewBag.tag_InfoID})
            </td>
        </tr>
    Next

</Table>

<Script type="text/javascript">
    $(function () {
        $("#choice_create_link").click(function () {
            console.log($("#tag_name").val());
            if($("#tag_name").val() == null)
                return;
            location.href = "/Tag_Choices/Create/" + $("#tag_name").val();
        });
        $("#tag_name").on("change", function () {
            location.href = "/Tag_Choices/Show/" + $(this).val();
        })
    });
</Script>
