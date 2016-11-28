
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

$(function(){
    {
        $("#criarUsuario").validate
        ({
            rules:
                {
                    email:{required:true,email:true, maxlength:80},
                    login:{required:true,login:true, maxlength:30 },
                    senha:{required:true,senha:true, maxlength:30}

                },
            messages:
                {
                    email:{required:"O campo é necessario",email:"O formato de email esta invalido",maxlength:"O maximo permitido é 80 caracteres"},
                    login:{required:"O campo é necessario",email:"O formato de login esta invalido",maxlength:"O maximo permitido é 30 caracteres"},
                    senha:{required:"O campo é necessario",email:"O formato de senha esta invalido",maxlength:"O maximo permitido é 30 caracteres"},
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
    