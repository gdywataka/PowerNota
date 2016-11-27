
function mostrarModal() {
    $('#modal').modal({
        backdrop: 'static',
        keyboard: false
    })
}

function mostraModalLogin() {
    $("#modalLogin").modal()
}

$(function () {
    $('#modal').on('modal.hide', function () {
        $('#modal').modal('show')
    })
})