using EstudandoInterfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        IAnimal bob = new Cachorro();
        //bob.Farejar(); //ERRO
        bob.EmitirSom(); //Au au au
        if (bob is Cachorro)
            (bob as Cachorro).Farejar();

        Cachorro bilu = new Cachorro();
        bilu.EmitirSom();
        bilu.Farejar();

        IQuadrupede pipoca = new Cachorro();
        Console.WriteLine("Pipoca:");
        pipoca.Andar(); //O cachorro está andando com as 4 patas.

        IAnimal lola = new Cachorro();
        Console.WriteLine("Lola:");
        lola.Andar(); //O cachorro está andando.

        //return; //ignora todo o código abaixo

        IAnimal max = new Cachorro();
        if (max is IQuadrupede)
            (max as IQuadrupede).Andar();

        if (max is Cachorro)
            (max as Cachorro).Farejar();

        Random random = new Random();

        List<IAnimal> animais = new List<IAnimal>();

        for (int i = 0; i < 100; i++)
        {
            int sorteio = random.Next();

            if (sorteio % 2 == 0)
                animais.Add(new Cachorro());
            else
                animais.Add(new Macaco());
        }

        foreach (var animal in animais)
        {
            Console.WriteLine("-------------------------------");
            if (animal is IQuadrupede)
                Console.WriteLine("Este animal é um quadrupede.");

            if (animal is IBipede)
                Console.WriteLine("Este animal é um bípede.");

            if (animal is Cachorro)
            {
                Console.WriteLine("Este animal é um cachorro.");
                (animal as Cachorro).Farejar();
            }

            if (animal is Macaco)
            {
                Console.WriteLine("Este animal é um macaco.");
                Macaco macaco = (animal as Macaco);
                macaco.Caminhar();
            }

        }
    }
}