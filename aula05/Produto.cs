using System;
using System.Text;

class Produto
{
    private string nome; //ATRIBUTO - armazena valores na memória do computador

    public string Nome //PROPRIEDADE - ponte de acesso ao atributo, é uma forma de proteger o acesso de leitura e escrita do atributo (não armazena valores na memória)
    {
        get //retornar o valor da propriedade
        { return nome; }
        set //usado para atribuir um novo valor
        {
            if (value.Length > 1)
                nome = value;
            else
                throw new Exception("Nome do produto deve ter pelo menos 2 caracteres.");
        }
    }

    // private double preco;
    // public double Preco
    // {
    //     get {return preco;}
    //     set {preco = value;}
    // }

    public double Preco { get; set; } //Essa única linha equivale às demais acima. É automático, gera um atributo nos bastidores. Get e Set públicos

    public int Estoque { get; private set; } //Pode ser lido em qualquer lugar, mas só pode ser escrito dentro da classe Produto

    //Método Construtor: é público, tem o mesmo nome da classe e não tem retorno
    public Produto()
    {
        this.Estoque = 0;
    }

    public Produto(string nome, double preco)
    {
        this.Nome = nome;
        this.Preco = preco;
        this.Estoque = 0;
    }

    public int Vender(int qtde)
    {
        if (this.Estoque - qtde >= 0)
        {
            this.Estoque -= qtde;
        }
        return this.Estoque;
    }

    public int Comprar(int qtde){
        this.Estoque += qtde;
        return this.Estoque;
    }

    public string ObterTexto(){
        StringBuilder sb = new StringBuilder();
        sb.Append($"\nNome: {this.Nome}\n");
        sb.Append($"Preço: {this.Preco}\n");
        sb.Append($"Estoque: {this.Estoque}\n");
        return sb.ToString();
    }
}
