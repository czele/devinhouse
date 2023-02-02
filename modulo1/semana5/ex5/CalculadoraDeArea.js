export default class CalculadoraDeArea {
    constructor (tipo, base, altura) {
        this.tipo = tipo;
        this.base = base;
        this.altura = altura
    }

    calcular() {
        if(this.tipo == "quadrado") {
            return this.base*this.altura
        }
        if(this.tipo == "triangulo") {
            return (this.base*this.altura)/2
        }
        else console.log("Forma inválida")
    }
}
