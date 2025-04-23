using System.ComponentModel;

class Program
{
    class Expenses
    {
        private string category{get; set;}
        private int value{get; set;}        

        public Expenses(string category, int value)
        {
            this.category =  category;
            this.value = value;
        }
        void PrintExpenses(List<Expenses> expenses)
        {
            int index = 0;
            Console.WriteLine($"List of expenses: \n");
            for (int i = 0; i < expenses.Count; i++)
            {
                Console.WriteLine($"expense nº:{index++}\n{expenses[i].category}\n{expenses[i].value}\n");
            }
        }
        void RegisterExpenses(List<Expenses> expenses, string category, int value)
        {

            Console.WriteLine($"Type the category to register:");
            category = Console.ReadLine();

        
            Console.WriteLine($"Type the value of {category} category.");
            value = int.Parse(Console.ReadLine());

            Expenses expenses1 = new(category, value);
            expenses.Add(expenses1);
        }

        void TotalExpenses(List<Expenses> expenses)
        {
            int total = 0;
            for (int i = 0; i < expenses.Count; i++)
            {
                total += expenses[i].value;
            }
            Console.WriteLine($"Total expenses:{total}$");
        }

        void SearchExpenses(List<Expenses> expenses)
        {
            string input = "";
            int count = 0;
            int total = 0;
            Console.WriteLine($"Type category name to search...");

            input = Console.ReadLine();
            for (int i = 0; i < expenses.Count; i++)
            {
                count++;
                if(expenses[i].category == input)
                {
                    total += expenses[i].value;
                    Console.WriteLine($"Expense nº:{count}\nCategory:{expenses[i].category}\nValue:{expenses[i].value}\n");
                }
            }
            Console.WriteLine($"Total value of {input} category: {total}");
        }

        void RemoveExpenses(List<Expenses> expenses)
        {
            int index;
        }
    /*
        public void RemoveDespesa(List<Despesas> despesas)
        {
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


    */
    private static void Main(string[]args)
    {
        string category ="";
        int value = 0;
        int input = -1;

        List<Expenses> expenses_ = new List<Expenses>();
        Expenses expenses = new Expenses(category, value);
        

        while (input != 0)
        {
            Console.WriteLine($"0 - End program.\n 1 - Register Expenses\n 2 - Show Expenses\n 3 - Total of all expenses\n 4 - Search category + total of category\n 5 - Edit Expenses\n 6 - Remove Expenses\n");
            input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    expenses.RegisterExpenses(expenses_, category, value);
                break;
                case 2:
                    expenses.PrintExpenses(expenses_);
                break;
                case 3:
                    expenses.TotalExpenses(expenses_);
                break;
                case 4:
                    expenses.SearchExpenses(expenses_);
                break;
            }
        }
    }
    }
}