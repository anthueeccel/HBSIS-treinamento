
$(document).ready(    
    function(){
        
        $('input[name="cep"]').mask('00000-000');
        $('input[name="mostrar"]').prop('disabled', true);
        
    });



    $('input[name="cep"]').on("blur", function() {
        var cepInput = $('input[name="cep"]').val();        
        
        if(cepInput.length < 9) {
            $('input[name="mostrar"]').prop('disabled', true);
            alert("CEP inválido (8 caracteres)");
        }
        else {
            $('input[name="mostrar"]').prop('disabled', false);

            $('input[type="button"]').on("click",
            function() {
                
                
                //ValidarCEP(cepInput);
                
                $.get("https://viacep.com.br/ws/"+ cepInput +"/json/", function(data,status){
                    console.log(data);
                    console.log(status);
                    if(data.erro == true){
                        alert('CEP inválido, tente novamente')
                    }
                    else{
                        $('input[name="cidade"]').val(data.localidade);
                        $('input[name="bairro"]').val(data.bairro);
                        $('input[name="logradouro"]').val(data.logradouro);
                        $('input[name="complemento"]').val(data.complemento);
                        $('input[name="ibge"]').val(data.ibge);
                        $('input[name="uf"]').val(data.uf);
                    }
                    
                    //alert("Data: " + data.cep + "\r\nLogradouro: " + data.logradouro + "\r\nLocalidade:" + data.localidade  +"\r\n Status: " + status);
                });
            }
            );
                
        }
    });
     