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
            else if(pt.golsTimeA == pt.golsTimeB) {
                this.emp++;
            }
            else if(pt.golsTimeA < pt.golsTimeB) {
                this.der++;
            }
        }
        if(pt.siglaTimeB === this.sigla) {
            this.golmarc += pt.golsTimeB;
            this.golsof += pt.golsTimeA;
            if(pt.golsTimeB > pt.golsTimeA) {
                this.vit++;
            }
            else if(pt.golsTimeB == pt.golsTimeA) {
                this.emp++;
            }
            else if(pt.golsTimeB < pt.golsTimeA) {
                this.der++;
            }
        }

    }

    /*computarPartida(partida){
        if(partida.siglaTimeA == this.sigla){
            this.golsMarcados += partida.golsTimeA;
            this.golsSofridos += partida.golsTimeB;
            const saldo = partida.golsTimeA - partida.golsTimeB;
            
            switch (Math.sign(saldo)) {
                case 1:
                    // console.log("Vitória");
                    this.vitorias++
                    break;
                case 0:
                    // console.log("Empate");
                    this.empates++
                    break
                case -1:
                    // console.log("Derrota");
                    this.derrotas++
                default:
                    break;
            }
        }
        if(partida.siglaTimeB == this.sigla){
            this.golsMarcados += partida.golsTimeB;
            this.golsSofridos += partida.golsTimeA;
            const saldo = partida.golsTimeB - partida.golsTimeA;
            
            switch (Math.sign(saldo)) {
                case 1:
                    // console.log("Vitória");
                    this.vitorias++
                    break;
                case 0:
                    // console.log("Empate");
                    this.empates++
                    break
                case -1:
                    // console.log("Derrota");
                    this.derrotas++
                default:
                    break;
            }
        }
    }*/

    exibirSituacao() {
        console.log ("\n\nNome:", this.nome);
        console.log ("Sigla:", this.sigla);
        console.log ("Vitorias:", this.vitorias);
        console.log ("Derrotas:", this.derrotas);
        console.log ("Empates:", this.empates);
        console.log ("Gols marcados:",this.golsMarcados);
        console.log ("Gols sofridos:",this.golsSofridos);  
    }
}