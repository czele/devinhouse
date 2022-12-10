var operacao = window.prompt('Que operação deseja realizar? (+, -, * ou / )')
var num1 = parseFloat(window.prompt('Qual o primeiro número para calcular:'))
var num2 = parseFloat(window.prompt('Qual o segundo número para calcular:'))

switch(operacao) {
    case '+':
        alert(num1 + num2);
        break;
    case '-':
        alert(num1 - num2);
        break;
    case '*':
        alert(num1 * num2);
        break;
    case '/':
        alert(num1 / num2);
        break;
    default:
        alert('Operação inválida');
}