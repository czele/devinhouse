var soma = 0;

do {
    var num = parseFloat(window.prompt('Que números deseja somar?'));
    if (num === null) {
        break;
    } 

    if (isNaN(num) || num === -1) {
        continue;
    }
    
    soma += num
}
while(num !== -1) {
    window.alert(`Sua soma dá ${soma}`)
}