using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint6.Task1.V4.Lib;

namespace Tyuiu.LomakinVI.Sprint6.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double[] wait = { 7.83, 6.22, 6.36 };
            CollectionAssert.AreEqual(wait, ds.GetMassFunction(-5, -3));
        }
    }
}
