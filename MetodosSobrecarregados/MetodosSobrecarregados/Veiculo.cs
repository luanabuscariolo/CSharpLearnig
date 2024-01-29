using System;
using System.Threading.Tasks;

namespace MetodosSobrecarregados
{
    enum CorVeiculo
    {
        Branco,
        Preto,
        Vermelho,
        Prata,
        Grafite
    }

    class Veiculo
    {
        public string Modelo { get; set; }
        public int Peso { get; set; }
        public double Velocidade { get; set; }
        public int Portas { get; set; }
        public CorVeiculo Cor { get; set; }

        public Veiculo(string modelo)
        {
            this.Velocidade = 0;
            this.Modelo = modelo;
        }

        public Veiculo(string modelo, CorVeiculo cor) : this(modelo)
        {
            this.Cor = cor;
        }

        public Veiculo(string modelo, CorVeiculo cor, int portas = 4) : this(modelo, cor)
        {
            this.Portas = portas;
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Veículo {this.Modelo} :: Cor {this.Cor} :: {this.Portas} Portas");
        }
        public void MostrarDados(int nroLinha)
        {
            Console.WriteLine($"{nroLinha}. Veículo {this.Modelo} :: Cor {this.Cor} :: {this.Portas} Portas");
        }

        /// <summary>
        /// Método utilizado para aumentar a velocidade do veículo.
        /// </summary>
        public void Acelerar()
        {
            this.Velocidade += 10;
        }

        /// <summary>
        /// Método utilizado para aumentar a velocidade do veículo.
        /// </summary>
        /// <param name="acrescimo">Quantidade a ser aumentada.</param>
        public void Acelerar(int acrescimo)
        {
            this.Velocidade += acrescimo;
        }

        public void Acelerar(int acrescimoPorSegundo, double tempoSeg)
        {
            DateTime inicio = DateTime.Now;           // Obtém o momento atual
            DateTime fim = inicio.AddSeconds(tempoSeg); // Calcula o momento em que o processo de aceleração deve terminar

            while (inicio < fim)                      // Enquanto o tempo atual for menor que o tempo final
            {
                this.Velocidade += acrescimoPorSegundo; // Aumenta a velocidade do veículo
                Thread.Sleep(1000);                     // Aguarda 1 segundo antes de continuar

                // Exibe a velocidade atual do veículo no console
                Console.WriteLine($"Velocidade atual: {this.Velocidade:F2}");

                inicio = inicio.AddSeconds(1);         // Incrementa o tempo atual em 1 segundo
            }
        }

    }
}
