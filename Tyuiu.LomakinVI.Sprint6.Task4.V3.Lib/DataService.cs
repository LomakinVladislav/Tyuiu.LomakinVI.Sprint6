using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.LomakinVI.Sprint6.Task4.V3.Lib
{
    public class DataService : ISprint6Task4V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] myArray = new double[length];
            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double f;
                if (Math.Sin(x) - 3 + x == 0)
                {
                    f = 0;  
                }
                else
                {
                    f = (3 * x - 1.5) / (Math.Sin(x) - 3 + x) + 2;
                }
                myArray[i] = Math.Round(f, 2);
                i++;
            }

            return myArray;
        }
    }
}
