

function getAll() {
    $.ajax({
        url: '/AjaxPerson/GetAll',
        type: 'GET',
        success: function (data, textStatus, request) {
            $("#PersonList").html(data);
            $("#status-message").html("Get all persons was succesfull" + "\n StatusCode: " + request.status);
        },
        error: function (request) {

            $("#status-message").html(request.responseText + "\n Status code: " + request.status);
        }
    });
}

function getById() {

    let personIdValue = document.getElementById('input-id').value;
    console.log(personIdValue);
    $.ajax({
        url: '/AjaxPerson/GetById',
        type: 'POST',
        data: jQuery.param({ id: personIdValue }),
        success: function (data, textStatus, request) {
            $("#status-message").html("Get partial view with id: " + personIdValue + " was succesfull " + "\n StatusCode: " + request.status);
            $("#PersonDetails").html(data);
        },
        error: function (request) {

            $("#status-message").html(request.responseText + "\n StatusCode: " + request.status);
        }
    });
}

function deleteById() {
    let personIdvalue = document.getElementById('delete-input-id').value;

    $.ajax({
        url: '/AjaxPerson/Delete',
        type: 'DELETE',
        data: { id: personIdvalue },
        success: function (data, textStatus, request) {
            $("#status-message").html("Deleted person with id: " + personIdvalue + "\n StatusCode: " + request.status);
        },
        error: function (request) {

            $("#status-message").html(request.responseText + "\n StatusCode: " + request.status);
        }
    });
}



