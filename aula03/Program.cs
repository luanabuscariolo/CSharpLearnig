using System;

namespace aula03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Classes, Objetos e Escopos de Visibilidade");

        Produto p1 = new Produto();
        p1.Nome = "Banana";
        p1.Preco = 2.8;
        p1.Comprar(20);
        p1.Vender(3);

        Produto p2 = new Produto("Laranja", 4.75);
        p2.Comprar(100);
        p2.Vender(3);

        Produto p3 = new Produto("Abacaxi", 3.25);
        p3.Comprar(50);
        p3.Vender(3);

        Console.WriteLine(p1.Nome);
        Console.WriteLine(p1.Preco);
        Console.WriteLine($"Produto: {p1.Nome} = R$ {p1.Preco:F2} / Estoque: {p1.Estoque}");
        Console.WriteLine($"Produto: {p2.Nome} = R$ {p2.Preco:F2} / Estoque: {p1.Estoque}");
        Console.WriteLine($"Produto: {p3.Nome} = R$ {p3.Preco:F2} / Estoque: {p1.Estoque}");

        Console.WriteLine("*********Utilizando StringBuilder*********");
        Console.WriteLine(p1.ObterTexto());
        Console.WriteLine(p2.ObterTexto());
        Console.WriteLine(p3.ObterTexto());

    }
}
