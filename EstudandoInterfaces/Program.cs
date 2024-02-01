using EstudandoInterfaces;

internal class Program
{
    private static void Main(string[] args)
    {
        IAnimal bob = new Cachorro();
        //bob.Farejar(); //ERRO
        bob.EmitirSom(); //Au au au
        if (bob is Cachorro)
        {
            (bob as Cachorro).Farejar();
        }

        Cachorro bilu = new Cachorro();
        bilu.EmitirSom();
        bilu.Farejar();

        IAnimal max = new Cachorro();
        if (max is IQuadrupede)
        {
            (max as IQuadrupede).Andar();
        }
        if (max is Cachorro)
        {
            (max as Cachorro).Farejar();
        }


    }
}