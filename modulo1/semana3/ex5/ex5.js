const somaTudo = (...num) => {
    let soma = 0;
    /*num.forEach(numero => {
        total += numero})*/
    for (i=0; i < num.length; i++){ 
        soma += num[i];}
    return soma
}

console.log(somaTudo(1, 2, 3, 4, 5))