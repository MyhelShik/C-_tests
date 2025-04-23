using System.Reflection.PortableExecutable;

class Program
{

static void arr()
{
    int size = 0;
    
    size = int.Parse(Console.ReadLine());
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Type number {i+1}: ");
        arr[i] = int.Parse(Console.ReadLine());
        Console.WriteLine($"{arr[i]}");
    }    

    Console.WriteLine("Result");
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

static void arr2()
{
    int size = 0;
    int[] arr2; 


    Console.WriteLine("Enter the size of array. ");
    size = int.Parse(Console.ReadLine());
    arr2 = new int[size];

    Console.WriteLine("Enter 5 elements now. ");
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"{i+1}: ");
        arr2[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine($"Numbers entered... ");
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"{i+1}:{arr2[i]}");
    }
    Console.WriteLine($"Numbers entered in reverse... ");
    for (int i = size - 1; i >= 0; i--)
    {
        Console.WriteLine($"{i+1}:{arr2[i]}");
    }
    int sum = 0;
    Console.WriteLine($"Sum of all elements... ");
    for (int i = 0; i < size; i++)
    {
        sum += arr2[i];
    }
        Console.WriteLine($"{sum}");
    int min=0,max=0;

    min = arr2.Min();
    max = arr2.Max();

    Console.WriteLine($"Minimo: {min} ; Maximo: {max}");
}

// list declaration instead of array

static void L1()
{
    List<double> pesos = new List<double>{74.2, 46.2, 55.8, 63.1, 83.9};

    Console.WriteLine("List of pesos: ");
    foreach(var peso in pesos)
    {
        Console.WriteLine($"foreach loop element... {peso}");
    }
    for (int i = 0; i < pesos.Count; i++)
    {
        Console.WriteLine($"For loop element... {pesos[i]}");
    }

    //<60 condição
    for (int i = pesos.Count - 1; i >= 0; i--) // when using ++, it doesnt count everything since the previous slot is removed >> [0]==false, [1] true? >> removing, 2 replaces 1, meaning it will stay when it is also true
    {
        if(pesos[i]<60) // or pesos.RemoveAll(peso => peso < 60)
        {
            Console.WriteLine($"removed item:{pesos[i]}");
            pesos.RemoveAt(i);
        }
    }
    for (int i = 0; i < pesos.Count; i++)
    {
        Console.WriteLine($"{pesos[i]}");
    }
}

static void L2()
{
    string input = "s";
    List<string> Bandas = new List<string>();

    while(!string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Type bands. If space is empty, program ends.");
        input = Console.ReadLine();
        Bandas.Add(input);
    }

    Console.WriteLine("List of bands:");
    for (int i = 0; i < Bandas.Count; i++)
        Console.WriteLine(Bandas[i]);

    Console.WriteLine("Do you wish to remove some strings? Indicate a position to remove.");
    
    string choiceInput = "";
    
    for (int i = 0; i < Bandas.Count; i++)
    {
        Console.WriteLine("Type string with exact letters you wish to remove.");
        choiceInput = Console.ReadLine();
        if(choiceInput == Bandas[i])
        {
            Console.WriteLine($"Successfuly removed: {Bandas[i]}");
            Bandas.RemoveAt(i);
        }
        else
        {
            Console.WriteLine($"Error. {choiceInput} is not what was expected. Try again.");
        }
        Console.WriteLine("Want to remove more? Y/N");
        choiceInput = Console.ReadLine();
        
        if(choiceInput == "N" || choiceInput == "n")
            break;
    }

    Bandas.Sort(); // sorts the strings in a alphabetical order func
    for (int i = 0; i < Bandas.Count; i++)
        Console.WriteLine(Bandas[i]);
}

static void L4()
{
    List<int> Pars = new List<int>();
    List<int> Impars = new List<int>();

    Console.WriteLine("Type random size:");
    int size = int.Parse(Console.ReadLine());
    Random rnd = new Random();

    int num = 0;
    for (int i = 0; i < size; i++)
    {
        num = rnd.Next(1, 100);
        if(num % 2 == 0)
            Pars.Add(num);
        else
            Impars.Add(num);
    }

    Console.WriteLine("Pars:");
    for (int i = 0; i < Pars.Count; i++)
    {
        Console.WriteLine($"{Pars[i]}");
    }
    Console.WriteLine("Impars:");
    for (int i = 0; i < Impars.Count; i++)
    {
        Console.WriteLine($"{Impars[i]}");
    }
}
static void Main(string[]args)
{
    L4();
}

}