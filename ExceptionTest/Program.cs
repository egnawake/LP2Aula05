using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere um numero inteiro: ");
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Numero inserido: {i}");
            }
            catch (FormatException)
            {
                Console.WriteLine("O valor inserido nao e um numero inteiro");
            }
            catch (OverflowException)
            {
                Console.WriteLine("O valor inserido e um numero demasiado grande");
            }
            catch (Exception)
            {
                Console.WriteLine("Ocorreu um erro");
            }
        }
    }
}
