using MembrosClassesAbstratas;

public class Program
{
    private static void Main(string[] args)
    {
        //Veiculo v1 = new Veiculo(1000);
        Carro c1 = new Carro(1200);
        Aviao a1 = new Aviao(3000);
        ViajarParaCalifornia(a1);
    }

    static void ViajarParaCalifornia(Veiculo v)
    {
        v.Mover(10000);
    }
}