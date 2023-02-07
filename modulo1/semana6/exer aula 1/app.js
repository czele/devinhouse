const numero = document.getElementById("numero");
const botao = document.getElementById("botao");

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
      const span = document.createElement("p");
      span.innerText = res;
      document.body.appendChild(span);
    })
    .catch((res) => {
      const span = document.createElement("p");
      span.innerText = res;
      document.body.appendChild(span);
    })
    .finally(() => {
      const span = document.createElement("p");
      span.innerText = "Finalizado";
      document.body.appendChild(span);
    });
};

botao.addEventListener("click", enviarFormulario);
