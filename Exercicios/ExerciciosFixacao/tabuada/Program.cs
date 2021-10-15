using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTabuada do 1 \n");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"\ntabuada do {i + 0}\n ");
                for (var f = 0; f <=9; f++)
                {
                    Console.WriteLine(i + " * " + f + "=" + i * f);
                }
            } 
  
        }
    }
}
