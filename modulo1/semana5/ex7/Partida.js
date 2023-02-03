export default class Partida {
    constructor (siglaTimeA, golsTimeA, siglaTimeB, golsTimeB) {
        this.siglaTimeA = siglaTimeA;
        this.golsTimeA = golsTimeA;
        this.siglaTimeB = siglaTimeB;
        this.golsTimeB = golsTimeB;

        return {
            siglaTimeA: this.siglaTimeA, 
            golsTimeA: this.golsTimeA,
            siglaTimeB: this.siglaTimeB,
            golsTimeB: this.golsTimeB
        }
    }

}