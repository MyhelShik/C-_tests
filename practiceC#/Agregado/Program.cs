internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa("RUdeous", 15);
        Endereco endereco1 = new Endereco("rusek", 16, "cockHOuse");
        Endereco endereco2 = new Endereco("rusek", 16, "cockHOuse2");

        pessoa1.setEndereco(endereco1);
        pessoa1.setEndereco(endereco2);
        Console.WriteLine(pessoa1);
    }
}