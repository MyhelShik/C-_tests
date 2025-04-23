internal class Program
{

class Despesas
{
    private string category {get; set;}
    private int value {get; set;}
    public int total;

    public Despesas(string category, int value)
    {
        this.category = category;
        this.value = value;
    }

    public void ShowDespesas(List<Despesas> despesas)
    {
        int count = 1;

        for (int i = 0; i < despesas.Count; i++)
        {
            Console.WriteLine($"num:{count++}\nCategoria: {despesas[i].category}\n Valor: {despesas[i].value}$");
        }
    }

    public void ShowDispesas()
    {
        Console.WriteLine($"Categoria:{category}\nValor:{value}");
    }

    public void MostrarTotalDespesas(List<Despesas> despesas)
    {
        int total = 0;
        for (int i = 0; i < despesas.Count; i++)
        {
            total += despesas[i].value;
        }
        Console.WriteLine($"Total dispesas valor: {total}$");
    }

    public void RegisterDespesas(List<Despesas> despesas, string category, int value)
    {
        Despesas despesas1 = new Despesas(category, value);
        despesas.Add(despesas1);

    }

    public void isIgualDespesa(List<Despesas> despesas, string category)
    {
        int tempValue = 0;
        int count = 0;
        Console.WriteLine($"Resultado da procura pelo:{category}");
        for(int i = 0; i < despesas.Count; i++)
        {
            if(despesas[i].category == category)
            {
                count++;
                tempValue += despesas[i].value;
                Console.WriteLine($"\nnº{count}\n{despesas[i].category}\n{despesas[i].value}$");
            }
            
        }
        Console.WriteLine($"Total valor da categoria: {tempValue}");
    }

    public void EditDespesa(List<Despesas> despesas)
    {
        string category;
        int value;
        int count = 0;
        int input = 0;
        Console.WriteLine("\nDispesas\n");
        for (int i = 0; i < despesas.Count; i++)
        {
            count++;
            Console.WriteLine("\nDebug for \n");
            Console.WriteLine($"\n{count}\ncategoria:{despesas[i].category}\nValor:{despesas[i].value}\n");
        }
        
        Console.WriteLine("\nEscolha numero da dispesa para editar...\n");
        input = int.Parse(Console.ReadLine());
        
            for (int i = 0; i < input; i++)
            {
                    Console.WriteLine($"\nEstá a editar {despesas[i].category} com valor {despesas[i].value}$ \n");
                    Console.WriteLine("\nEscreva nova categoria: ");
                    category = Console.ReadLine();

                    Console.WriteLine("\nEscreva novo valor: ");
                    value = int.Parse(Console.ReadLine());

                    
                    despesas[i].category = category;
                    despesas[i].value = value;

                    Console.WriteLine($"\n New categoria: {despesas[i].category} \nValor novo: {despesas[i].value}$ \n");
                
            }
    }
    
    
    public void RemoveDespesa(List<Despesas> despesas)
{
    ShowDespesas(despesas);
    Console.WriteLine("\nEscolha o número da despesa para remover:");

    string inputStr = Console.ReadLine();

    if (int.TryParse(inputStr, out int input) && input > 0 && input <= despesas.Count)
    {
        int index = input - 1; 
        Console.WriteLine($"\nCategoria {despesas[index].category} removida com valor {despesas[index].value}$");
        despesas.RemoveAt(index);

    }
    else
    {
        Console.WriteLine("Número inválido.");
    }
}

    
    private static void Main(string[]args)
    {
        List<Despesas> despesas_ = new List<Despesas>();
        string cat ="";
        int val = 0;
        Despesas despesas = new Despesas(cat, val);

        int input = -1;
        while(input != 0)
        {
            Console.WriteLine($"0 - Terminar programma.\n 1 - Registar Dispesas\n 2 - Mostrar Dispesas\n 3 - Total das todas dispesas\n 4 - Procurar categoria + total da categoria\n 5 - Editar Dispesas\n 6 - Remover Dispesas\n");
            input = int.Parse(Console.ReadLine());
            switch(input)
            {
                case 0: 
                Console.WriteLine($"Terminação...");
                input = 0;
                break;
                case 1: 
                    Console.WriteLine($"Registar Dispesas...\n");

                    Console.WriteLine($"\nEscreva cateroria:");
                    cat = Console.ReadLine();
                    Console.WriteLine($"\nEntre Valor...");
                    val = int.Parse(Console.ReadLine());

                    despesas.RegisterDespesas(despesas_, cat, val);
                break;
                case 2: 
                    Console.WriteLine($"Mostrar Dispesas...\n");
                    despesas.ShowDespesas(despesas_);
                break;
                case 3: 
                    Console.WriteLine($"Total das Dispesas...\n");
                    despesas.MostrarTotalDespesas(despesas_);
                break; 
                case 4: 
                    Console.WriteLine($"Procurar Dispesas...\n");

                    Console.WriteLine($"Escreva a categoria a procurar:\n");
                    cat = Console.ReadLine();
                    despesas.isIgualDespesa(despesas_,cat);
                break;

                case 5:
                    Console.WriteLine($"Editar Dispesas...\n");
                    despesas.EditDespesa(despesas_);
                break;
                
                case 6: 
                    Console.WriteLine($"Remover Dispesas...\n");
                    despesas.RemoveDespesa(despesas_);
                break;
            
            }
        }
        

        
    }
}
}