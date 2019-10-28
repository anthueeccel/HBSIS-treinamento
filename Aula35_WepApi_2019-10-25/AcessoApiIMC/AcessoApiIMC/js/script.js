var url = "http://localhost:60396/Api/Imc";

// método GET
$(document).ready(function () {
    $('input[name="botaoEnviar"]').click(function () {
        
        var informacoes = $('form[name=formEnviar]').serialize();

        $.get(url +"?" + informacoes, function (data) {

            data = data.split(":")[3];

            $('input[name="meuimc"]').val(data);

        });


    });
});



//método POST
$(function () {
    $(document).on('click', '#botaoEnviarPost', function () {
        var formData = $('#formEnviar').serializeArray();
        //rs = formObj2Json(formData);       

        $.post(url, formData, function (data) {

            data = data.split(":")[3];
            $('input[name="meuimc"]').val(data);

        });

        //$('#rs').html(JSON.stringify(rs, undefined, 2));
    });


})


function formObj2Json(formArray) { //serialize data function
    var returnArray = {};
    for (var i = 0, len = formArray.length; i < len; i++)
        returnArray[formArray[i].name] = formArray[i].value;
    return returnArray;
}

