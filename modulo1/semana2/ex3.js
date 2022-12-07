var numero = window.prompt('Que número deseja fazer a tabuada?');
parseInt(numero);

for (i = 1; i <= 10; i++) {
    window.alert(
        `A tabuada de ${numero} é: \n
        ${numero} x ${i}= ${i*numero}\n`)
}