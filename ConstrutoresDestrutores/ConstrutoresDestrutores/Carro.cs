using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutoresDestrutores
{
    class Carro : Veiculo
    {
        public string Modelo { get; set; }
        public int Portas { get; set; }
        public double Preco { get; set; }

        public Carro() // Construtor Padrão
        {
            Console.WriteLine("Um novo objeto Carro foi criado.");
        }

        public Carro(int pesoKg) : base(pesoKg)
        {
            //this.PesoKg = pesoKg;
            Console.WriteLine($"Um novo objeto do tipo Carro com peso {this.PesoKg} foi criado.");
        }

        public Carro(string modelo) : this() // Construtor Parametrizado
        {
            this.Modelo = modelo;
        }

        public Carro(string modelo, int portas, double preco) : this(modelo)
        {
            this.Portas = portas;
            this.Preco = preco;
        }

        ~Carro()
        {
            Console.WriteLine("Um objeto do tipo Carro foi destruido.");
        }
    }
}
