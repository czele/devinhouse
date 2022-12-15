const pessoa = {
    nome: 'Ada',
    idade: 36,
    profissao: 'matemática'
  };

desestruturando = ({ nome, idade, profissao}) => console.log(`Esta é ${nome}, tem ${idade} anos e é ${profissao}.`)

desestruturando(pessoa)