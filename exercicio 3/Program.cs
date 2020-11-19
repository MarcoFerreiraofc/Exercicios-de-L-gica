using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            float salario;
            string estado;

                    do{
                        Console.WriteLine("Qual o seu nome?");
                        nome = Console.ReadLine();

                        Console.WriteLine("Qual a sua idade?");
                        idade = int.Parse(Console.ReadLine());

                        Console.WriteLine("Qual é o seu salário?");
                        salario = float.Parse(Console.ReadLine());

                        Console.WriteLine("Qual é o seu estado civil?");
                        estado = Console.ReadLine();

                    if(nome == " " || idade < 0 || idade > 150 || salario > 0){
                        Console.WriteLine("Algo está errado.");
                    }
                    }
                   while(nome == " " || idade < 0 || idade > 150 || salario > 0);

                        Console.WriteLine("fim");
        
        }
    }
}
