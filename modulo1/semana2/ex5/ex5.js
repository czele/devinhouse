var numero = parseInt(window.prompt('Que número deseja verificar:'));

if (isNaN(numero)) {
    window.alert('Número inválido');
}
else {
    var pares = 0;
    var impares = 0;
    for (i=0; i <= numeros; i++) {
        if (i % 2 === 0){
            pares += 1;
        }
        else {
            impares += 1;
        }
    }
    window.alert(`Existem ${pares} números pares e ${impares} números ímpares`)
}