internal class Program
{
    // Main: Entry point of the program, creates Aluno objects and tests their methods.
    private static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        Aluno aluno2 = new Aluno("Johnny", "Informatica", 1);    
        
        Aluno aluno3 = CriarAluno();
        aluno2.MostrarInformacao();
        aluno2.passarAno();
    }

    // CriarAluno: Prompts user for input to create and return a new Aluno object with all attributes.
    static Aluno CriarAluno()
    {
        Console.WriteLine("Introduz nome");
        string nome = Console.ReadLine();
        Console.WriteLine("Introduz curso");
        string curso = Console.ReadLine();
        Console.WriteLine("Introduz numero");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduz ano curricular");
        int ano = int.Parse(Console.ReadLine());

        Aluno aluno = new Aluno(nome, curso, ano);
        return aluno;
    }
}

class Aluno
{
    int proximoNumero = 10000;
    string nome;
    string curso;
    int numeroAluno;
    int anoCurricular;

    // Aluno (default constructor): Creates an Aluno object with default values for all attributes.
    public Aluno()
    {
        this.nome = "nome";
        this.curso = "curso";
        this.numeroAluno = proximoNumero;
        proximoNumero++;
        this.anoCurricular = 1;
    }

    // Aluno (single parameter constructor): Creates an Aluno object with only a student number (not fully implemented).
    public Aluno(int numeroAluno)
    {
        // depois 
    }

    // Aluno (full constructor): Creates an Aluno object with specified values for all attributes.
    public Aluno(string nome, string curso, int anoCurricular)
    {
        this.nome = nome;
        this.curso = curso;
        this.numeroAluno = proximoNumero;
        proximoNumero++;
        this.anoCurricular = anoCurricular;
    }

    // MostrarInformacao: Displays all attributes of an Aluno object to the console.
    public void MostrarInformacao()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Curso: {curso}");
        Console.WriteLine($"Número do Aluno: {numeroAluno}");
        Console.WriteLine($"Ano Curricular: {anoCurricular}");
    }

    public override string ToString()
    {
        return $"Nome: {nome}\nCurso: {curso}\nNúmero do Aluno: {numeroAluno}\n numero do ano: {anoCurricular}";
    }

    public void passarAno()
    {
        Console.WriteLine($"ano curricular:{anoCurricular}");
        if(anoCurricular == 1 || anoCurricular == 2)
            anoCurricular++;
        Console.WriteLine($"novo ano curricular:{anoCurricular}");
    }
}