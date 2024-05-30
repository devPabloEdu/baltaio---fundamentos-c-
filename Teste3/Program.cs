using System; //ja é um tipo implicito, mesmo q eu remova, tudo como objeto e variavel ja é derivado dele

namespace Meuapp
{
    class Teste3
    {
        static void Main(string[] args)
        {

            int idade2 = 25; //o mais comum é ultilizarmos o int.

             float salario = 2.500f; //precisamos colocar um f no final do numero para definirmos ele como float

            decimal salarioAnual = 25.000m; //para definirmos um decimal devemos colocar o m no final

            double salarioTrimestral = 25.000;// o double n precisa pq ele ja é o tipo padrao de um numero com ponto flutuante

            double numeroquebtado = 2500.10; 

            sbyte meuSbyte = -125;

            byte meuByte = 127;

            bool usuarioJaCadastrado = false;

            bool pagamentoRecebido = true;

            char primeiraletra = 'c';

            
            string texto2 = "teste3";


            var idade3 = 25; //var atribuido como um int

            var nomecompleto = "pablo eduardo"; // var atribuido como uma string


            Console.WriteLine(texto2);

            Console.WriteLine(numeroquebtado);
        }
    }
    
}
