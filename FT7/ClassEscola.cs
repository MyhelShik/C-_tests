public class Escola{

        public string nome {get; private set;}
        public List<Curso> cursos {get; set;}
        //Construtor 
        public Escola(string nome){
            this.nome = nome;
            this.cursos = new List<Curso>();
        }

        public void AdicionarCurso(Curso curso)
        {
            cursos.Add(curso);
        }

        
    }