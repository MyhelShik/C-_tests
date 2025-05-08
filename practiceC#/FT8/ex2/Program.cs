internal class Program
{
    static bool LerNota(string mensagem, out double nota)
    {
        Console.WriteLine(mensagem);
        return double.TryParse(Console.ReadLine(), out nota);
    }
    private static void Main(string[] args)
    {
        double nota;
        bool valorValido = LerNota("Introduza a nota:", out nota);
        if (valorValido)
            Console.WriteLine("A nota introduzida foi " + nota);
        else
            Console.WriteLine("A nota introduzida não é válida");
    }
}