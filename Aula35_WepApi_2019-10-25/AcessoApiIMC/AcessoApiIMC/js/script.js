$(document).ready(function () {
    $('input[name="botaoEnviar"]').click(function () {

        var informacoes = $('form[name=formEnviar]').serialize();

        $.get("http://localhost:60396/Api/Imc?" + informacoes, function (data) {
            
             $('input[name="meuimc"]'.val(data));

           
        });


    });
});