using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChepurnykhSR.Sprint3.Task6.V19.Lib;

namespace Tyuiu.ChepurnykhSR.Sprint3.Task6.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 10;
            int stopValue = 15;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 45;

            Assert.AreEqual(wait, res);
        }
    }
}
