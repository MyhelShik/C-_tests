class Pessoa
{
    public string nome{get;set;}
    public int idade {get;}

    List<Endereco> enderecos;

    public Pessoa(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
        this.enderecos = new List<Endereco>();

    }
    public void setEndereco(Endereco endereco)
    {
        this.enderecos.Add(endereco);
    }

    public void printEnderecos()
    {
        foreach (var endereco in enderecos)
        {
            Console.WriteLine(endereco);
        }
    }
    public override string ToString()
    {
        return ($"nome: {nome}idade: {idade} enderecos: {enderecos.Count}, todos enderecos: {printEnderecos}");
    }

}