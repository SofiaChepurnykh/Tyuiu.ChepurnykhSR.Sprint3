using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChepurnykhSR.Sprint3.Task7.V21.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint3.Task7.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу которая выводит таблицу значений функции, произвести *");
            Console.WriteLine("* табулирование F(x) на заданном диапазоне [-5;5]                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт Шага=" + startValue);
            Console.WriteLine("Конец шага=" + stopValue);
            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+---------+-----------+");
            Console.WriteLine("|    X    |    f(x)   |");
            Console.WriteLine("+---------+-----------+");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}    |  {1,6:f2}   |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+---------+-----------+");
            Console.ReadKey();
        }
    }
}
