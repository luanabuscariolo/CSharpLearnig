using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace aula03;

class Program
{
    private static List<Produto> produtos = new List<Produto>();
    static void Main(string[] args)
    {
        Console.WriteLine("Classes, Objetos e Escopos de Visibilidade");

        /*
        Produto p1 = new Produto("Banana", 3.45);
        Produto p2 = new Produto("Maçã", 2.37);
        Produto p3 = new Produto("Pera", 5.10);
        Produto p4 = new Produto("Abacaxi", 7.20);
        Produto p5 = new Produto("Abacate", 4.99);

        List<Produto> produtos = new List<Produto>();
        produtos.Add(p1);
        produtos.Add(p2);
        produtos.Add(p3);
        produtos.Add(p4);
        produtos.Add(p5);

        foreach (Produto item in produtos)
        {
            item.Comprar(100);
            Console.WriteLine(item.ObterTexto());
        }
        */

        string comandoEscolhido = "S";

        do
        {
            //exibição do menu
            Console.Clear();
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Cadastrar produto");
            Console.WriteLine("2 - Listar produtos");
            Console.WriteLine("S - Sair");

            //leitura da opção desejada
            Console.Write("Opção desejada: ");
            comandoEscolhido = Console.ReadKey().KeyChar.ToString().ToUpper();

            switch (comandoEscolhido) {
                case "1":
                    Console.Write("\nNome do Produto: ");
                    string nome = Console.ReadLine();
                    Console.Write("\nPreço do Produto: ");
                    string preco = Console.ReadLine();
                    Produto novoProduto = new Produto(nome, Convert.ToDouble(preco));
                    produtos.Add(novoProduto);
                    Console.WriteLine("Produto adicionado com sucesso!");
                    break;
                case "2":
                    if (produtos.Count > 0)
                    {
                        Console.WriteLine("\nListagem de Produtos");
                        foreach (Produto item in produtos)
                        {
                            Console.WriteLine(item.ObterTexto());
                        }
                        Console.Write("Pressione qualquer tecla para prosseguir...");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("\nNão há produtos cadastrados.");
                    }
                    break;
                case "S":
                    Console.WriteLine("\nObrigado por usar o programa.");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida! Tente novamente.");
                    break;
            }
        } while (comandoEscolhido != "S");
    }
}
