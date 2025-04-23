class Program
{
    public class Rectangle
    {
        int Base, Altura, Area, Perimetro;
        int temp1, temp2;

        public Rectangle(int b, int a)
        {
            this.Base = b;
            this.Altura = a;
        }
        public string ToString()
        {
            Console.WriteLine($"Base: {Base}\nAltura: {Altura}");
            return $"{Base} {Altura}";
        }

        public int Ar()
        {
            Area = Base*Altura;
            Console.WriteLine($"Area: {Area}");
            return Area;
        }

        public int perimetr()
        {
            Perimetro = 2*(Base+Altura);
            Console.WriteLine($"Perimetro: {Perimetro}");
            return Perimetro;
        }

        public void Quadrado()
        {
            if(Base == Altura)
                Console.WriteLine($"{Base} == {Altura}");
            else
                Console.WriteLine($"{Base} != {Altura}");
        }

        public void Redimensional()
        {
            double fator;
            fator = double.Parse(Console.ReadLine());
            if(fator <= 0)
            {
                Console.WriteLine("Fator invalido");
                return;
            }
            else 
            {
                Base = (int)(Base * fator);
                Altura = (int)(Altura * fator);

                Console.WriteLine($"Base redimensionada --> {Base}\n Altura redimensionada --> {Altura}");
            }
        }
        
        public void Rodar()
        {
            int temp;
            temp = Altura;
            Altura = Base;
            Base = temp;

            Console.WriteLine($"Base rodada: {Base}\nAltura rodada: {Altura}");
        
        }

        public void Comparar(int a, int b)
        {
            if(this.Base == temp1 && this.Altura == temp2)
                Console.WriteLine($"{temp1} == {this.Base} && {temp2} == {this.Altura} --> Rectangulos são iguais.");
            else
                Console.WriteLine($"{temp1} != {this.Base} && {temp2} != {this.Altura} --> Rectangulos não são iguais.");
        }

        public void Comparar(Rectangle outro)
        {
            if (this.Base == temp1 && this.Altura == temp2)
                Console.WriteLine($"{this.Base} == {temp1} ,{this.Altura} == {temp2} --> Rectangulos são iguais.");
            else
                Console.WriteLine($"{this.Base} == {temp1} ,{this.Altura} == {temp2} --> Rectangulos não são iguais.");

        }

        
    }
    
    public static void Main(string[]args)
    {
        int a, b;
        Console.WriteLine("Escreva Base: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva Altura: ");
        b = int.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(a,b);
    
        rectangle.ToString();
        rectangle.Ar();
        rectangle.perimetr();
        rectangle.Quadrado();
        
        rectangle.Redimensional();
        rectangle.Rodar();

        // rectangle.Save(a, b);
        // a = 0;
        // b = 0;

        // Console.WriteLine("Escreva Base: ");
        // a = int.Parse(Console.ReadLine());
        // Console.WriteLine("Escreva Altura: ");
        // b = int.Parse(Console.ReadLine());
    
        // rectangle.ToString();
        // rectangle.Ar();
        // rectangle.perimetr();
        // rectangle.Quadrado();
        
        // rectangle.Redimensional();
        // rectangle.Rodar();


        Console.WriteLine("Escreva Base: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva Altura: ");
        b = int.Parse(Console.ReadLine());
        Rectangle rectangle2 = new Rectangle(a,b);
    
        rectangle2.ToString();
        rectangle2.Ar();
        rectangle2.perimetr();
        rectangle2.Quadrado();
        
        rectangle2.Redimensional();
        rectangle2.Rodar();




        rectangle.Comparar(rectangle2);
    }
    
}