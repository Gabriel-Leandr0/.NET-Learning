namespace dotNET_Learning;

public class Program
{
    static void Main(string[] args)
    {
        var meuArray = new int[3];
        
        meuArray[0] = 22;
        meuArray[2] = 30;
        meuArray[1] = 00;

        Console.WriteLine(meuArray[0]);
        Console.WriteLine(meuArray[1]);
        Console.WriteLine(meuArray[2]);

        var products = new Product[2];

        products[0] = new Product("melancia",2);
        products[1] = new Product("laranja",1);

    }   
}

struct Product
{
    public Product(string nome, int numero)
    {
        Nome = nome;
        Numero = numero;
    }
    private string Nome;
    private int Numero;
}
