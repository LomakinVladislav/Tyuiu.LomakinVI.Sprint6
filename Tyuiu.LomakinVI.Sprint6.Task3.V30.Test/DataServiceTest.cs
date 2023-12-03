using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint6.Task3.V30.Lib;

namespace Tyuiu.LomakinVI.Sprint6.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] array = { { -9, -19, -12, -16, -15 }, { -4, 18, 16, 15, 4 }, { 17, -4, -2, 4, -16 }, { -1, 2, 7, -12, 1 }, { -20, 14, 18, -13, -14 } };
            int[,] wait = { { -9, -19, -12, -16, -15 }, { -4, 18, 16, 15, 4 }, { 17, -4, -2, 4, -16 }, { -1, 2, 7, -12, 1 }, { 0, 0, 0, -13, 0 } };
            CollectionAssert.AreEqual(wait, ds.Calculate(array));
        }
    }
}
