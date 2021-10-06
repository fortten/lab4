using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Найти квадрат введенного целого числа используя формулу: n^2 = 1 + 3 + 5 + ... + (2*n-1). Вывести квадраты всех чисел от 1 до n.
            #region Инициализация переменных
            int n, sq = 0;
            Console.WriteLine("Введите целое число больше 0");
            n = Convert.ToInt32(Console.ReadLine());
            #endregion
            #region Цикл вычислений
            for (int i = 1; i <= n; i++)
            {
                sq += 2 * i - 1;
                Console.WriteLine("Квадрат числа {0} равен {1}", i, sq);
            }
            #endregion
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
