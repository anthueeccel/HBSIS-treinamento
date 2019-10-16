$(document).ready(
    function() {
        atualizaData();

});

function atualizaData() {
    setInterval(function(){
        $('span[name="data_atual"]').text(Date());
    },100);
}