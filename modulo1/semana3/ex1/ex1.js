var lista1 = [];
var elementolista = 1;

while (elementolista !== null) {
    elementolista = window.prompt('O que deseja adicionar na lista: ');
    if(elementolista && !isNaN(elementolista)) {
        lista.push(elementolista);
    }
}
//lista.pop()

console.log(lista)

var procuraMinMax = (lista) => {
    lista.sort();
    var max = lista[lista.length-1];
    var min = lista[0];
    console.log(`O valor máximo é ${max} e o mínimo é ${min}`)
}

if (lista.length == 0){
    console.log('Não é possível encontrar')
} else {
procuraMinMax(lista)}
