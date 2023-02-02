import Usuario from "./Usuario.js"

const usuarioCadastrado = new Usuario("1","2","3") 

const formulario = document.getElementById('formcadastro')

const enviarFormulario = (event) => {
    event.preventDefault();

    const emailInformado = event.target.emailInformado.value;
    const senhaInformada = event.target.senhaInformada.value;

    if (emailInformado == usuarioCadastrado.email && senhaInformada == usuarioCadastrado.senha) {
        console.log("Usuário cadastrado")
    } else {
        console.log("Usuário não cadastrado")
    }
}

formulario.addEventListener('submit', enviarFormulario)

usuarioCadastrado.autenticar();