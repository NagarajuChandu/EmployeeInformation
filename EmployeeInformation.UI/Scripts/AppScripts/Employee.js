$(document).ready(function () {
    $('#btnSearch').click(function () {
        var ID = $('#search').val();
        $.post("Employee/Index", ID)
            .done(function (response, status, jqxhr) {
                // this is the "success" callback
            })
            .fail(function (jqxhr, status, error) {
                // this is the ""error"" callback
            })
    })
})