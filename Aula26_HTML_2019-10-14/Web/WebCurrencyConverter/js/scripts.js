$(document).ready(
  function () {
    // $('input[name="valor1"]').maskMoney({
    //   showSymbol = false,
    //   symbol: "R$",
    // });
   
    //DataAtual para substituir na URL
    // var url = new URL('https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao=%2710-17-2019%27&$top=100&$format=json');
    // var query_string = url.search;
    // var search_params = new URLSearchParams(query_string);
    // var dataCorrente = new Date();
    // var dataAtual = (dataCorrente.getMonth()+1) + "/" + dataCorrente.getDay() + "/" + dataCorrente.getFullYear();
    // // new value of "id" is set to "101"
    // search_params.set('dataCotacao', dataAtual);
    // // change the search property of the main url
    // url.search = search_params.toString();
    // // the new url string
    // var new_url = url.toString();
    // console.log(new_url);

    
    $('input[name="valor1"]').mask('###.##0,00', {reverse: true});


    $.getJSON({
      url: "https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao=%2710-17-2019%27&$top=100&$format=json",
      success: function (result, status, xhr) {
        //debugger                          
        $('input[name=valor2]').val(parseFloat(result.value[0].cotacaoVenda).toFixed(2));
      }
    });

    $('button[id="calcular"]').click(function () {
      var valor1 = $('input[name="valor1"]').val()
      .replace(".", "")
      .replace(",", "");      
      var valor2 = $('input[name="valor2"]').val();
      var result = parseFloat(valor1) / parseFloat(valor2);
      result
      $('input[name="result"]').val(result.toFixed(2));
    });
  });