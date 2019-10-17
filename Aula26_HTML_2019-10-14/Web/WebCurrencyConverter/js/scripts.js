$(document).ready(
  function () {
    $('input[name="valor1"]').mask("000.000,00");


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
      .replace(",", "")
      .toFixed(2);
      var valor2 = $('input[name="valor2"]').val();
      var result = parseFloat(valor1) / parseFloat(valor2);
      $('input[name="result"]').val(result.toFixed(2));
    })
  });