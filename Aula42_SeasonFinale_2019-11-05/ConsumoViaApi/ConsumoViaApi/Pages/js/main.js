$(document).ready(function () {

    $('button[id="btnEnviar"]').click(function () {
       
        var login = $('input[id="login"]').val();
        var senha = $('input[id="senha"]').val();
        console.log(login, senha);
        var url = "http://localhost:49163/Api/Usuarios?";

        $.get(url + "login=" + login + "&senha=" + senha, function (data, status) {

            console.log(data);
            console.log(status);
        });
        


    });



});

