export default class Juros {
    constructor (capitalInicial, taxaAplicada, tempo) {
        this.capitalInicial = capitalInicial;
        this.taxaAplicada = taxaAplicada;
        this.tempo = tempo;
    }
    
    calcularJurosSimples (capitalInicial, taxaAplicada, tempo) {
        return Math.round(this.capitalInicial + (this.capitalInicial * (this.taxaAplicada/100) * this.tempo));
    }

    calcularJurosCompostos (capitalInicial, taxaAplicada, tempo) {
        return Math.round(this.capitalInicial * (1 + (this.taxaAplicada/100)) ** this.tempo);
    }
}