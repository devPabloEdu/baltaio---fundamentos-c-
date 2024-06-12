using System; //ja é um tipo implicito, mesmo q eu remova, tudo como objeto e variavel ja é derivado dele

namespace TabuadaEmCsharp
{
    class Tabuada
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(" Escreva um número abaixo: ");
            int  numeroEscolhidoTexto = int.Parse(Console.ReadLine()); //nao aceita parametros
            

                for(int i = 1; i <=10; i++) {
                    Console.WriteLine($"{numeroEscolhidoTexto} x {i} = {numeroEscolhidoTexto * i}"); 
            }
        }
    }
}