using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace excarros
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor{ get; set; }
        public Proprietario Proprietario { get; set; }

        public Carro(string marca, string modelo, string placa, string cor, Proprietario proprietario)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Cor = cor;
            Proprietario = proprietario;
        }

        public string Imprimir() {
            return $"Marca: {Marca}  Modelo: {Modelo}  Placa: {Placa}  Cor: {Cor}  Proprietário: {Proprietario.Imprimir()}" ;           
        }

    }
}