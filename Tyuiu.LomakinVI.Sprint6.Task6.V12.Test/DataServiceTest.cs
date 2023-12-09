using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint6.Task6.V12.Lib;

namespace Tyuiu.LomakinVI.Sprint6.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = $@"C:\Users\OneSmiLe\source\repos\Tyuiu.LomakinVI.Sprint6\Tyuiu.LomakinVI.Sprint6.Task6.V12\bin\Debug\InPutFileTask6V12.txt";
            string wait = "iKDOjtfsPmw ";
            Assert.AreEqual(wait, ds.CollectTextFromFile(path));
        }
    }
}
