// carrega as funções após carregar a página.
$(document).ready(function () {
    $('button[name=btnboasvindas]').click(function () {
        var nomeusuario = $('input[name="nome"]').val();
        $('span[name="usuariotext"]').text(nomeusuario);
    });
});


//Evento ON não é carregado na leitura, somente no evento, quando o evento é chamado.
// $('button[name=btnboasvindas]').on("click", function () {
//     $('button[name=btnboasvindas]').click(function () {
//         var nomeusuario = $('input[name="nome"]').val();
//         $('span[name="usuariotext"]').text(nomeusuario);
//     });
// });


//habilita o ENTER para executar o evento.
$(document).on('keypress', function (e) {
    if (e.which == 13) {        
        $('button[name="btnboasvindas"]').click();
    }
});

