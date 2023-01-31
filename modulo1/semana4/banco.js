//Varivável para cadastrar lista de contas
let contas = [
    {
        nome: 'Thais Bertoldo', 
        cpf: '999.999.999.99', 
        celular: '(99) 99999-9999', 
        senha: '1', 
        conta: 1, 
        saldo: 100,
    },
];

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

//Obter formulário de operações
const formOperacao = document.getElementById('formconta');

const sacar = (conta, valor) => {
    //Verifica se o valor é maior que 0
    if(valor > 0) {
        //Verifica se tem saldo disponível
        //Saque realizado
        if(conta.saldo >= valor) {
            const novoSaldo = conta.saldo - valor
            conta.saldo = novoSaldo;

            const msgDepositoSucesso = document.createElement('span');
            msgDepositoSucesso.innerHTML = `Saque de ${valor} reais feito com sucesso. Seu saldo agora é de ${novoSaldo} reais`;
            document.getElementById('formconta').appendChild(msgDepositoSucesso);
            return;
    }
    //Saldo insuficiente
    } else {
        const msgSaldoInsuficiente = document.createElement('span');
        msgSaldoInsuficiente.innerHTML = 'Saldo insuficiente.';
        document.getElementById('formconta').appendChild(msgSaldoInsuficiente);
        return;
    }

    const msgSaldoInsuficiente = document.createElement('span');
    msgSaldoInsuficiente.innerHTML = 'Saldo insuficiente.';
    document.getElementById('formconta').appendChild(msgSaldoInsuficiente);
};

const depositar = (conta, valor) => {
    if(valor > 0) {
        const novoSaldo = conta.saldo + valor
        conta.saldo = novoSaldo;

        const msgDepositoSucesso = document.createElement('span');
        msgDepositoSucesso.innerHTML = `Depósito de ${valor} reais feito com sucesso. Seu saldo agora é de ${novoSaldo} reais`;
        document.getElementById('formconta').appendChild(msgDepositoSucesso);
        return;
    } else {
    const msgDepositoInsuficiente = document.createElement('span');
    msgDepositoInsuficiente.innerHTML = 'Valor incorreto, por favor, digite novamente o valor';
    document.getElementById('formconta').appendChild(msgDepositoInsuficiente);
    }
};

const consultarSaldo = (conta) => {
    const msgSaldo = document.createElement('span');
    msgSaldo.innerHTML = `Seu saldo é ${conta.saldo}`;
    document.getElementById('formconta').appendChild(msgSaldo);
};


//Enviar formulário de operação
const enviarFormularioOperacao = (event) => {
    event.preventDefault();

    //Obter valores digitados no formulário
    const conta = parseInt(event.target.conta.value);
    const operacao = event.target.operacao.value;
    const valor = parseFloat(event.target.valor.value);
    const senha = event.target.senhaConta.value;

    //Validar conta e senha
    const contaAtual = contas.find((c) => c.conta === conta)

    //Valida se a conta existe
    if(!contaAtual) {
        window.alert('Conta inválida');
        return;
    }

    if(contaAtual.senha !== senha){
    window.alert('Senha incorreta');
    return;
    }

    //Chamar a função correta
    switch (operacao) {
        case '0':
            consultarSaldo(contaAtual);
            break;
        case '1':
            depositar(contaAtual, valor);
            break;
        case '2':
            sacar(contaAtual, valor);
            break;
        default:
            window.alert('Operação inválida');
            break;
    }
};

formOperacao.addEventListener('submit', enviarFormularioOperacao);

//Desabilitar campo de valor no saque
const operacao = document.getElementById('operacao');
operacao.addEventListener('change', (event) => {
    const valorOperacao = document.getElementById('valor');

    if(event.target.value === '0') {  
    valorOperacao.disabled = true;
    valorOperacao.value = '';
    return;
    }
    else {
    valorOperacao.disabled = false;
    };
});