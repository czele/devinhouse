internal class Program
{
    private static void Main(string[] args)
    {
        double[] valores = new double[] {6, -8, 9.6, 7};
        List<double> listaOrdenada = new List<double>();

        for (int i = valores.Count() - 1; i >= 0; i--)
        {
            listaOrdenada.Add(valores[i]);            
        }

        foreach (var item in listaOrdenada)
        {
            Console.WriteLine(item);    
        }
        
    }
}