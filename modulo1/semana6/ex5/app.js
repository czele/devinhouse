function obterClienteNoBancoDeDados(idCliente) {
    return new Promise( (resolve, reject) => {
            const cliente = { nome: 'bruce wayne', id: idCliente };
            resolve(cliente);
    });
}

//async function processar() {
const processar = async () => {
    obterClienteNoBancoDeDados(7)
        .then(cliente => console.log(cliente));
}

processar();