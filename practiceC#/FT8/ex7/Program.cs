using System;
class MainClass
{
    static void Calcular(ref double media, ref int maximo, params int[] valores)
    {
        int soma = 0;
        foreach (int i in valores)
        {
            if (i > maximo)
                maximo = i;
            soma += i;
        }
        media = (double)soma / valores.Length;
    }
    public static void Main()
    {
        int maximo = 0;
        double media = 0;
        Calcular(ref media, ref maximo, 4, 2, 8, 2, 4);
        Console.WriteLine("Máximo = " + maximo + "; Média = " + media);
        Calcular(ref media, ref maximo, 1, 4);
        Console.WriteLine("Máximo = " + maximo + "; Média = " + media);
    }
}