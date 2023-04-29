using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex8
{
    public abstract class Animal
    {
        public String nome { get; set; }   
        public int idade { get; set; }   

        public abstract void EmitirSom();
    }
}