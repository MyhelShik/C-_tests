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
                index++;
                Console.WriteLine($"expense nº:{index}\n{expenses[i].category}\n{expenses[i].value}\n");
            }
        }
        void RegisterExpenses(List<Expenses> expenses)
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
                    Console.WriteLine($"\nExpense index:{count}\nCategory:{expenses[i].category}\nValue:{expenses[i].value}\n");
                }
            }
            Console.WriteLine($"Total value of {input} category: {total}$");
        }

        void RemoveExpenses(List<Expenses> expenses)
        {
            PrintExpenses(expenses);
            Console.WriteLine($"Type the index of the expense to remove...");

            int input = int.Parse(Console.ReadLine());

            if(input > 0 && input <= expenses.Count)
            {
                Console.WriteLine($"Succesfully removed category {input} and it's value.");
                expenses.RemoveAt(input - 1);
            }
            else
            {
                Console.WriteLine($"Something went wrong. Try again.");
            }

        }
    void EditExpenses(List<Expenses> expenses)
    {
        PrintExpenses(expenses);
        Console.WriteLine("\nType expense index to edit:");

        if (int.TryParse(Console.ReadLine(), out int input) && input > 0 && input <= expenses.Count)
        {
            int index = input - 1; // Преобразуем в индекс списка
            Expenses selectedExpense = expenses[index];

            Console.WriteLine($"\nCurrently editing: {selectedExpense.category} of value {selectedExpense.value}$");

            Console.WriteLine("Type new category:");
            string newCategory = Console.ReadLine();

            Console.WriteLine("Enter new value:");
            if (int.TryParse(Console.ReadLine(), out int newValue))
            {
                Console.WriteLine($"\nSuccessfully changed {selectedExpense.category}/{selectedExpense.value}$ to {newCategory}/{newValue}$");

                selectedExpense.category = newCategory;
                selectedExpense.value = newValue;
            }
            else
            {
                Console.WriteLine("Invalid number for value.");
            }
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    private static void Main(string[]args)
    {
        string category ="";
        int value = 0;
        int input = -1;

        List<Expenses> expenses_ = new();
        Expenses handler = new Expenses(category, value);
        

        while (input != 0)
        {
            Console.WriteLine($"0 - End program.\n 1 - Register Expenses\n 2 - Show Expenses\n 3 - Total of all expenses\n 4 - Search category + total of category\n 5 - Edit Expenses\n 6 - Remove Expenses\n");
            input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    handler.RegisterExpenses(expenses_);
                break;
                case 2:
                    handler.PrintExpenses(expenses_);
                break;
                case 3:
                    handler.TotalExpenses(expenses_);
                break;
                case 4:
                    handler.SearchExpenses(expenses_);
                break;

                case 5:
                    handler.EditExpenses(expenses_);
                break;

                case 6:
                    handler.RemoveExpenses(expenses_);
                break;
            }
        }
    }
    }
}