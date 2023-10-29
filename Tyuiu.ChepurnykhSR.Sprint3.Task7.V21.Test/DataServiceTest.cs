using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChepurnykhSR.Sprint3.Task7.V21.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint3.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = (stopValue - startValue) + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 27.48;
            valueWaitArray[1] = 23.58;
            valueWaitArray[2] = 18.99;
            valueWaitArray[3] = 13.18;
            valueWaitArray[4] = 6.43;
            valueWaitArray[5] = -2.00;
            valueWaitArray[6] = 0.54;
            valueWaitArray[7] = -6.19;
            valueWaitArray[8] = -11.01;
            valueWaitArray[9] = -16.25;
            valueWaitArray[10] = -22.00;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);

        }
    }
}
