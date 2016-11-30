
function mostrarModal() {
    $('#modal').modal({
        backdrop: 'static',
        keyboard: false
    })
}

function modalSucessoAccount(nome) {
    $('#modalContaCriada').modal()
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
            titulo: {
                required: true,
                maxlength: 80
            }
        },
        messages: {
            titulo: {
                required: "Titulo é obrigatório "
            }
        }
    })
})

$(function () {
    {
        $("#criarUsuario").validate
        ({
            rules:
                {
                    email: {
                        required: true,
                        email: true,
                        maxlength: 80
                    },
                    login: {
                        required: true,
                        maxlength: 30
                    },
                    senha: {
                        required: true,
                        maxlength: 30
                    },
                    mesma_senha: {
                        equalTo: "#senha"
                    }
                },
            messages:
                {
                    email:
                        {
                            email: "O formato de email esta inválido <br> Formato: exemplo@email.com"
                        }
                }
        })
    }
})
$(function () {
    {
        $("#criarTopico").validate
        ({
            rules:
                {
                    nome: {
                        required: true,
                        maxlength: 80
                    }

                }
        })
    }
})
