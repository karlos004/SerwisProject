var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tbData').DataTable({
        "ajax": {
            "url": "/Admin/Repair/GetAll"
        },
        "columns": [
            { "data": "id", "width": "20%" },
            { "data": "vin", "width": "20%" },
            { "data": "description", "width": "30%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                    <div class="text-center">
    <a href="/Admin/Repair/Upsert/${data}" class="btn btn-succsess text-white">
        <i class="fas fa-trash-alt"></i>
    </a>
    <a href="#" class="btn btn-danger text-white" style="cursor: pointer">
        <i class="fas fa-trash-alt"></i>
    </a>
</div>
                            `;
                }, "width": "30%"
            },
        ]
    });
}