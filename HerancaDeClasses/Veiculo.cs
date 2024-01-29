using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaDeClasses
{
    class Veiculo
    {
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Comprimento { get; set; }
        protected double Densidade
        {
            get
            {
                return this.Peso / (this.Altura * this.Largura * this.Comprimento);
            }
        }

        public Veiculo(double peso, double altura, double largura, double comprimento)
        {
            this.Peso = peso;
            this.Altura = altura;
            this.Largura = largura;
            this.Comprimento = comprimento;
            Console.WriteLine("Um objeto do tipo Veiculo foi criado.");
        }
        ~Veiculo()
        {
            Console.WriteLine("Um objeto do tipo Veiculo foi destruido.");
        }
    }
}
