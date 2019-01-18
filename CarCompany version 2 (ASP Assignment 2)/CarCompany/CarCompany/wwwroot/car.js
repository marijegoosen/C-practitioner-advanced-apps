const uri = "api/cars";
let todos = null;
function getCount(data) {
    const el = $("#counter");
    let name = "car";
    if (data) {
        if (data > 1) {
            name = "cars";
        }
        el.text(data + " " + name);
    } else {
        el.text("No " + name);
    }
}

$(document).ready(function () {
    getData();
});

function getData() {
    $.ajax({
        type: "GET",
        url: uri,
        cache: false,
        success: function (data) {
            const tBody = $("#cars");

            $(tBody).empty();

            getCount(data.length);

            $.each(data, function (key, item) {
                const tr = $("<tr></tr>")
                    .append($("<td></td>").text(item.name))
                    .append($("<td></td>").text(item.model))
                    .append($("<td></td>").text(item.description))
                    .append($("<td></td>").text(item.range))
                    .append($("<td></td>").text(item.milage))
                    .append($("<td></td>").text(item.company))
                    .append($("<td></td>").text(item.user))
                    .append(
                        $("<td></td>").append(
                            $("<button>Edit</button>").on("click", function () {
                                editItem(item.id);
                            })
                        )
                    )
                    .append(
                        $("<td></td>").append(
                            $("<button>Delete</button>").on("click", function () {
                                deleteItem(item.id);
                            })
                        )
                    );

                tr.appendTo(tBody);
            });

            cars = data;
        }
    });
}

function addItem() {
    const item = {
        name: $("#add-name").val(),
        model: $("add-model").val(),
        description: $("add-description").val(),
        range: $("add-range").val(),
        milage: $("add-milage").val(),
        company: $("add-company").val(),
        user: $("add-user").val(),
    };

    $.ajax({
        type: "POST",
        accepts: "application/json",
        url: uri,
        contentType: "application/json",
        data: JSON.stringify(item),
        error: function (jqXHR, textStatus, errorThrown) {
            alert("Something went wrong!");
        },
        success: function (result) {
            getData();
            $("#add-name").val(""),
            $("#add-model").val(""),
            $("#add-range").val(""),
            $("#add-description").val(""),
            $("#add-milage").val(""),
            $("#add-company").val(""),
            $("#add-user").val("")
        }
    });
}

function deleteItem(id) {
    $.ajax({
        url: uri + "/" + id,
        type: "DELETE",
        error: function (jqXHR, textStatus, errorThrown) {
            alert("Something went wrong!");
        },
        success: function (result) {
            getData();
        }
    });
}

function editItem(id) {
    $.each(todos, function (key, item) {
        if (item.id === id) {
            $("#edit-name").val(item.name),
            $("#edit-id").val(item.id),
            $("#edit-model").val(item.model),
            $("#edit-description").val(item.description),
            $("#edit-range").val(item.range),
            $("#edit-milage").val(item.milage),
            $("#edit-company").val(item.company),
            $("#edit-user").val(item.user)
        }
    });
    $("#spoiler").css({ display: "block" });
}

$(".my-form").on("submit", function () {
    const item = {
        name: $("#edit-name").val(),
        id: $("#edit-id").val(),
        model: $("edit-model").val(), 
        description: $("edit-description").val(),
        range: $("edit-range").val(),
        milage: $("edit-milage").val(),
        company: $("edit-company").val(),
        user: $("edit-user").val()
    };

    $.ajax({
        url: uri + "/" + $("#edit-id").val(),
        type: "PUT",
        accepts: "application/json",
        contentType: "application/json",
        data: JSON.stringify(item),
        error: function (jqXHR, textStatus, errorThrown) {
            alert("Something went wrong!");
        },
        success: function (result) {
            getData();
        }
    });

    closeInput();
    return false;
});

function closeInput() {
    $("#spoiler").css({ display: "none" });
}