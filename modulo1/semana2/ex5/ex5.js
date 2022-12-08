var numeroden = window.prompt('Que número deseja verificar:');
parseInt(numeroden);
var contadorpar = 0; 
var contadorimpar = 0;

for (i=0; i<=numeroden; i++) {
    if(i%2==0) {
        contadorpar++;
    }
    else{
        contadorimpar++;
    } 
}
