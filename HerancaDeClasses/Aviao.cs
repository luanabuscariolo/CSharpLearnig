using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaDeClasses
{
    class Aviao : Veiculo
    {
        public int Passageiros { get; set; }
        public double Altitude { get; set; }

        public Aviao(double peso, double altura, double largura, double comprimento, int passageiros) : base(peso, altura, largura, comprimento)
        {
            this.Passageiros = passageiros;
            this.Altitude = 0;
            Console.WriteLine($"Um objeto do tipo Aviao foi criado com densidade {this.Densidade:F2}kg/m3.");
        }

        ~Aviao()
        {
            Console.WriteLine("Um objeto do tipo Aviao foi destruido.");
        }

        public void Voar(double distancia)
        {
            this.Decolar(1000);
            double percorrida = 0;
            while (percorrida < distancia)
            {
                Console.WriteLine($"O avião está a {(distancia - percorrida):F2} metros de distância do destino.");
                percorrida += 220;
                Thread.Sleep(1000);
            }
            this.Pousar();
        }

        private void Decolar(int altitude)
        {
            while (this.Altitude < altitude)
            {
                Console.WriteLine($"O avião está a {this.Altitude:F2} metros de altitude.");
                this.Altitude += 60;
                Thread.Sleep(1000);
            }
            Console.WriteLine("Decolagem concluída.");
            Thread.Sleep(1000);
        }

        private void Pousar()
        {
            while (this.Altitude > 0)
            {
                Console.WriteLine($"O avião está a {this.Altitude:F2} metros de altitude.");
                this.Altitude -= 60;
                Thread.Sleep(1000);
            }
            Console.WriteLine("Pouso concluído.");
            Thread.Sleep(1000);
        }

    }
}
