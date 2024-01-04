namespace dotNET_Learning;

public class Program
{
    static void Main(string[] args)
    {
        //VAR: tipagem definida pelo valor da variavel
        var nome = "Gabriel";
        
        //Strings
        String nome2 = "Neemias";
        string nome3 = "Diogo";

        Console.WriteLine($"Bom dia {nome2}!");
        Console.WriteLine(nome2.Contains("neemias",StringComparison.OrdinalIgnoreCase));
        Console.WriteLine(nome2.StartsWith("N"));
        Console.WriteLine(nome2.Equals("neemias"));
    }   
}

struct Product
{
    public Product(int id, string name, float price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
    
    public int Id;
    public string Name;
    public float Price;
}