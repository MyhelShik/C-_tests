class Program
{

    static int Somar(int i, int j){return i+j;}
    
    static void Saudar(int i)
    {
        if(i < 0 || i > 24)
        {
            Console.WriteLine("Erro.");
        }
        else
        {
            if(i>=10 && i<15)
                Console.WriteLine($"{i} → bom dia");
            else if(i>=15 && i<22)
                Console.WriteLine($"{i} → boa tarde");
            else
                Console.WriteLine($"{i} → bom noite");
        }
    }

    static void IMC()
    {
        double peso = 0, altura = 0;
        int ask = 1;
        double result = 0;
        List<double> IMC = new List<double>();

        Console.WriteLine("Enter the size for the List.");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine($"List size is -> {size}");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Type weight");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Type height");
            altura = double.Parse(Console.ReadLine());
            result = peso/(altura*altura);
            IMC.Add(result);

            Console.WriteLine("1 - continue or more(by default), 0 - stop");
            ask = int.Parse(Console.ReadLine());
            if(ask == 0)
                break;
        }


        // Abaixo de 18,5: Abaixo do peso normal
        // ▪ 18,5 – 24,9: Peso normal
        // ▪ 25,0 – 29,9: Acima do peso normal
        // ▪ 30 ou mais: Obesidade 

        for (int i = 0; i < IMC.Count; i++)
        {
            if(IMC[i] <= 0)
                Console.WriteLine($"Erro. IMC {i}");
            else
            {   
                if(IMC[i] < 18.5)
                    Console.WriteLine($"{IMC[i]} IMC---> Abaixo do peso normal.");
                if(IMC[i]>= 18.5 && IMC[i] < 24.9)
                    Console.WriteLine($"{IMC[i]} IMC---> Peso normal.");
                if(IMC[i] >= 25.0 && IMC[i] <= 29.9)
                    Console.WriteLine($"{IMC[i]} IMC---> Acima do peso normal.");
                if(IMC[i] >= 30)
                    Console.WriteLine($"{IMC[i]} IMC---> Obesidade.");
            }
            
        }
    }

    static int PS2I(string text)
    {
        int inteiro = int.Parse(Console.ReadLine());

        return inteiro;
    }

public static void ResQuad()
{
    double medida = 0, area = 0, perimetro = 0;
    Console.Write("Introduza a medida de um lado do quadrado: ");
    medida = double.Parse(Console.ReadLine());
    while (!double.TryParse(Console.ReadLine(), out medida) || medida <= 0)
    {
        Console.Write("Erro: Introduza um número positivo válido: ");
    }
        area = AreaQuadrado(medida);
        perimetro = PerimetroDoQuad(medida);
        Console.WriteLine("A área do quadrado é de " + area);
        Console.WriteLine("O perímetro do quadrado é de "+ perimetro);
}
static double AreaQuadrado(double lado)
{
    return lado * lado;
}
static double PerimetroDoQuad(double lado)
{
    return 4 * lado;
}

static void SymbCount()
{
    
}
    public static void Main(string[]args)
    {
        // P1
        // Console.WriteLine(Somar(5, 10));

        // P2
        /* for (int i = 0; i < 3; i++)
        {
            int num = int.Parse(Console.ReadLine());
            Saudar(num);
        } 
        */


        // Example?
        // Console.WriteLine(PS2I("escreve o numero"));

        // P3
        //IMC();
        
        // P4d
        // ResQuad();
        
    }
}