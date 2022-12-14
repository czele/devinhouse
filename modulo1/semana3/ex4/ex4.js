var dadospessoais = {
    nome: 'Camila',
    sobrenome: 'Zelenovsky'
}

var caracteristicas = {
    sexo: 'feminino', 
    corcabelo: 'castanho',
}

const pessoa = (dadospessoais, caracteristicas) => {
    var conjunto = {...dadospessoais, ...caracteristicas}
    return conjunto
}

console.log(pessoa(dadospessoais, caracteristicas))