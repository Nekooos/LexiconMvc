function getAll() {
    $.ajax({
        type: 'GET',
        url: '/Person/Index',
        dataType: 'json',

        success: function (result) {
            console.log('Data received: ');
            console.log(result);
        }
    });
}