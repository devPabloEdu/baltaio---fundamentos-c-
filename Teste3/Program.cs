﻿using System; //ja é um tipo implicito, mesmo q eu remova, tudo como objeto e variavel ja é derivado dele

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

            object quantidade; //pdoemos passar qualquer informação pra ele


            int? idadenula = null;
            Console.WriteLine(idadenula);

            float valor =25.8f;
            int outro = 25;
            valor = outro; //conversão implicita
            Console.WriteLine(valor);

            int inteiro = 100;
            uint inteiroSemSinal = (uint)inteiro; //conversão explicita
            Console.WriteLine(inteiro);
            Console.WriteLine(inteiroSemSinal);

            int inteirao = 100;
            float real = 25.8f;
            //real = inteirao;  // ele passou a valer 100.0f
            //inteirao = (int)real; //ele vai arredondar para 25 (ele arredonda p baixo)
            //string valorReal = real.ToString();
            //inteirao = int.Parse(valorReal); //o parse nao conseguiu usar
            inteirao = Convert.ToInt32(real); //ELE VAI CONVERTER PARA 26
            //Console.WriteLine(valorReal);
            Console.WriteLine(inteirao);
            Console.WriteLine(Convert.ToBoolean(1));
            

            Console.WriteLine(texto2);

            Console.WriteLine(numeroquebtado);

            //teste
            // string x = "1234e5";
            // if (x != "1234E5"){
            //     Console.WriteLine("teste correto");
            // } else {
            //     Console.WriteLine("incorreto");
            // }

            int x = 2;
            //x = 2 + 2 * 2;
            x += 3; // x = x + 3;
            Console.WriteLine(x);

            //teste
            // int y = 4;
            // bool negando = !( y < 3 ); //vai retornar true, pq inverte na vdd y é maior q trres
            // Console.WriteLine(negando);


            if(25 != 32)
            {
                Console.WriteLine("é diferente");
            } else {
                Console.WriteLine("é igual");
            }
            Console.WriteLine("finalizou o programa");

            //outro exemplo de if. else if e else
            int idade = 16;
            const int maioridade =  18;

            Console.WriteLine("--------------");
            if (idade >= maioridade){
                Console.WriteLine("voce pode dirigir");
            } else if ( idade <= 15 ) {
                Console.WriteLine("voce ainda é um bebe");
            } else {
                Console.WriteLine("voce esta quase la!!");
            }
            Console.WriteLine("-------------");
        }
    }
    
}
