const hostname = window.location.hostname;


function getAll() {
    $.get("/AjaxPerson/GetAll", null, function (data) {
        console.log(data);
        $("#PersonList").html(data);
    });
}