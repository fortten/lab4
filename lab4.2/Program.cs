using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сравнение количества введенных положительных и отрицательных чисел
            #region Инициализация переменных
            int n, count1, count2; // count1 - количество пложительных чисел; count2 - количество отрицательных чисел
            count1 = count2 = 0;
            #endregion
            Console.WriteLine("Введите последовательность чисел. Для окончания последовательности введите 0");
            #region Цикл вычислений
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    count1++;
                }
                else if (n != 0)
                {
                    count2++;
                }
            } while (n != 0);
            #endregion
            #region Вывод результата
            if (count1 > count2)
            {
                Console.WriteLine("Количество положительных чисел больше = {0}", count1);
            }
            else if (count1 < count2)
            {
                Console.WriteLine("Количество отрицательных чисел больше = {0}", count2);
            }
            else
            {
                Console.WriteLine("Количество положительных и отрицательных одинаково = {0}", count2);
            }
            #endregion
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
