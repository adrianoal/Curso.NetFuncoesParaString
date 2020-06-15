using System;

namespace FuncoesStringAula89
{
    class Program
    {
        static void Main(string[] args)
        {

            string original = "     abcde FGHIJ ABC abc DEFG    ";
            string s1 = original.ToUpper();                  // caixa alta
            string s2 = original.ToLower();                  // caixa baixa
            string s3 = original.Trim();                     // apaga os espacos em branco na frente e atras

            int n1 = original.IndexOf("bc");                 // procurar alguma coisa nessa posicao bc
            int n2 = original.LastIndexOf("bc");             // procurar alguma coisa nessa posicao bc

            string s4 = original.Substring(6);               // recortar uma string
            string s5 = original.Substring(6, 4);            // recortar uma string, outra forma...

            string s6 = original.Replace('a', 'x');           // substituir uma parte por outra(tocar o "a por x")
            string s7 = original.Replace("abcde", "xxxxx");  // substituir uma string pela outra

            bool b1 = String.IsNullOrEmpty(original);        // testar se a variavel e vazia
            bool b2 = String.IsNullOrWhiteSpace(original);   // testa null ou espaco em branco

            Console.WriteLine("Original: " + original);
            Console.WriteLine();

            Console.WriteLine("ToUpper: " + s1);
            Console.WriteLine();

            Console.WriteLine("ToLower: " + s2);
            Console.WriteLine();


            Console.WriteLine("Trim: " + s3);
            Console.WriteLine();

            Console.WriteLine("IndexOf: " + n1);
            Console.WriteLine();

            Console.WriteLine("LastIndexOf: " + n2);
            Console.WriteLine();

            Console.WriteLine("Substring: " + s4);
            Console.WriteLine();

            Console.WriteLine("Substring: " + s5);
            Console.WriteLine();

            Console.WriteLine("Replace, troca de uma caracter por outro: " + s6);
            Console.WriteLine();

            Console.WriteLine("Replace, troca de uma string por outra: " + s7);
            Console.WriteLine();

            Console.WriteLine("String.IsNullOrEmpty: Verifica se a string e vazia ou null: " + b1);
            Console.WriteLine();

            Console.WriteLine("String.IsNullOrWhiteSpace: Testa null ou espaco em branco " + b2);
            Console.WriteLine();


        }
    }
}
