using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.LomakinVI.Sprint6.Task3.V30.Lib
{
    public class DataService : ISprint6Task3V30
    {
        public int[,] Calculate(int[,] matrix)
        {
            int colomns = matrix.GetLength(1);

            for (int i = 0; i < colomns; i++)
            {
                if (matrix[4, i] % 2 == 0)
                {
                    matrix[4, i] = 0;
                }
            }

            return matrix;
        }
    }
}
