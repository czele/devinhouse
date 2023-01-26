var saldo = 10;
let conta = 1;
/*let valor = 

saque = (conta, valor) => {

}*/

deposito = (conta, valor) => {
    if (valor <= 0 ) {
        console.log('Valor incorreto, por favor, digite novamente o valor')
    } else {
    let deposito = saldo + valor;
    console.log(`Depósito de ${valor} feito com sucesso.\n
    Seu saldo é de ${deposito} reais.`)}
}

//consulta = (conta) => {console.log(`Seu saldo é ${saldo}`)};

deposito(3, 5)