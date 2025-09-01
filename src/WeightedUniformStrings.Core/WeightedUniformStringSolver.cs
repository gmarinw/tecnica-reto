namespace WeightedUniformStrings.Core;

public class WeightedUniformStringSolver
{
    public List<string> WeightedUniformStrings(string s, List<int> queries)
    {
        //a = 1, b = 2
        //Cadena contigua = ccc
        //1. Determinar subcadena contigua dentro de una cadena
        //2. Construir un arreglo con los pesos obtenidos
        //3. Por cada valor q en querys devolver 
        //4. comparar lo que contiene mi conjunto query con el resultado U sin repetidos
        return new List<string>();
        //Crear letras con su respectivo valor 
        Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
        string abs = "abcdefghijklmnopqrstuvwxyz";
        char[] abcChar = abs.ToCharArray();
        for (int i = 1; i <= 26; i++)
        {
            keyValuePairs.Add(abcChar[i], i);
        }
        //Convertir el string en char para obtener subcadena
        char[] substr = s.ToCharArray();
        string temp = string.Empty;
        char[] substrigArray; //almacena las subcadenas
        string substrgTemp = string.Empty;
        int j = 0;//servirá para los indices de las cadenas substrings
        foreach (char c in substr)
        {

            //si no tiene nad asignado le asigna el valor
            if (string.IsNullOrEmpty(temp))
            {
                temp = c.ToString();
            }
            else
            {
                //armar la subcadena
                if (c.ToString()==temp)
                {
                    substrgTemp += c.ToString();
                }
            }
        }

        // Construir un arreglo con los pesos obtenidos
    }
}
