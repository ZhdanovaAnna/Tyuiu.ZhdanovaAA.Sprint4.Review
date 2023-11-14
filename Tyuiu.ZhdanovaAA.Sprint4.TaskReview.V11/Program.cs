using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhdanovaAA.Sprint4.TaskReview.V11.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint4.TaskReview.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int rows = 4, colums = 2;
            int[,] mtrx = new int[rows, colums];
            string str = "56789012";

            Console.Title = "Спринт #4 | Выполнила: Жданова А. А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Review                                                            *");
            Console.WriteLine("* Задание: TaskReview                                                     *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Жданова Анна Александровна                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр.                                      *");
            Console.WriteLine("* Преобразуйте ее в матрицу 4 на 2 и подсчитайте количество нечетных      *");
            Console.WriteLine("* чисел в матрице.                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int index = 0;

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Количество нечетных чисел в матрице = {ds.Calculate(rows, colums, str)}");
            Console.ReadKey();
        }
    }
}
