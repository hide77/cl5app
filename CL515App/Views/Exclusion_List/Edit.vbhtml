@ModelType CL515App.Exclusion_List
@Code
    ViewData("Title") = "Edit"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Edit Exclusion List Reason</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        @Html.HiddenFor(Function(model) model.PartNumber)
        <div class="form-group">
            @Html.LabelFor(Function(model) model.PartNumber, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.PartNumber, New With {.htmlAttributes = New With {.class = "form-control", .disabled = "disabled"}})
                @Html.ValidationMessageFor(Function(model) model.PartNumber, "", New With {.class = "text-danger"})
            </div>
            @Html.LabelFor(Function(model) model.ReasonForExclusion, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.ReasonForExclusion, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.ReasonForExclusion, "", New With {.class = "text-danger"})
            </div>
            @Html.LabelFor(Function(model) model.AddedBy, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.AddedBy, New With {.htmlAttributes = New With {.class = "form-control", .disabled = "disabled"}})
                @Html.ValidationMessageFor(Function(model) model.AddedBy, "", New With {.class = "text-danger"})
            </div>
            @Html.LabelFor(Function(model) model.AddedAt, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.AddedAt, New With {.htmlAttributes = New With {.class = "form-control", .disabled = "disabled"}})
                @Html.ValidationMessageFor(Function(model) model.AddedAt, "", New With {.class = "text-danger"})
            </div>
        </div>

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
