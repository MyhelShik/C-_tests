class Endereco
{
    string rua{get;set;}
    int numero {get; set;}
    string localidade {get; set;}

    public Endereco(string rua, int numero, string localidade)
    {
        this.rua = rua;
        this.numero = numero;
        this.localidade = localidade;
    }

    public override string ToString()
    {
        return $"{rua}, n.{numero}, {localidade}";
    }
}