using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChepurnykhSR.Sprint3.Task6.V19.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint3.Task6.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит на экран результат                  *");
            Console.WriteLine("* данного нам задания                                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = 10;
            int stopValue = 15;

            Console.WriteLine("* старт шага: " + startValue);
            Console.WriteLine("* конец шага: " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumTheDivisors(startValue, stopValue));

            Console.ReadLine();
        }
    }
}
