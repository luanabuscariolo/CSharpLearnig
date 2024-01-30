using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrescritaPolimorfismo
{
    internal class Onibus : Veiculo
    {
        private int capacidade;
        public override int Capacidade
        {
            get { return capacidade; }
            set
            {
                if ((value >= 18) && (value <= 60))
                {
                    capacidade = value;
                }
                else
                {
                    throw new Exception("O ônibus pode ter capacidade de 18 a 60 pessoas.");
                }
            }
        }

        public Onibus(int pesoKg, DateTime dataFabricacao, int capacidade = 44) : base(pesoKg, dataFabricacao)
        {
            Capacidade = capacidade;
        }

        public override void Abastecer(double quantidadeLitros)
        {
            QuantidadeCombustivel += quantidadeLitros;
            Console.WriteLine($"Ônibus abastecido com {quantidadeLitros} litros de diesel.");
        }

        public override void Mover(double distanciaKm)
        {
            if (QuantidadeCombustivel > (distanciaKm / 5))
            {
                QuantidadeCombustivel -= (distanciaKm / 5);
                Console.WriteLine($"O ônibus se moveu por {distanciaKm}km.");
            }
            else
            {
                Console.WriteLine("Não há combustível para percorrer a distância informada.");
            }
        }

        public new void Frear()
        {
            Console.WriteLine("Acionando os freios a ar... Parou!");
        }
    }
}
