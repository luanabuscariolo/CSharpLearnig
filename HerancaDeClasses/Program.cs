namespace HerancaDeClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Aviao a1 = new Aviao(3200, 4, 16, 12, 100);
            a1.Voar(1000);
            //Console.WriteLine($"{a1.Densidade}");
            //Barco b1 = new Barco(1200, 2.5, 4, 12, 100);
            //b1.Navegar(200);
        }
    }

}