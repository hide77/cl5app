@ModelType CL515App.PartNumberModified
@Code
    ViewData("Title") = "Edit Synthetic Part"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Edit Synthetic Part</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
    <h4></h4>
    <hr />
    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
    @Html.HiddenFor(Function(model) model.PartNumber)

    @Html.HiddenFor(Function(model) model.OriginalPartNumber)

    <div class="form-group">
        @Html.LabelFor(Function(model) model.PartNumber, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.PartNumber, New With {.htmlAttributes = New With {.class = "form-control", .disabled = "disabled"}})
            @Html.ValidationMessageFor(Function(model) model.PartNumber, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.OriginalPartNumber, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.OriginalPartNumber, New With {.htmlAttributes = New With {.class = "form-control", .disabled = "disabled"}})
            @Html.ValidationMessageFor(Function(model) model.OriginalPartNumber, "", New With {.class = "text-danger"})
        </div>
    </div>
    <div class="form-group">
        @Html.LabelFor(Function(model) model.ReasonForMod, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.ReasonForMod, New With {.htmlAttributes = New With {.class = "form-control"}})
            @Html.ValidationMessageFor(Function(model) model.ReasonForMod, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.ModBy, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.ModBy, New With {.htmlAttributes = New With {.class = "form-control", .disabled = "disabled"}})
            @Html.ValidationMessageFor(Function(model) model.ModBy, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(model) model.ModAt, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
            @Html.EditorFor(Function(model) model.ModAt, New With {.htmlAttributes = New With {.class = "form-control", .disabled = "disabled"}})
            @Html.ValidationMessageFor(Function(model) model.ModAt, "", New With {.class = "text-danger"})
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
