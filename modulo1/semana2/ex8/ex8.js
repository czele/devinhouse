var numinicial = parseInt(window.prompt('Com que número deseja iniciar a PA:'));
var raiz = parseInt(window.prompt('Qual será a raiz da PA:'));
var listapa = [];

for (i=0; i < 10; i++) {
    listapa.push(numinicial += raiz)
}
window.alert(`${listapa}`);