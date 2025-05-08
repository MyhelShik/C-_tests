internal class Program
{
    public static void Troca(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;

        // (a,b) = (b,a);
    }
    private static void Main(string[] args)
    {
        int a = 1, b = 2;
        Console.WriteLine("a = " + a + ", b = " + b); // Mostra: a = 1, b = 2
        Troca(ref a, ref b); // Este método deve trocar os valores das variáveis a e b
        Console.WriteLine("a = " + a + ", b = " + b); // Mostra: a = 2, b = 1
    }
}