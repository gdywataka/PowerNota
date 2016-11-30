
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
                required: "Titulo é obrigatório ",
                maxlength: "Titulo pode ter no maximo 80 caracteres"
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
                    }

                },
            messages:
                {
                    email:
                        {
                            email: "O formato de email esta invalido <br> Formato: exemplo@email.com",
                            maxlength: "O maximo permitido é 80 caracteres"
                        },
                    login: {
                        maxlength: "O maximo permitido é 30 caracteres"
                    },
                    senha: {
                        maxlength: "O maximo permitido é 30 caracteres"
                    },
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
                    nome: { required: true, maxlength: 80 }

                },
            messages:
                {
                    nome: { required: "O campo é necessario", maxlength: "O maximo permitido é 80 caracteres" }

                }
        })
    }
})
