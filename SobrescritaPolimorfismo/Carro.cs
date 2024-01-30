using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrescritaPolimorfismo
{
    internal class Carro : Veiculo
    {
        private int capacidade;
        public override int Capacidade
        {
            get { return capacidade; }
            set
            {
                if ((value >= 2) && (value <= 7))
                {
                    capacidade = value;
                }
                else
                {
                    throw new Exception("O carro só pode ter capacidade de 2 à 7 pessoas.");
                }
            }
        }

        public override void Abastecer(double quantidadeLitros)
        {
            QuantidadeCombustivel += quantidadeLitros;
            Console.WriteLine($"Carro abastecido com {quantidadeLitros} litros de gasolina.");
        }

        public override void Mover(double distanciaKm)
        {
            if (QuantidadeCombustivel > (distanciaKm / 10))
            {
                QuantidadeCombustivel -= (distanciaKm / 10);
                Console.WriteLine($"O carro se moveu por {distanciaKm}km.");
            }
            else
            {
                Console.WriteLine("Não há combustível para percorrer a distância informada.");
            }
        }

        public override void Frear()
        {
            Console.WriteLine("Acionando os freios ABS... Parou!");
        }

        public Carro(int pesoKg, DateTime dataFabricacao, int capacidade = 5) : base(pesoKg, dataFabricacao)
        {
            Capacidade = capacidade;
        }
    }
}
