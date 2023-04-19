using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace excarros
{
    public class Carro
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string placa { get; set; }
        public string cor{ get; set; }
        public Proprietario proprietario { get; set; }
    }
}