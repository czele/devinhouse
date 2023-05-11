internal class Program
{
    private static void Main(string[] args)
    {
        List<double> lista = new List<double>(){ 1.5, 2.7, 3.2, 5, 500, -5 };  
        var listaNova = ProcessList.Reverse(lista);

        foreach(var item in listaNova) {
            Console.WriteLine(item);
        }

    }
}