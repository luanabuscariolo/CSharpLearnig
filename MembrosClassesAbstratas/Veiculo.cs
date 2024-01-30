using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosClassesAbstratas
{
    internal class Veiculo
    {
        public double Peso { get; set; }

        public Veiculo(double peso)
        {
            this.Peso = peso;
            Console.WriteLine("Um novo objeto Veiculo foi construido.");
        }

        ~Veiculo()
        {
            Console.WriteLine("Um novo objeto Veiculo foi destruido.");
        }
    }
}
