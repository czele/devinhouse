/*let a = []; var b = [];
let elementolista1 = 1; let elementolista2 = 1;

while (elementolista1 !== null) {
    elementolista1 = window.prompt('O que deseja adicionar na 1ª lista: ');
    if(elementolista1 && !isNaN(elementolista1)) {
        lista1.push(elementolista1);
    }
}
while (elementolista2 !== null) {
    elementolista2 = window.prompt('O que deseja adicionar na 2ª lista: ');
    if(elementolista2 && !isNaN(elementolista2)) {
        lista2.push(elementolista2);
    }
}*/

const concatena = (lista1, lista2) => {return [...lista1, ...lista2]}

const novoArray = concatena([1, 2, 3], [4, 5, 6])

console.log(novoArray)
