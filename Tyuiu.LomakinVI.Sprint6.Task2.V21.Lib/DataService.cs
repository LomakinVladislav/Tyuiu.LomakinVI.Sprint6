using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.LomakinVI.Sprint6.Task2.V21.Lib
{
    public class DataService : ISprint6Task2V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] myArray = new double[length];
            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double f;
                if (x + 2 == 0)
                {
                    f = 0;
                }
                else
                {
                    f = Math.Cos(x) + Math.Cos(x) / (x + 2) - 3 * x;
                }
                myArray[i] = Math.Round(f, 2);
                i++;
            }

            return myArray;
        }
    }
}
