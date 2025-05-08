internal class Program{

    private static void Main(string[]args)
    {
         // Instancia a escola
        Escola escola = new Escola("ESaCT");

        // Instancia os cursos
        Curso curso1 = new Curso("Programação", 1);
        Curso curso2 = new Curso("Design Gráfico", 2);

        // Adiciona os cursos à escola
        escola.AdicionarCurso(curso2);
        escola.AdicionarCurso(curso1);

        // Instancia os alunos
        Aluno aluno1 = new Aluno("João",1111, 2023, curso1);
        Aluno aluno2 = new Aluno("Maria",1112, 2023, curso1);
        Aluno aluno3 = new Aluno("Pedro",11113, 2023, curso2);

        // Adiciona os alunos aos cursos
        curso1.AdicionarAluno(aluno1);
        curso1.AdicionarAluno(aluno2);
        curso2.AdicionarAluno(aluno3);

        // Exibe os dados da escola, cursos e alunos
        Console.WriteLine($"Escola: {escola.nome}");
        foreach (var curso in escola.cursos)
        {
            Console.WriteLine($"\nCurso: {curso.nome}");
            Console.WriteLine("Alunos:");
            foreach (var aluno in curso.alunos)
            {
                Console.WriteLine($"- {aluno.nome}");
            }
        }
    }

    

    
}
