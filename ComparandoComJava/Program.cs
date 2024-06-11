using System; //ja é um tipo implicito, mesmo q eu remova, tudo como objeto e variavel ja é derivado dele

namespace ComparandoJava
{
    class Cjava
    {
        static void Main(string[] args)
        {
            string nome155 = "Pablo";
            string nomeDeTeste = "pablo";
            Console.WriteLine(nome155 == nomeDeTeste);
        }
    }
}