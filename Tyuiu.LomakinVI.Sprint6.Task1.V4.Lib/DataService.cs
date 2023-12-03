using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.LomakinVI.Sprint6.Task1.V4.Lib
{
    public class DataService : ISprint6Task1V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] myArray = new double[length];
            int i = 0;
            for (int x = startValue; x  <= stopValue; x ++)
            {
                double f = Math.Sin(x) / (x + 1.2) - Math.Sin(x) * 2 - 2 * x;
                myArray[i] = Math.Round(f, 2);
                i++;
            }

            return myArray;
        }
    }
}
