import Juros from "./Juros.js";

const testeSimples = new Juros(10000, 7, 24);
console.log(testeSimples.calcularJurosSimples());
const testeComposto = new Juros(10000, 15, 10);
console.log(testeComposto.calcularJurosCompostos());