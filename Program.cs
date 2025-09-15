namespace ExemploHeranca;

internal class Program
{
    static void Main(string[] args)
    {
        Eletronico celular = new(10, "A10", "Celular top", 2569.87M, 127, 12);
        Console.WriteLine(celular.ToString());        
    }
}
