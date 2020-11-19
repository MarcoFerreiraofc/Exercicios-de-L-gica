using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
          {
                    Console.WriteLine("Digite um numero de sequências:");
                int numero;
                int anterior = 0, atual = 1, proximo = 1;
                int.Parse(Console.ReadLine());

            for(int contador = 1; contador <= numero; contador++){
                    proximo = anterior + atual;

                    Console.WriteLine("");
                
            }
        }
        }
    }
}
