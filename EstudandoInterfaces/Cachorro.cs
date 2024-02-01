using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoInterfaces
{
    class Cachorro : IAnimal, IQuadrupede
    {
        void IAnimal.Andar()
        {
            Console.WriteLine("O cachorro está andando.");
        }

        void IQuadrupede.Andar()
        {
            Console.WriteLine("O cachorro está andando com as 4 patas.");
        }

        public void Comer()
        {
            Console.WriteLine("O cachorro está comendo ração.");
        }

        public void Correr()
        {
            Console.WriteLine("O cachorro está correndo com as 4 patas.");
        }

        public void Dormir()
        {
            Console.WriteLine("O cachorro está dormindo no chão.");
        }

        public void EmitirSom()
        {
            Console.WriteLine("Au au au.");
        }

        public void Farejar()
        {
            Console.WriteLine("O cachorro está farejando.");
        }
    }
}
