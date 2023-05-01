using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex9
{
    public static class Calculadora
    {
        public static float NumA { get; set; }
        public static float NumB { get; set; }
        public static float Raio { get; set; }
        public const double Pi = 3.14159265359;

        public static void Soma(float NumA, float NumB) {
            Console.WriteLine($"Soma: {NumA + NumB}");
        }

        public static void Subtracao(float NumA, float NumB) {
            Console.WriteLine($"Subtração: {NumA - NumB}");
        }

         public static void Multiplicacao(float NumA, float NumB) {
            Console.WriteLine($"Multiplicação: {NumA * NumB}");
        }

         public static void Divisao(float NumA, float NumB) {
            Console.WriteLine($"Divisão: {NumA / NumB}");
        }

        public static void AreaCirculo(float Raio) {
            System.Console.WriteLine($"Área do círculo: {Pi * Raio * Raio}");
        }

    }
}