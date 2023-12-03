using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VolovikovMV.Sprint6.Task2.V8.Lib;

namespace Tyuiu.VolovikovMV.Sprint6.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] wait = { -11.22, -8.65, -4.76, -6.47, -2.98, 1.00, 1.82, 3.55, 6.99, 7.74, 9.03 };
            double[] res = ds.GetMassFunction(-5, 5);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
