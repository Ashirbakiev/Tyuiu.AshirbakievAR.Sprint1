using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.AshirbakievAR.Sprint1.Task3.V11.Lib;

namespace Tyuiu.AshirbakievAR.Sprint1.Task3.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Аширбакиев А. Р. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Аширбакиев Алмаз Ринатович | СМАРТб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x1;
            Console.WriteLine("Введите координату x1:");
            x1 = Convert.ToInt32(Console.ReadLine());
            double x2;
            Console.WriteLine("Введите координату x2:");
            x2 = Convert.ToInt32(Console.ReadLine());
            double x3;
            Console.WriteLine("Введите координату x3:");
            x3 = Convert.ToInt32(Console.ReadLine());
            double y1;
            Console.WriteLine("Введите координату y1:");
            y1 = Convert.ToInt32(Console.ReadLine());
            double y2;
            Console.WriteLine("Введите координату y2:");
            y2 = Convert.ToInt32(Console.ReadLine());
            double y3;
            Console.WriteLine("Введите координату y3:");
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.TriangleArea(x1,y1,x2,y2,x3,y3));

            Console.ReadKey();
        }
    }
}
