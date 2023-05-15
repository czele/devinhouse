internal class Program
{
    private static void Main(string[] args)
    {
        List<double> lista = new List<double>() {6, -8, 9.6, 7};
        double menor;
        double maior;

        for (int i = 0; i < lista.Count(); i++)
        {
            for (int j = i; j < lista.Count(); j++)
            {
                while(lista[i]> lista[j]){
                    menor = lista[j];
                    maior = lista[i];
                    lista[i] = menor;
                    lista[j] = maior;
                }
            }
        }


        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }

    }
}