    internal class Program
    {
        class Film
        {
            public int ano{get; private set;}
            public string titulo{get; private set;}
            public decimal receitaBilheteira{get; set;}
            public bool premiado{get; set;}

            // getters and setters

            // public string GetTitulo(){return titulo;}
            // public string SetTitulo(string Titulo){this.titulo = Titulo; return this.titulo;}

            // public int GetAno(){return ano;}
            // public int SetAno(int Ano){this.ano = Ano; return this.ano;}

            // public decimal GetReceitaBilheteira(){return receitaBilheteira;}
            // public decimal SetReceitaBilheteira(decimal ReceitaBilheteira)
            // {
            //     if(ReceitaBilheteira >= 0)
            //         this.receitaBilheteira = ReceitaBilheteira; 
            //     return this.receitaBilheteira;
            // }

            // public bool GetPremiado(){return premiado;}
            // public bool SetPremiado(bool Premiado){this.premiado = Premiado; return this.premiado;}
            // getters and setters end

            

            public Film(string _titulo, int _ano, decimal _receitaBilheteira, bool _premiado)
            {
                this.titulo = _titulo;
                this.ano = _ano;
                this.receitaBilheteira = _receitaBilheteira;
                this.premiado = _premiado;
            }

            public void Display()
            {
                Console.WriteLine($"Titulo: {titulo}\nAno: {ano}\nBilheteira: {receitaBilheteira} \nPremiado?: {premiado}");
            }

            public override string ToString()
            {
                return $"Ano: {ano}Titulo: {titulo}Bilheteira: {receitaBilheteira} Premiado?: {premiado}";
            }

        }
        private static void Main(string[] args)
        {
            Film film = new Film("barbi", 1999, 100, true);
            Film film2 = new Film("forsach", 2000, 100, true);

            film.Display();
            film2.premiado = false;
            film2.receitaBilheteira = 140;
            film2.Display();

            film.ToString();
            film2.ToString();

            //Console.WriteLine($"{(filme.Premiado ? "Sim":"Não")}");
            
        }
    }