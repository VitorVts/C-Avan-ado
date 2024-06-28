namespace _25_StringsDelimitadas;

class Program
{
    static void Main(string[] args)
    {
        string resultado = Delimitador("---", "ola", "mundo", "pqp");
        System.Console.WriteLine(resultado);
    }

    static string Delimitador(string delimitador, params string[] texto)
    {
        if (texto.Length == 0)
        {
            return string.Empty;
        }
        System.Text.StringBuilder resultado = new System.Text.StringBuilder();

        for (int i = 0; i < texto.Length; i++)
        {
            resultado.Append(texto[i]);
            if (i < texto.Length - 1)
            {
                resultado.Append(delimitador);
            }
        }

        return resultado.ToString();
    }
}
