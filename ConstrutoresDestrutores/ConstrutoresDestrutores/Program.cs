using System;

namespace ConstrutoresDestrutores
{
    class Program
    {
        static Program()
        {
            Console.WriteLine("Programa iniciado com sucesso.");
        }

        static void CriarObjetos()
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
            c3.Portas = 2;
            c3.Preco = 15900;

            Carro c4 = new Carro("Monza", 4, 39400);

            Carro c5 = new Carro(1190);
        }

        static void Main(string[] args)
        {
            CriarObjetos();

            Console.WriteLine("Objetos não são mais utilizados nesse ponto.");

            GC.Collect();
        }
    }
}