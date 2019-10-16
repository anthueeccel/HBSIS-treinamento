$(document).ready(
    function () {
        //$('input[name="valor1"]').mask("000.000.000,00");

        // var getJSON = function(url, callback) {
        //     var xhr = new XMLHttpRequest();
        //     xhr.open('GET', url, true);
        //     xhr.responseType = 'json';
        //     xhr.onload = function() {
        //       var status = xhr.status;
        //       if (status === 200) {
        //         callback(null, xhr.response);
        //       } else {
        //         callback(status, xhr.response);
        //       }
        //     };
        //     xhr.send();
        // };

        $.getJSON("https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao=%2710-16-2019%27&$top=100&$format=json",
           function(data) {
               if (err !== null) {
                 alert('Erro: ' + err);
               } else {
                 alert('JSON: ' + valor);
               }
             });
             console.log(data);


        $('input[name=valor2]').val(data);

        $('button[id="calcular"]').click(function () {
            var valor1 = $('input[name="valor1"]').val();
            var valor2 = $('input[name="valor2"]').val();
            var result =  parseFloat(valor1) * parseFloat(valor2);
            //alert(result);
            $('input[name="result"]').val(result);
            

        })
    });