/// <reference path="../jquery-3.3.1.js" />
$(document).ready(function () {

    $("#btnAdd").click(function () {

        $("#dialog").dialog("open");

        $.ajax({
            url: '/Home/_AddEmployee',
            contentType: 'application/json; charset=utf-8',
            type: 'GET',
            dataType: 'html',
            success: function (data) {
                var creatediv = $('#dialog');
                creatediv.empty();
                creatediv.html(data);
            },
            error: function (err) {
                alert(err.statusText + err.responseText);
            }
        });
    });

    $("#btnCreate").click(function () {

        var employee = {};
        employee.Name = $('#Name').val();
        employee.Gender = $('#Gender').val();
        employee.Department = $('#Department').val();

        $.ajax({
            url: '/Home/AddEmployee',
            contentType: 'application/json; charset=utf-8',
            type: 'POST',
            data: '{emp:' + JSON.stringify(employee) + '}',
            success: function (data) {
                
            },
            error: function (err) {
                alert(err.statusText + err.responseText);
            }
        });
    });
});