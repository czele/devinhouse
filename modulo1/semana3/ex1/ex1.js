/*var lista1 = [];
var elementolista = 1;

while (elementolista !== null) {
    elementolista = window.prompt('O que deseja adicionar na lista: ');
    if(elementolista && !isNaN(elementolista)) {
        lista.push(elementolista);
    }
}
//lista.pop()

console.log(lista)

const procuraMinMax = (lista) => {
    lista.sort();
    var max = lista[lista.length-1];
    var min = lista[0];
    console.log(`O valor máximo é ${max} e o mínimo é ${min}`)
}

if (lista.length == 0){
    console.log('Não é possível encontrar')
} else {
    procuraMinMax(lista)}*/

const procuraMinMax = (numeros) => {
    if (Array.isArray(numeros) && numeros.length > 0) {
        let maior = numeros[0];
        let menor = numeros[0];
    
        for (let i = 1; i < numeros.length; i++) {
            if (numeros[i] > maior) {
                maior = numeros[i];
            }
            if (numeros[i] < menor) {
                menor = numeros[i];
            }
            }
    
        console.log(`Maior: ${maior} | Menor: ${menor}`);
    } else {
        console.log("Não é possível encontrar");
    }
    }
    
    procuraMinMax([56, 65, 64, -3, 23, 42, -15, 65, 14, 32, 78, 70, 47]);
    procuraMinMax([]);
    procuraMinMax([1]);
    procuraMinMax([1, -1]);
    procuraMinMax(null);
    procuraMinMax([-2,-2,-2,-2]);
    procuraMinMax([20,10, 30]);
