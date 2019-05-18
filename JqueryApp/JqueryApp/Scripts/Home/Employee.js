/// <reference path="../jquery-3.3.1.js" />
$(document).ready(function () {

    $("#btnAdd").click(function () {
        $.ajax({
            url: '/Home/_AddEmployee',
            contentType: 'application/json; charset=utf-8',
            type: 'GET',
            dataType: 'html',
            success: function (data) {
                var creatediv = $('#createview');
                creatediv.empty();
                creatediv.html(data);
            },
            error: function (err) {
                alert(err.statusText + err.responseText);
            }
        });
    });
});