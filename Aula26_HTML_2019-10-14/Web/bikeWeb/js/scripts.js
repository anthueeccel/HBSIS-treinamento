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



        $('button[name="btnconfirmar"]').click(function () {
            
            $("#exampleModal").modal("toggle");
            $("body").toggleClass("bodyOnSave");               

            function runningLeft() {
                $("#run").animate({left: "-=300"}, 1500, "swing", runningRight);
            }
            
            var audio = new Audio('./media/f1-sound.mp3');
            audio.play();
            setTimeout(alteraBackgroundImg, 4000);
            LimparTela();


            function alteraBackgroundImg() {
                
                $("body").toggleClass("bodyOnSave");
            }       
            
            
        });


    });

    function LimparTela() {
        var meusInputs = $('input[type="text"]');
        meusInputs.val("");

        
    }

