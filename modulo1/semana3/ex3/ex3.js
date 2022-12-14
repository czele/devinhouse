var a = []; var b = [];
var elementolista1 = 1; var elementolista2 = 1;

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
}

const concatena = (lista1, lista2) => {
    var concatenacao = [...lista1, ...lista2];
    return concatenacao;
}

console.log(concatena(a, b));
