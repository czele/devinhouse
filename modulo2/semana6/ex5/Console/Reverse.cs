public class ProcessList {
   public static List<double> Reverse(List<double> lista) {
        
        List<double> listaNova = new List<double>();

        for(int i=lista.Count()-1; i >= 0; i--) {
            listaNova.Add(lista[i]);
        }
        
        return listaNova;
    }
    }