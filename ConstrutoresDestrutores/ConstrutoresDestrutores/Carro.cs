using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutoresDestrutores
{
    internal class Carro
    {
        public string Modelo { get; set; }
        public int Portas { get; set; }
        public double Preco { get; set; }

        public Carro() // Construtor Padrão
        {
            Console.WriteLine("Um novo objeto carro foi criado.");
        }
        public Carro(string modelo) : this() // Construtor Parametrizado
        {
            this.Modelo = modelo;
        }
    }
}
