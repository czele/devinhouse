//Tem que ser o nome do projeto para pegar as classes
using excarros;

List<Carro> carros = new List<Carro>();

Proprietario proprietario1 = new Proprietario("João", "79240792031", "986658961")/*{
    nome="João",
    cpf=79240792031,
    telefone=986658961
}*/;

Proprietario proprietario2 = new Proprietario("Maria", "04742412036", "979425013");

Proprietario proprietario3 = new Proprietario("Camila", "94420517093", "980686455");

Carro carro1 = new Carro("Volksvagen", "Up!", "MUH8803", "vermelho", proprietario1);

    void cadastraCarros(){

            Console.Write("Marca:");
            string marca = Console.ReadLine();

            Console.Write("Modelo:");
            string modelo = Console.ReadLine();

            Console.Write("Placa:");
            string placa = Console.ReadLine();

            Console.Write("Cor:");
            string cor = Console.ReadLine();

            Console.Write("Nome:");
            string nome = Console.ReadLine();

            Console.Write("CPF:");
            string cpf = Console.ReadLine();

            Console.Write("Telefone:");
            string telefone = Console.ReadLine();


        Proprietario proprietario4 = new Proprietario(nome, cpf, telefone);
        Carro carro4 = new Carro(marca, modelo, placa, cor, proprietario4);

        carros.Add(carro4);
    };

carros.Add(carro1);
carros.Add(new Carro("Honda", "FIT", "HPY8945", "cinza", proprietario2));
carros.Add(new Carro("Chevrolet", "Spin", "MND0561", "chumbo", proprietario3));

cadastraCarros();

foreach(var carro in carros)
    {
        Console.WriteLine(carro.Imprimir());
    };


//Exemplos de Funções anônimas
/*bool EhMaiorQueZero(double num){
  return num > 0;
}

Func<double, bool> EhMaiorQueZero = num => num > 0;

double Multiplica(int num1 , double num2){
  return num1 * num2;
}

Func<int, double, double> Multiplica = (num1, num2) => num1 * num2;

int Soma(int num1, int num2, int num3){
  return num1 + num2 + num3;
}

Func<int, int, int, int> Soma = (num1, num2, num3) => num1 + num2 + num3;*/

