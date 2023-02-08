const promise1 = new Promise((success, reject) => {
    setTimeout(() => {
        const emprestimo = Math.random() < 0.5;
        emprestimo
            ? success("Empréstimo disponível")
            : reject("Empréstimo não disponível");
    }, 3000);
});
const promise2 = new Promise((success, reject) => {
    setTimeout(() => {
        const creditoDisponivel = Math.random() < 0.5;
        creditoDisponivel
            ? success("Crédito disponível")
            : reject("Crédito não disponível");
    }, 5000);
});
Promise.allSettled([promise1, promise2]).then((result) => {
    new Promise((resolve, reject) => {
        setTimeout(() => {
            resolve(
                `Cadastro efetuado com sucesso ${result[0].status === "fulfilled" ? result[0].value : result[0].reason
                } ${result[1].status === "fulfilled" ? result[1].value : result[1].reason
                }`
            );
        }, 4000);
    }).then((resultado) => {
        console.log(resultado);
    });
});