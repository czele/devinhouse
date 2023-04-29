using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex8
{
    public class Gato : Animal
    {
        public override void EmitirSom()
        {
            System.Console.WriteLine("Miau");
        }
    }
}