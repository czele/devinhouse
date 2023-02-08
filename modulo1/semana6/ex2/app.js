relogio = () => {
    const data = new Date();
    const horas = data.toLocaleTimeString()
    const relogio = document.createElement('p')
    relogio.innerText = horas;
    document.body.appendChild(relogio);
}

setTimeout(relogio, 1000);