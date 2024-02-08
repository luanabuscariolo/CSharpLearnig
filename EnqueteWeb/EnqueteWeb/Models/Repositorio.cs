using System.Collections.Generic;
namespace EnqueteWeb.Models
{
    public class Repositorio
    {
        private static List<Resposta> respostas = new List<Resposta>();
        public static IEnumerable<Resposta> Respostas { get { return respostas; } }

        public static void AdicionarResposta(Resposta resposta)
        {
            respostas.Add(resposta);
        }

        static Repositorio()
        {
            respostas.Add(new Resposta() { Nome = "Vitor", Email = "vitor@gmail.com", Sim = true });
            respostas.Add(new Resposta() { Nome = "Maria", Email = "maria@gmail.com", Sim = true });
            respostas.Add(new Resposta() { Nome = "José", Email = "jose@gmail.com", Sim = false });
            respostas.Add(new Resposta() { Nome = "Paulo", Email = "paulo@gmail.com", Sim = true });
            respostas.Add(new Resposta() { Nome = "Nazaré", Email = "nazare@gmail.com", Sim = false });
        }
    }
}
