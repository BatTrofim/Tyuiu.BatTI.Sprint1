using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BatTI.Sprint1.Task3.V11.Lib;

namespace Tyuiu.BatTI.Sprint1.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Бат Т.И. | ПИНб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                         *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #11                                                              *");
            Console.WriteLine("* Выполнил: Бат Трофим Иванович | ПИНб-25-1                                *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.              *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            double x1 = -2.0;
            double y1 = 5.0;
            double x2 = 1.0;
            double y2 = 7.0;
            double x3 = 5.0;
            double y3 = -3.0;

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: площадь прямоульгоника                                       *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Площадь треугольника: " + ds.TriangleArea(x1, y1, x2, y2, x3, y3) + " кв. см");
            Console.ReadKey();
        }
    }
}