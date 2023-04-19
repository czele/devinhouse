//Tem que ser o nome do projeto para pegar as classes
using excarros;

List<Carro>carros = new List<Carro>();

Proprietario proprietario1 = new Proprietario(){
    nome="João",
    cpf=79240792031,
    telefone=986658961
};

Proprietario proprietario2 = new Proprietario(){
    nome="Maria",
    cpf=04742412036,
    telefone=979425013
};

Proprietario proprietario3 = new Proprietario(){
    nome="Camila",
    cpf=94420517093,
    telefone=980686455
};

Carro carro1 = new Carro(){
    marca="Volksvagen",
    modelo="Up!",
    placa="MUH8803",
    cor="vermelho",
    proprietario=proprietario1
};

Carro carro2 = new Carro(){
    marca="Honda",
    modelo="FIT",
    placa="HPY8945",
    cor="cinza",
    proprietario=proprietario2
};

Carro carro3 = new Carro(){
    marca="Chevrolet",
    modelo="Spin",
    placa="MND0561",
    cor="chumbo",
    proprietario=proprietario3
};

carros.Add(carro1);
carros.Add(carro2);
carros.Add(carro3);