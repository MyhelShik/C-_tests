﻿using System;
using System.Globalization;

class Program
{
    static void ex01()
    {
        int number = 0;

        Console.WriteLine("Type a number: ");
        number = int.Parse(Console.ReadLine());

        if (number > 0)
            Console.WriteLine($"{number} is bigger than 0");
        else
            Console.WriteLine($"{number} is smaller than 0");
        if (number == 0)
            Console.WriteLine($"{number} is equal to 0");
    }

    static void ex1()
    {
        int idade = 0;
        string nome = "";

        Console.WriteLine("Type year of birth: ");
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Type name: ");
        nome = Console.ReadLine();

        int anoAtual = DateTime.Now.Year;
        idade = anoAtual - idade;

        Console.WriteLine($"nome: {nome}, idade: {idade} ");
    }

    static void ex2()
    {
        int number = 0;
        number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
            Console.WriteLine("Par");
        else
            Console.WriteLine("Impar");
    }

    static void ex3()
    {
        int num1 = 0, num2 = 0, num3 = 0, temp = 0;

        Console.WriteLine("Introduz numero...");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduz numero...");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduz numero...");
        num3 = int.Parse(Console.ReadLine());

        temp = num1;
        if(num2 > temp)
        {
            temp = num2;
        }
        if(num3 > temp)
        {
            temp = num3;
        }
        if(num1 == num2 && num2 == num3)
        {
            Console.WriteLine("Todos numeros são iguais");
        }

        Console.WriteLine($"{temp} é maior");
    }
    


    static void ex4()
    {
        float var = 0;

        Console.WriteLine("Type grade: ");
        var = float.Parse(Console.ReadLine());

        if(var > 20)
            Console.WriteLine($"Invalido. {var}");
        if(var < 9.5)
            Console.WriteLine($"Insuficiente. {var}");
        if(var >= 9.5 && var <= 13.5)
            Console.WriteLine($"Suficiente. {var}");
        if(var >= 13.5 && var <= 15.5)
            Console.WriteLine($"Bom. {var}");
        if(var >= 17.5 && var <= 17.5)
            Console.WriteLine($"Muito Bom. {var}");
        if(var > 17.5)
            Console.WriteLine($"Excelente. {var}");
    }

    //Clear(); ??

    static void ex5()
    {
        int ano = 0;

        ano = int.Parse(Console.ReadLine());

        if(ano %400==4)
            Console.WriteLine("Bissesto");
        else   
            Console.WriteLine("N Bissesto");
        if(ano <= 1582)
            Console.WriteLine("Gregoriana.");
        else if(ano > 1582)
            Console.WriteLine("Fora da era Gregoriana");
    }

    static void ex6()
    {
        Double var = 0;

        Console.WriteLine("Type workhours");
        var = double.Parse(Console.ReadLine());
        if(var<0)
        {
            Console.WriteLine($"{var} é negativo, novamente");
        }
        else
        {
            Console.WriteLine($"Salary: {var*10}$");
        }
    }

    static void ex7()
    {
        int var = 0;

        var = int.Parse(Console.ReadLine());

        if(var >= 10 && var <= 15)
            var = var*var;
        Console.WriteLine($"quadrado: {var}");
    }

    static void ex8()
    {
       int number = 0, mult = 0, nonMult = 0;
       double percentage = 0;

       while(true)
       {
            Console.WriteLine("Type number : ");
            number = int.Parse(Console.ReadLine());

            if(number == 0)
                break;

            nonMult++;
            if(number %4 == 0)
            {
                mult++;
            }
       }

       if(mult == 0)
       {
            Console.WriteLine("None multiples were found.");
       }
       else
       {
            percentage = (mult / (double)nonMult) * 100;
            Console.WriteLine($"{percentage:F2}%");
       }
    }

    static void ex9()
    {
        int var = 0,count = 0, result = 0,result2 = 0;

        Console.WriteLine("Type a number.");
        var = int.Parse(Console.ReadLine());

        if(var <=23 && var >= 0)
        {
            result = var * var;
            result2 = var * var * var;
        }

        Console.WriteLine($"{var}^{var} ; {result} ");
        Console.WriteLine($"{var}^{var} ; {result2}");

    }

    static void ex10()
    {
        int var = 0;
        

       var =  int.Parse(Console.ReadLine());
        
        for (int i = 1; i < 11; i++)
            Console.WriteLine($"{var*i}");
        
    }
    
    static void ex11()
    {
        int var1 = 0, var = 0, count = 0;


        while(count != 5)
        {
            
            var = int.Parse(Console.ReadLine());
            var1 = var1 + var; 
            count++;
        }   

        Console.WriteLine($"Soma: {var1}");
    }

    static void ex12()
    {
        int code = 0, guess = 0, entries = 0;
        Console.WriteLine("Write a secret number for a second player to guess:");
        code = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Success! Now guess the number entering 0 and 100");

        while(true)
        {
            guess = int.Parse(Console.ReadLine());
            entries++;
            Console.WriteLine("Type the number to guess... ");

            if(guess<code)
                Console.WriteLine("Higher...");
            else
                Console.WriteLine("Lower...");
            if(guess < 0 || guess > 100)
                Console.WriteLine($"{guess} is out of range, try the number that is in range.");
            
            if(guess == code)
            {
                Console.WriteLine($"You won.");
                break;
            }
        }
        Console.WriteLine($"Numero introduzido secreto do p1: {code}, tentativas total: {entries}, numero guess do p2: {guess}");
        if(guess %2 == 0)
            Console.WriteLine("O número é par");
    }
    static void Main(string[] args)
    {
        //ex1
        ex3();
    }
}
