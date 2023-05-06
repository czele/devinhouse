
namespace semana5.Model
{
    public class Transacao
    {
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
    

        public Transacao() {}

        public Transacao(decimal valor)
        {
            Data = DateTime.Now;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"{Data} - {Valor.ToString("C2")}";
        }
    }

}