@Code
    ViewData("Title") = "Edit"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>Tag_List</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

        @For i = 0 To ViewBag.tag_Info.count - 1
            @<div Class="form-group">
                <label class="control-label col-md-2">@ViewBag.tag_Info(i).TagName</label>
                <div Class="col-md-10">
                    <select class="form-control" name="tag_@ViewBag.tag_Info(i).Tag_InfoID">
                        @If IsDBNull(Model(i + 1)) Then
                            @<option disabled selected> -- select an option -- </option>
                            @For Each sub_item In ViewBag.tag_Info(i).Tag_Choice
                                @<option value="@sub_item.TagValue">@sub_item.TagValue</option>
                            Next
                        Else
                            @For Each sub_item In ViewBag.tag_Info(i).Tag_Choice
                                If sub_item.TagValue = Model(i + 1) Then
                                    @<option value="@sub_item.TagValue" selected>@sub_item.TagValue</option>
                                Else
                                    @<option value="@sub_item.TagValue">@sub_item.TagValue</option>
                                End If
                            Next
                        End If
                    </select>
                </div>
            </div>
        Next
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-default" />
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
