$(document).ready(
    function () {

        //DataAtual para substituir na URL   
        // var dataCorrente = new Date();
        // var dataAtual = (dataCorrente.getMonth()+1) + "/" + dataCorrente.getDay() + "/" + dataCorrente.getFullYear();



        $('button[id="mostrarinfo"]').click(function () {
            $('input[name="marca"]').val("Trek");
            $('input[name="valor"]').val(1230);
            $('input[name="peso"]').val(2.5);
        });


        $('button[name=salvar]').click(function () {
            var bbrand = $('input[name="marca"]').val();
            $('span[name="modalmarca"]').text(bbrand);
            var bprice = $('input[name="valor"]').val();
            $('span[name="modalvalor"]').text(bprice);
            var bweight = $('input[name="peso"]').val();
            $('span[name="modalpeso"]').text(bweight);
        });

        $(document).on('keypress', function (e) {
            if (e.which == 13) {        
                $('button[name="salvar"]').click();
            }
        });        

        // $('button[id="salvar"]').click(function () {
        //     $('input[name="nome"]').val();
        //     $('input[name="idade"]').val();
        //     $('input[name="raca"]').val();
        //     $('input[name="coloracao"]').val();
        // });





    });