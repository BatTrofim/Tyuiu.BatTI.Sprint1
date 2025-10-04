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

            Console.WriteLine("Введите первую координату х: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите первую координату у: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите вторую координату х: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите вторую координату у: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите третью координату х: ");
            double x3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите третью координату у: ");
            double y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: площадь прямоульгоника                                       *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Площадь треугольника равна " + ds.TriangleArea(x1, y1, x2, y2, x3, y3) + "кв. см");
            Console.ReadKey();
        }
    }
}