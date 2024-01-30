using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosClassesAbstratas
{
    internal class Carro : Veiculo
    {
        public Carro(double peso) : base(peso)
        {
            Console.WriteLine("Um novo objeto Carro foi construído.");

        }

        public override void Mover(double distancia) //override indica que você tem ciencia de que está implementando um método abstrato que veio do método ancestral
        {
            Console.WriteLine($"Um objeto Carro se moveu por {distancia}km");

        }
    }
}
