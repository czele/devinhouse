export default class Time {
    constructor (nome, sigla, vit, der, emp, golmarc, golsof) {
        this.nome = nome;
        this.sigla = sigla;
        this.vit = vit;
        this.der = der;
        this.emp = emp;
        this.golmarc = golmarc;
        this.golsof = golsof;
    }

    get numeroDeJogos () {
        return this.vit + this.der + this.emp;
    }

    get numeroDePontos () {
        return (this.vit * 3) + (this.emp + 1);
    }

    computarPartida (pt) {
        if(pt.siglaTimeA === this.sigla) {
            this.golmarc += pt.golsTimeA;
            this.golsof += pt.golsTimeB;
        }

    }

    exibirSituacao() {
        return {
        nome: this.nome,
        sigla: this.sigla,
        vitória: this.vit,
        derrota: this.der,
        empate: this.emp,
        golsMarcados: this.golmarc,
        golsSofridos: this.golsof
        }   
    }
}