const numero = document.getElementById("numero");
const botao = document.getElementById("botao");

criarSpan = (res) => {
  const span = document.createElement("p");
      span.innerText = res;
      document.body.appendChild(span);
}

const enviarFormulario = (event) => {
  new Promise((resolve, reject) => {
    if (numero.value % 2 === 0) {
      setTimeout(() => {
        resolve("é par");
      }, 1000);
    } else {
      setTimeout(() => {
        reject("é ímpar");
      }, 1000);
    }
  })
    .then((res) => {
      criarSpan(res)
    })
    .catch((res) => {
      criarSpan(res)
    })
    .finally(() => {
      criarSpan("Finalizado")
    });
};

botao.addEventListener("click", enviarFormulario);
