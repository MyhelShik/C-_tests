using System;
class MainClass
{
static void DobroA(int x)
{
x *= 2;
}
static void DobroB(ref int x)
{
x *= 2;
}
static void DobroC(out int x)
{
x = 2;
}
public static void Main()
{
int x = 5;
Console.WriteLine("Valor inicial de x: " + x);
DobroA(x);
Console.WriteLine("Valor de x após DobroA: " + x); // 5
x = 5;
DobroB(ref x);
Console.WriteLine("Valor de x após DobroB: " + x); // 10
x = 5;
DobroC(out x);
Console.WriteLine("Valor de x após DobroC: " + x); // 2


// passagem por valor(a), por referência(b) ou de saída(c)?

// 6.2 - O metodo recebe so dois parametros, e no main esta a tentar passar mais do que dois nas duas linhas.
}
}