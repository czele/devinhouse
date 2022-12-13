const mensagemOla = (nome) => {return `Helo ${nome}`}

const btn = document.querySelector("send");
btn.addEventListener("click", function(e) {
    e.preventDefault();
    const nome = document.querySelector("#nome");
    var value = nome.value;
})

console.log(mensagemOla(this.value))
