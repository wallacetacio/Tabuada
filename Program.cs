using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int fator1;
            int fator2;
            int produto;

            Console.Write("Tabuada do número: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            fator1 = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();

            fator2 = 0;

            while (fator2 <= 10)
            {
                produto = fator1 * fator2;

                Console.WriteLine($"{fator1} x {fator2} = {produto} ");
                fator2 = fator2 + 1;                 
            }
        }
    }
}
