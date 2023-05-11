internal class Program
{
    private static void Main(string[] args)
    {
        List<double> lista = new List<double>(){ 1.5, 2.7, 3.2, 5 };  
        List<double> listaNova = new List<double>();

        for(int i=lista.Count()-1; i >= 0; i--) {
            listaNova.Add(lista[i]);
        }
        
        foreach(var item in listaNova) {
            Console.WriteLine(item);
        }

    }
}