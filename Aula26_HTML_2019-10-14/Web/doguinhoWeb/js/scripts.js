$(document).ready(
    function () {

        //DataAtual para substituir na URL   
        // var dataCorrente = new Date();
        // var dataAtual = (dataCorrente.getMonth()+1) + "/" + dataCorrente.getDay() + "/" + dataCorrente.getFullYear();



        $('button[id="mostrarinfo"]').click(function () {
            $('input[name="nome"]').val("Nóia");
            $('input[name="idade"]').val(5);
            $('input[name="raca"]').val("Tomba");
            $('input[name="coloracao"]').val("Caramelo");
        });


        $('button[name=salvar]').click(function () {
            var dogname = $('input[name="nome"]').val();
            $('span[name="modalnome"]').text(dogname);
            var dogage = $('input[name="idade"]').val();
            $('span[name="modalidade"]').text(dogage);
            var dogbreet = $('input[name="raca"]').val();
            $('span[name="modalraca"]').text(dogbreet);
            var dogcolor = $('input[name="coloracao"]').val();
            $('span[name="modalcoloracao"]').text(dogcolor);
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