namespace dotNET_Learning;

public class Program
{
    static void Main(string[] args)
    {
        //VAR: tipagem definida pelo valor da variavel
        TimeSpan horaAlmoçoSaida= new TimeSpan(13,30,00 );

        TimeSpan horaAlmoçoRetorno = new TimeSpan(14, 30, 00);

        TimeSpan ponto = horaAlmoçoRetorno - horaAlmoçoSaida;

        Console.WriteLine(ponto);

    }   
}
