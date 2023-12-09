using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint6.Task5.V13.Lib;

namespace Tyuiu.LomakinVI.Sprint6.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = $@"C:\Users\OneSmiLe\source\repos\Tyuiu.LomakinVI.Sprint6\Tyuiu.LomakinVI.Sprint6.Task5.V13\bin\Debug\InPutFileTask5V13.txt";
            double[] wait = { -13, -19, -9.82, -9.71, 3.36, 0.48, 4.13, -0.11, -17.36, -12, -12.35 };
            CollectionAssert.AreEqual(wait, ds.LoadFromDataFile(path));
        }
    }
}
