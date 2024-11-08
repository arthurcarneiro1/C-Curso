using System;

namespace curso{
    class Program{
        static void Main(string[]args){
            sbyte x = 100;
            byte n1 = 255; // byte vai de 0 - 255
            n1++; // o resultado e 0 porque ele chegou no numero maximo 
            int n2 = 1000;
            n2++;
            long n3= 200000L; // Colcar um L para informar um numero longo

            float n4 =1.5f; // ponto flutuante os famosos numeros com virgula
            double n5=1.5;

            char caractere = 'F'; // guarada um caractere
            char letra = '\u00A9'; // unicode
            bool valor = false; // boolean falso ou verdadeiro
 

            // pegar o maior e menor valor 
            float MaiorValor = float.MaxValue;
            float MenorValor = float.MinValue;


            Console.WriteLine(x);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(caractere);
            Console.WriteLine(valor);
            Console.WriteLine(letra);
            Console.WriteLine(MaiorValor);
            Console.WriteLine(MenorValor);
        }
    }
}