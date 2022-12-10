var quantidade = 0;
var listaprimos=[];

for (i=2; i<=1000; i++) {
    var primo = true;

    for(j=2; j < i; j++) {
        if (i % j === 0) {
            primo = false;
            break;
        }
    }

    if(primo) {
        listaprimos.push(i)
        quantidade +=1
    } 
}

console.log(listaprimos)
console.log(quantidade)