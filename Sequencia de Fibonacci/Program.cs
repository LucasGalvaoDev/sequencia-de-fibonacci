using System;
using System.Collections.Generic;

namespace Sequencia_de_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## BEM VINDO A SEQUÊNCIA DE FIBONACCI ##");
            Console.WriteLine("## POR FAVOR DIGITE A POSIÇÃO QUE VOCÊ DESEJA VERIFICAR O NÚMERO ##");

            try
            {
                string valorDigitado = Console.ReadLine();
                int numeroDigitado = int.Parse(valorDigitado);
          
                int num1 = 0;
                int fib = 1;

                while(fib < numeroDigitado)
                {
                    num1 += fib;
                    fib += num1;
                }

                    Console.WriteLine("O número que está na posição desejada é o {0}", fib);
                    Console.WriteLine("Tecle qualquer botão do teclado para fechar");
                    Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine($"Não foi possível processar o que foi digitado. Por favor tente novamente. Erro: {e}");
            }
        }
    }
}
