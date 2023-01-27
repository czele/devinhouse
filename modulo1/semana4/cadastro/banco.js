const cadastros = [];
const transacoes = [];
let saldo = 100;
const valorOperacao = document.getElementById('valor');
const desabilitaValor = document.getElementById('operacao');

const pegarInputCadastro = document.getElementById('formcadastro')
pegarInputCadastro.addEventListener('submit', (event) => {
    event.preventDefault();

    const cadastroFinal = {
        "nome": event.target.nome.value,
        "cpf": event.target.cpf.value,
        "celular": event.target.celular.value,
        "senha": event.target.senhacadastro.value,
        "confirmacaosenha": event.target.confsenha.value,
        "id": new Date().getTime()
    }
       if (cadastroFinal.senha !== cadastroFinal.confirmacaosenha) {
            window.alert("As senhas não conferem, favor conferir as senhas")
        } else {
            cadastros.push(cadastroFinal) 
            const msgId = document.createElement('p');
            msgId.innerHTML = `Conta criada com sucesso. Seu número da conta é ${cadastroFinal.id}`
            document.getElementById('formcadastro').appendChild(msgId) 
    }

});


const pegarInputConta = document.getElementById('formconta');
pegarInputConta.addEventListener('submit', (event) => {
    event.preventDefault();

    const transacao = {
    saldo: 0,
    conta: event.target.conta.value,
    operacao: event.target.operacao.value,
    valor: event.target.valor.value,
    senhaConta: event.target.senhaconta.value
    }
    transacoes.push(transacao)

   switch (transacao.operacao) {
        case '2':
            saque(transacoes.conta, transacoes.valor);
            break;
        case '1':
            deposito(transacoes.conta, transacoes.valor);
            break;
        case '0':
            consulta(transacao.conta);
            break;
    }
});


desabilitaValor.onchange = (event) => {
    if (desabilitaValor.value == 0) {
        valorOperacao.disabled = true;
    }
    else {
        valorOperacao.disabled = false;
    }
}

const saque = (conta, valor) => {
    if (valor <= 0 ) {
        const msgSaqueInsuficiente1 = document.createElement('p');
        msgSaqueInsuficiente1.innerHTML = 'Valor incorreto, por favor, digite novamente o valor'
        document.getElementById('formconta').appendChild(msgSaqueInsuficiente1)
    } else { 
        if(saldo < valor) {
            const msgSaqueInsuficiente2 = document.createElement('p');
        msgSaqueInsuficiente2.innerHTML = 'Valor incorreto, por favor, digite novamente o valor'
        document.getElementById('formconta').appendChild(msgSaqueInsuficiente2)
        } else {
            let saque = saldo - valor
            console.log(`Saque de ${valor} feito com sucesso.\n
            Seu saldo é de ${saque} reais.`)
        }
    }
}

deposito = (conta, valor) => {
    if (valor <= 0 ) {
        const msgDepositoInsuficiente = document.createElement('p');
        msgDepositoInsuficiente.innerHTML = 'Valor incorreto, por favor, digite novamente o valor'
        document.getElementById('formconta').appendChild(msgDepositoInsuficiente)
    } else {
    let deposito = transacoes.saldo + valor;
    const msgDeposito = document.createElement('p');
    msgDeposito.innerHTML = `Depósito de ${valor} feito com sucesso.\n
    Seu saldo é de ${deposito} reais.`
    document.getElementById('formconta').appendChild(msgDeposito)
}}

consulta = (conta) => {
    let saldo = transacoes.saldo;
    const msgConsulta = document.createElement('p');
    msgConsulta.innerHTML = `Seu saldo é ${saldo}`
    document.getElementById('formconta').appendChild(msgConsulta)
};
