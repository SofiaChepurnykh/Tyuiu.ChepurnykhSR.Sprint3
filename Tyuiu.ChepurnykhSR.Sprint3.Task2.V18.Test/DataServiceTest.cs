using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChepurnykhSR.Sprint3.Task2.V18.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint3.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int StopValue = 14;

            double res = ds.GetMultiplySeries(value, startValue, StopValue);

            double wait = 0.277;
            Assert.AreEqual(wait, res);
        }
    }
}
