var numeroden = parseInt(window.prompt('Que número deseja verificar:'));
parseInt(numeroden);
var contadorpar = 0; var somapar = 0;
var contadorimpar = 0; var somaimpar = 0;

for (i=0; i<=numeroden; i++) {
    if(i%2==0) {
        contadorpar++;
        somapar += contadorpar;
        window.alert(`A quantidade de números pares é: ${contadorpar}`)
    }
    else{
        contadorimpar++;
        somaimpar += contadorimpar;
        window.alert(`A quantidade de números ímpares é: ${contadorimpar}`)
    } 
}
