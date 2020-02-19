@Code
    ViewData("Title") = "CL515 BOM Data Modification"
End Code

<div class="jumbotron">
    <h1>CL515 Data Management</h1>
    <p class="lead">Use this page to access functions that modify item data in the CL515 BOM report page</p>
    <p><a href="http://cnsserver6/reports/report/Viking/Menu" class="btn btn-primary btn-lg">Direct to BOM Reports &raquo;</a></p>
</div>

<div class="row">
    <div class="col-md-4">
        <h2>Add/Delete Parts From The Exclusion List</h2>
        <p>Add or Delete Items from the list that excludes a part from the count of items that match between the EBom and the MBom</p>
        <p><a class="btn btn-primary" href="~/Exclusion_List/Index">Exclusion List &raquo;</a></p>
    </div>
    <div class="col-md-4">
        <h2>Add/Delete Parts From The Synthetic Parts List</h2>
        <p>Add or delete items that replace items in the original BOM lists with replacement items</p>
        <p><a class="btn btn-primary" href="~/PartNumberModifieds/Index">Synthetic Parts &raquo;</a></p>
    </div>
    <div class="col-md-4">
        <h2>Manage Tags and Tag Values</h2>
        <p>
            Create new reporting tags and manage the values that can be assigned to tags in the data
        </p>
        <p><a class="btn btn-primary" href="~/Home/ManageTags">Manage Tags &raquo;</a></p>
    </div>

</div>
