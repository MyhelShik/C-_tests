public class Aluno
{
    public string nome {get; set;}
    public int numeromacografico {get; set;}
    public int ano {get; set;}
    public Curso curso {get; set;}

    //construtor
    public Aluno(string nome, int numeromacografico ,int ano, Curso curso)
    {
        this.nome = nome;
        this.ano = ano;
        this.curso = curso;
        this.numeromacografico = numeromacografico;
    }

    public override string ToString()
    {
        return $"{numeromacografico} - {nome} (ano: {ano}) - Curso: {curso}";
    }
    
}