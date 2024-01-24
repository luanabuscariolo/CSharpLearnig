using System;

public class Pessoa {
    public string Nome;
    public int Idade;
    public char Genero;
    private bool Aprovado;

    public void MostrarInfos(){
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade} anos");
        Console.WriteLine($"Gênero: {(Genero == 'M' ? "Masculino" : "Feminino")}");
        Console.WriteLine($"Aprovado: {Aprovado}");
    }
}