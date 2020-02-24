@ModelType CL515App.Tag_List
@Code
    ViewData("Title") = "Create"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Create</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>Tag_List</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        <div class="form-group">
            @Html.LabelFor(Function(model) model.PartNumber, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PartNumber, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.PartNumber, "", New With {.class = "text-danger"})
            </div>
        </div>
        @For Each item In ViewBag.tag_Info
            @<div Class="form-group">
                <label class="control-label col-md-2">@item.TagName</label>
                <div Class="col-md-10">
                    <select class="form-control" name="tag_@item.Tag_InfoID">
                        @For Each sub_item In item.Tag_Choice
                            @<option value="@sub_item.TagValue">@sub_item.TagValue</option>
                        Next
                    </select>
                </div>
            </div>
        Next

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
