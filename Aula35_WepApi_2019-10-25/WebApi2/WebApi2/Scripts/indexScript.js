$(document).ready(function () {
    $('a["#botaoEnviar"]').on('click', function () {

        var informacoes = $('form[name=formEnviar]').serializeArray();

        $.post("http://http://localhost:60396/Api/Imc?" + informacoes);
        dete = JSON.parse(data);

        $.each(data.cServico, function (key, valeu) {

            altert($('p[name="{key}"]'.replace("{key}", key)).text(value));

        });
    });
});

