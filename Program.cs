namespace dotNET_Learning;

public class Program
{
    static void Main(string[] args)
    {
        var meuArray = new int[3];

        try
        {
            meuArray[0] = 22;
            meuArray[2] = 30;
            meuArray[1] = 00;
            meuArray[3] = 99;
        }
        //Do mais especifico
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(e);
            Console.WriteLine("Array estourado");
        }
        //Ao mais generico
        catch (Exception e)
        {
            Console.WriteLine("ops deu esse erro ai: "+e);
        }
        

        
    }   
}