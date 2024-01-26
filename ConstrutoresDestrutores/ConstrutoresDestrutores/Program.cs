namespace ConstrutoresDestrutores
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Carro c1 = new Carro();
            c1.Modelo = "Fusca";
            c1.Preco = 9700;
            c1.Portas = 2;

            Carro c2 = new Carro();
            c2.Modelo = "Opala";
            c2.Preco = 49500;
            c2.Portas = 4;

            Carro c3 = new Carro("Palio"); 
        }
    }
}