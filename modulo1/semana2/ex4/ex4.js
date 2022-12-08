var num = 0
var soma = 0

while(num != -1) {
    num = parseInt(window.prompt('Que números deseja somar?'))
    soma += num
    window.alert(`${soma}`)
}