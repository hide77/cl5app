@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<div class="jumbotron">
    <h1>Manage Reporting Tags</h1>
    <p class="lead">Use this page to access functions that can create, assign values that can be selected for tags, and to assign tag values to parts in the database</p>
</div>

<div class="row">
    <div class="col-md-4">
        <h2>Manage Tag Fields</h2>
        <p>
            Create new reporting tags
        </p>
        <p><a class="btn btn-primary" href="~/Tag_Info/Index">Manage Tag Fields &raquo;</a></p>
    </div>
    <div class="col-md-4">
        <h2>Manage Tag Field Choices</h2>
        <p>
            Manage the choices that can be assigned to each Tag in the database
        </p>
        <p><a class="btn btn-primary" href="~/Tag_Choices/Index">Manage Tag Choices &raquo;</a></p>
    </div>
    <div class="col-md-4">
        <h2>Manage Tags Assigned To Parts</h2>
        <p>
            Assign values to tags for parts in the bill of Materials
        </p>
        <p><a class="btn btn-primary" href="~/Tag_List/Index">Manage Part Tags &raquo;</a></p>
    </div>
</div>