using System;

namespace Tabuada_
{
    class Program
    {
        static void Main(string[] args)
        {
             int num, tabuada, multiplicacao;
            Console.WriteLine("Digite um número Inteiro: ");
            num = int.Parse(Console.ReadLine());

            for(tabuada = 1; tabuada<=10; tabuada++){
                multiplicacao = num*tabuada;
                Console.WriteLine($" {num} * {tabuada} = {multiplicacao}");
            } 
        }
    }
}
