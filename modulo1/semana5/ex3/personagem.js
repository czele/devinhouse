export default class Personagem {
    constructor(nome, percentualVida) {
        this.nome = nome;
        this.percentualVida = 100;
    }

    sofreuDano (percentualDano) {
        this.percentualVida -= percentualDano
        if (this.percentualVida <= 0) {
            this.percentualVida = 0
        }
        return this.percentualVida;
    }

    usouKitMedico() {
        this.percentualVida += 10;
        if (this.percentualVida > 100){
            this.percentualVida = 100
        }
        return this.percentualVida;
    }
}