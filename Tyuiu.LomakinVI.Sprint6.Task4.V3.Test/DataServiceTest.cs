using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint6.Task4.V3.Lib;

namespace Tyuiu.LomakinVI.Sprint6.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double[] wait = { 4.34, 4.16, 3.71 };
            CollectionAssert.AreEqual(wait, ds.GetMassFunction(-5, -3));
        }
    }
}
