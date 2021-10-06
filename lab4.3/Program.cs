using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C (без наложений). Найти количество квадратов.
            #region инициализация переменных
            double a, b, c, sum1, sum2;
            int countA = 0;
            int countB = 0;
            sum1 = 0;
            sum2 = 0;
            Console.WriteLine("Введите сторону прямоугольника А");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону прямоугольника B");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата С");
            c = Convert.ToDouble(Console.ReadLine());
            #endregion
            if ((a >= c) && (b >= c))
            {
                while (sum1 < a)
                {
                    sum1 += c;

                    if (sum1 > a)
                        break;

                    countA++;
                }
                while (sum2 < b)
                {
                    sum2 += c;

                    if (sum2 > b)
                        break;

                    countB += countA;
                }
                Console.WriteLine("Количество квадратов, которые поместятся в прямоугольник = {0}", countB);
            }
            else
            {
                Console.WriteLine("Ни один квадрат в прямоугольник не поместится");
            }
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
