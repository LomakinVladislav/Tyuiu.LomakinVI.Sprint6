using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint6.Task2.V21.Lib;

namespace Tyuiu.LomakinVI.Sprint6.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFunc()
        {
            DataService ds = new DataService();
            double[] wait = { 15.19, 11.67, 9 };
            CollectionAssert.AreEqual(wait, ds.GetMassFunction(-5, -3));
        }
    }
}
