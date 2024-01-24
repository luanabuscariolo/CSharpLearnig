class Produto
{
    private string nome;

    public string Nome {
        get {
            return nome;
        }
        set {
            if (value.Length > 1)
            {
                nome = value;
            }
            else
            {
                throw new Exception("Nome do produto deve ter pelo menos 2 caracteres.");
            }
        }
    }
}