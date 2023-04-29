using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex6
{
    public class Retangulo
    {
        private double altura;
        private double largura;

        public Retangulo() { }

        public Retangulo(double altura, double largura)
        {
            this.altura = altura;
            this.largura = largura;
        }

        public double Altura {
            get { return altura; }
            set { value = altura; }    
        }

        public double Largura {
            get { return largura; }
            set { value = largura; }    
        }

        public void CalcularArea() {
            if(altura > 0 && largura > 0) {
                System.Console.WriteLine(altura * largura);
            } else {
                System.Console.WriteLine("Valores inválidos");
            }
        }
    }
}