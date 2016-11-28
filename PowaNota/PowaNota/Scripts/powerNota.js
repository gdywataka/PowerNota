
function mostrarModal() {
    $('#modal').modal({
        backdrop: 'static',
        keyboard: false
    })
}

function mostraModalLogin() {
    $("#modalLogin").modal()
}

function mostrarModalCriarNota() {
    $('#modalSuccess').modal()
}

$(function () {
    $('#criarNota').validate({
        rules: {
            titulo:{
                required: true,
                maxlength:80
            }
        },
        messages: {
            titulo: {
                required: "Titulo é obrigatório ",
                maxlength: "Titulo pode ter no maximo 80 caracteres"
            }
        }
    })
})