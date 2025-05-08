public class Curso{

        public string nome {get; private set;}
        public int id {get; private set;}
        public List<Aluno> alunos;
        //Constutor

        public Curso(string nome, int id)
        {
            this.nome=nome;
            this.id=id;
            this.alunos = new List<Aluno>();
        }

        public void AdicionarAluno(Aluno aluno)
        {
            alunos.Add(aluno);
        }
        
    }