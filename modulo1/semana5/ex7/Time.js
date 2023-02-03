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
            if(pt.golsTimeA > pt.golsTimeB) {
                this.vit++;
            }
            if(pt.golsTimeA = pt.golsTimeB) {
                this.emp++;
            }
            if(pt.golsTimeA < pt.golsTimeB) {
                this.der++;
            }
        }
        if(pt.siglaTimeB === this.sigla) {
            this.golmarc += pt.golsTimeB;
            this.golsof += pt.golsTimeA;
            if(pt.golsTimeB > pt.golsTimeA) {
                this.vit++;
            }
            if(pt.golsTimeB = pt.golsTimeA) {
                this.emp++;
            }
            if(pt.golsTimeB < pt.golsTimeA) {
                this.der++;
            }
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