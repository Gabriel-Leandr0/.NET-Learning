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
        
        //int
        int numero = 0;
        
        //float
        float numero22 = 25.000f;
        var numero2 = 25.000f;
        
        //decimal
        var numero3 = 25.000m;
        decimal numero33 = 25.000m;
        
        //double
        double numero44 = 25.000;
        var numero4 = 25.000;
        //boolean
        
        bool status = false;
        //char
        char umaLetra = 'G';
        
        //object: podemos utilizar para definir uma tipagem complexa, podemos definir e alterar para qlq valor
        object naoSeiMinhaTipagem = 123;
        naoSeiMinhaTipagem = "ALO";
        
        //constante: tera o valor fixado do começo ao fim, por padrao utilizar letras maiusculas
        const string TEXTO_TESTE = "Testando";
    }   
}