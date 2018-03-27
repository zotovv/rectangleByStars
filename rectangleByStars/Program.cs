using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangleByStars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int z = 1;
            int buf = y;

            // прямоугольник

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            //Прямоугольный треугольник

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Равнобедренный треугольник

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < z; k++)
                {
                    Console.Write("*");
                }

                y -= 1;
                z += 2; 

                Console.WriteLine();
            }

            z = 1;

            Console.WriteLine();

            //Ромб

            for (int i = 0; i < x+ x + 1; i++)
            {
                if (i < x)
                {
                    for (int j = 0; j < buf; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write("*");
                    }

                    buf -= 1;
                    z += 2;
                }
                else
                {
                    for (int j = 0; j < buf; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 0; k < z; k++)
                    {
                        Console.Write("*");
                    }

                    buf += 1;
                    z -= 2;
                }
                Console.WriteLine();
            }


            // Delay
            Console.ReadKey();
        }
    }
}
