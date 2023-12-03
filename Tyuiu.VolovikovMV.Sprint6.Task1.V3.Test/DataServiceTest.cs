using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolovikovMV.Sprint6.Task1.V3.Lib;

namespace Tyuiu.VolovikovMV.Sprint6.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            int len = (stopValue - startValue) + 1;
            double[] wait = { 19.81, 16.79, 13.87, 10.98, 7.94, 3, 3.23, -0.45, -3.79, -6.97, -10 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
