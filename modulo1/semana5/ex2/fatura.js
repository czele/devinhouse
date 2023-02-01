export default class Fatura {
    id
    descricao
    quantia
    preco

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
        return this.quantia * this.preco;
    }

    get valorTotal() {
        return this.quantia * this.preco;
        //return this.valorTotal()
    }
}