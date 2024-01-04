namespace dotNET_Learning;

public class Program
{
    static void Main(string[] args)
    {
        var meuArray = new int[3];
        
        meuArray[0] = 22;
        meuArray[2] = 30;
        meuArray[1] = 00;

        for (int i = 0; i < meuArray.Length; i++)
        {
            Console.WriteLine(meuArray[i]);
            
        }

        foreach (var item in meuArray)
        {
            Console.WriteLine(item);
        }
        
    }   
}