// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    if ($("#Results").length != 0) {
        loadData()
    }

});

function saveUser() {
    let urlAPI = 'https://localhost:44304/api/user';
    let method = 'POST';
    let data = JSON.stringify({
        FirstName: $('#FirstName').val(),
        LastName: $('#LastName').val(),
        Email: $('#Email').val(),
        Password: $('#Password').val()
    });
    let contentType = 'application/json';

    $.ajax(
        {
            url: urlAPI,
            method: method,
            contentType: contentType,
            data: data
        })
        .done(result => alert(JSON.stringify(result)))
        .fail(failure => alert(JSON.stringify(failure)));
}