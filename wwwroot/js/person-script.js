function getAll() {
    $.get("/Person/PeopleIndex", null, function (data) {
        console.log(data)
    });
}