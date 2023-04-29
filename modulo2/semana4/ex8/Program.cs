using ex8;

internal partial class Program
{
    private static void Main(string[] args)
    {
        Cachorro cachorro = new Cachorro();
        cachorro.EmitirSom();

        Gato gato = new Gato();
        gato.EmitirSom();
    }
}