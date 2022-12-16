const entradaNome = document.getElementById('nome')
const botaoAcao = document.getElementById('acao')
const pMensagem = document.getElementById('mensagem')

const mensagemOla = nome => `Olá, ${nome}`

console.log(mensagemOla())

botaoAcao.addEventListener('click', () => {
    pMensagem.innerHTML = mensagemOla(entradaNome.value);
    /*const nome = entradaNome.value;
    const msg = mensagemOla(nome);
    console.log(msg);
    pMensagem.innerHTML = msg*/
})
