//Varivável para cadastrar lista de contas
let contas = [];

//Pegando formulário
const formulario = document.getElementById('formcadastro')

//Function para enviar o formulário
const enviarFormulario = (event) => {
    //Evita o funcionamento padrão do submit do EventListener
    event.preventDefault();

    //Validar senhas
    const senha = event.target.senhaCadastro.value;
    const confirmacaoSenha = event.target.confSenha.value;

    if(senha !== confirmacaoSenha) {
        window.alert("As senhas não conferem, favor conferir as senhas");
        //O return para a função caso a senha não confira
        return;
    };

    //Adicionar contas no Array   
    const nome = event.target.nome.value;
    const cpf = event.target.cpf.value;
    const celular = event.target.celular.value;
    const numConta = new Date().getTime();
    const saldo = 0;

    const contaCriada = {
        conta: numConta,
        nome,
        cpf,
        celular,
        senha,
        saldo
    };
    
    contas.push(contaCriada);

    const msgId = document.createElement('span');
    msgId.innerHTML = `Conta criada com sucesso. Seu número da conta é ${contaCriada.conta}`
    document.getElementById('formcadastro').appendChild(msgId) 
};

formulario.addEventListener('submit', enviarFormulario);
    
/*
const cadastros = [];
const transacoes = [];
let saldo = 100;
const valorOperacao = document.getElementById('valor');
const desabilitaValor = document.getElementById('operacao');


formulario.addEventListener('submit', (event) => {
    event.preventDefault();

    const cadastroFinal = {
        "nome": event.target.nome.value,
        "cpf": event.target.cpf.value,
        "celular": event.target.celular.value,
        "senha": event.target.senhacadastro.value,
        "confirmacaosenha": event.target.confsenha.value,
        "id": new Date().getTime(),
        "saldo": 0
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
    conta: parseInt(event.target.conta.value),
    operacao: parseInt(event.target.operacao.value),
    valor: parseInt(event.target.valor.value),
    senhaConta: event.target.senhaconta.value
    }
    transacoes.push(transacao)

   switch (transacao.operacao) {
        case '2':
            saque(1, transacao.valor);
            break;
        case '1':
            deposito(1, transacao.valor);
            break;
        case '0':
            consulta(1);
            break;
    }
    return transacoes
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
};*/
