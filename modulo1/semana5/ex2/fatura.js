export default class Fatura {
    constructor (id, descricao, quantia, preco) {
    this.id = id;
    this.descricao = descricao;
    this.quantia = quantia;
    this.preco = preco;
    
    if(quantia < 0) {
        this.quantia = 0;
    }

    if(preco < 0) {
        this.preco = 0;
    }

    }

    obterValorTotal = () => {
        let fatura = this.quantia * this.preco;
        return fatura;
    }
}