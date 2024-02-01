using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoInterfaces
{
    class Macaco : IAnimal, IBipede
    {
        public void Andar()
        {
            Console.WriteLine("O macaco está andando.");
        }

        public void Caminhar()
        {
            Console.WriteLine("O macaco está caminhando.");
        }

        public void Comer()
        {
            Console.WriteLine("O macaco está comendo banana.");
        }

        public void Dormir()
        {
            Console.WriteLine("O macaco está dormindo na árvore.");
        }

        public void EmitirSom()
        {
            Console.WriteLine("Uh uh ah ah ah");
        }
    }
}
