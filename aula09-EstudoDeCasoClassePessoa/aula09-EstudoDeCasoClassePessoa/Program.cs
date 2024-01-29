using aula09_EstudoDeCasoClassePessoa;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa("Luana", "Buscariolo", new DateTime(1995, 7, 23), "58877733345");
        p1.Peso = 61;
        p1.Altura = 1.52;
        p1.MostrarDados();
        p1.Comer(2.5);
        p1.Comer(3800);
        p1.Correr(7, 30);
        p1.MostrarDados();

        Console.WriteLine("");

        Pessoa p2 = new Pessoa("Luana", "Buscariolo", new DateTime(1995, 7, 23), "89877733345", 62, 1.65);
        p2.MostrarDados();
    }
}