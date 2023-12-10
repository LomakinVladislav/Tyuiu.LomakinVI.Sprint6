using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LomakinVI.Sprint6.Task7.V27.Lib;

namespace Tyuiu.LomakinVI.Sprint6.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = $@"C:\Users\OneSmiLe\source\repos\Tyuiu.LomakinVI.Sprint6\Tyuiu.LomakinVI.Sprint6.Task7.V27\bin\Release\InPutFileTask7V27.csv";

            int[,] arrayWait = { { -6, 11, 3, 20, -10, 20, -15, 5, -19, -3 },
                                { -8, 7, 10, 20, -18, -16, -3, 15, 20, 20 },
                                { 13, 6, 1, 2, -20, -17, -9, -18, -5, 6},
                                { -13, 10, 1, -9, -1, -9, -20, 15, -7, 12},
                                { -12, 15, 18, 6, -11, 0, 5, 16, -9, 15},
                                { 14, -1, 8, -1, 0, -1, -1, -1, 4, 4},
                                { 13, -12, -1, -13, -1, 17, 19, 12, 14, 15},
                                { 2, -3, 1, 11, -7, -4, -15, -11, 3, 3},
                                { -13, 11, 8, -13, -17, -15, -18, 0, -3, 20},
                                { -11, -15, 8, 13, -3, 14, 18, -6, -14, -1} };

            CollectionAssert.AreEqual(arrayWait, ds.GetMatrix(path));
        }
    }
}
