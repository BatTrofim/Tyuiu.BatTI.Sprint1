using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BatTI.Sprint1.Task1.V21.Lib;

namespace Tyuiu.BatTI.Sprint1.Task1.V21
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
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #21                                                              *");
            Console.WriteLine("* Выполнил: Бат Трофим Иванович | ПИНб-25-1                                *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* вычисляет результат по формуле (x * y) / (3 + y) и печатает его на экране*");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();



        }
    }
}