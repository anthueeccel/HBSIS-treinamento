function enviar(){
    var nome = document.getElementById("nome").value;
    // alert("Olá " + nome);
}



$('#myModal').on('show.bs.modal', function(e) {
    var bookId = $(e.relatedTarget).data('nome');
    $(e.currentTarget).find('input[name="nome"]').val(bookId);
})