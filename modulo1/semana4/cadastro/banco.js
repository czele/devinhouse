const pegarInputCadastro = document.getElementById('formcadastro');
pegarInputCadastro.onsubmit = (event) => {
    event.preventDefault();
    const pegarNome = event.target.nome.value;
    const pegarCpf = event.target.cpf.value;
    const pegarCelular = event.target.celular.value;
    const pegarSenhaCadastro = event.target.senhacadastro.value;
    const pegarConferirSenha = event.target.confsenha.value;
    const arrayCadastro = [pegarNome, pegarCpf, pegarCelular, pegarSenhaCadastro, pegarConferirSenha]

}

const pegarInputConta = document.getElementById('formconta');
pegarInputConta.onsubmit = (event) => {
    event.preventDefault();
    const pegarConta = event.target.conta.value;
    const pegarOperacao = event.target.operacao.value;
    const pegarValor = event.target.valor.value;
    const pegarSenhaConta = event.target.senhaconta.value;
    //console.log(pegarConta, pegarOperacao, pegarValor, pegarSenhaConta);
}



conferirDadosCadastro = () => {

}

saque = (conta, valor) => {
    if (valor <= 0 ) {
        console.log('Valor incorreto, por favor, digite novamente o valor')
    } else { 
        if(saldo < valor) {
            console.log('Valor insuficiente, seja mais rico, por favor.')
        } else {
            let saque = saldo - valor
            console.log(`Saque de ${valor} feito com sucesso.\n
            Seu saldo é de ${saque} reais.`)
        }
    }
}

deposito = (conta, valor) => {
    if (valor <= 0 ) {
        console.log('Valor incorreto, por favor, digite novamente o valor')
    } else {
    let deposito = saldo + valor;
    console.log(`Depósito de ${valor} feito com sucesso.\n
    Seu saldo é de ${deposito} reais.`)}
}

consulta = (conta) => {console.log(`Seu saldo é ${saldo}`)};


/*const para = document.createElement('p');
para.innerHTML = 'TESTE'
document.getElementById('formconta').appendChild(para)*/


