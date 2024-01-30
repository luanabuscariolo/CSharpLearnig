using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosClassesAbstratas
{
    public sealed class Aviao : Veiculo // SEALED --> classe selada, não pode mais ter derivação. Impede que a classe Aviao seja ancestral de outra classe
    {
        public Aviao(double peso) : base(peso)
        {
            Console.WriteLine("Um novo objeto Aviao foi construído.");
        }

        public override void Mover(double distancia)
        {
            Console.WriteLine($"Um objeto Aviao se moveu por {distancia}km");
        }
    }
}
