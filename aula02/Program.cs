using System;

namespace C_learning;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Vitor";
        p1.Idade = 28;
        p1.Genero = 'M';

        p1.MostrarInfos();


/*************************************************************************/
//         Console.WriteLine("Hello, World!");
//         int n1 = 3;
//         double n2 = 3.4;
//         double n3 = n1 + n2;
//         string s1 = "Luana";
//         char c1 = '@';
//         bool parImpar = (n1 % 2 == 0);
//         int i = 0;

// /*************************************************************************/
//         Console.WriteLine(n1.GetType());
//         Console.WriteLine(n1);
//         Console.WriteLine(n1.ToString());
//         Console.WriteLine("teste: " + n1.ToString(), n2, s1, c1); 
//         Console.WriteLine($"testando: {n1}, {n2}, {s1}, {c1}");
//         Console.WriteLine($"A soma é: {n3:F4}.");

//         n3 += 5;

//         Console.WriteLine($"A nova soma é: {n3:F2}.");

// /*************************************************************************/
//         if (parImpar == true)
//         {
//             Console.WriteLine("Número PAR.");
//         }
//         else
//         {
//             Console.WriteLine("Número IMPAR.");
//         }

// /*************************************************************************/
//         switch (n1)
//         {
//             case 1:
//                 Console.WriteLine("Valor: 1");
//                 break;
//             case 2:
//                 Console.WriteLine("Valor: 2");
//                 break;
//             case 3:
//                 Console.WriteLine("Valor: 3");
//                 break;
//             case 4:
//                 Console.WriteLine("Valor: 4");
//                 break;
//             default:
//                 Console.WriteLine("Valor não está entre 1 e 4");
//                 break;
//         }

// /*************************************************************************/
//         while (i <= 10)
//         {
//             Console.WriteLine($"Iteração {i}.");
//             i++;
//             if (i == 5)
//             {
//                 break;
//             }
//         }
//             Console.WriteLine("Iteração finalizada.");

// /*************************************************************************/
//         for (int j = 0; j < 10; j++)
//         {
//             Console.WriteLine($"Iteração {j}.");
//             if (j == 5)
//             {
//                 break;
//             }
//         }
//         Console.WriteLine("Iteração finalizada.");
// /*************************************************************************/
//         for (int m = 0; m < 10; m++)
//         {
//             if (m == 5)
//             {
//                 continue;
//             }
//             Console.WriteLine($"Iteração {m}.");
//         }
//         Console.WriteLine("Iteração finalizada.");

// /*************************************************************************/
//         i = 11;

//         do {
//             i--;
//             if (i == 5)
//             {
//                 continue;
//             }
//             Console.WriteLine($"Iteração {i}");
//         } while (i > 0);

//         Console.WriteLine("Iteração finalizada.");
// /*************************************************************************/
//         Console.Write("Digite seu nome: ");
//         string nome1 = Console.ReadLine();
//         Console.WriteLine($"O nome digitado foi: {nome1} e possui {ContarLetras(nome1)} letras.");
//         MostrarDados();
    }

//     public static void MostrarDados() {
//         Console.Write("Digite seu sobrenome: ");
//         string sobrenome1 = Console.ReadLine();
//         Console.WriteLine($"O sobrenome digitado foi: {sobrenome1} e possui {ContarLetras(sobrenome1)} letras.");
//     }

//     public static int ContarLetras(string palavra) {
//         return palavra.Length;
//     }
}
