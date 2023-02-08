relogio = () => {
    const data = new Date();
    const horas = data.toLocaleTimeString()
    const relogio = document.getElementById('aqui')
    relogio.innerText = horas;
}

setInterval(relogio, 1000);
