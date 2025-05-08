internal class Program
{
    static int Soma(params int[] vars)
    {
        int soma = 0;
        foreach(int valor in vars)
        {
            soma+=valor;
        }
        return 0;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine(Soma(2, 3)); //  → Saída: 5
        Console.WriteLine(Soma(2, 3, 4)); //   → Saída: 9
        Console.WriteLine(Soma(2, 3, 10, 20)); //   → Saída: 35
    }
}