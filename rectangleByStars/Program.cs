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
            Console.WriteLine("Введите число (ширина прямоугольника): ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число (высота прямоугольника): ");
            int height = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
