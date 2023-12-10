using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.LomakinVI.Sprint6.Task7.V27.Lib
{
    public class DataService : ISprint6Task7V27
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            for (int c = 0; c < columns; c++)
            {
                if (arrayValues[5, c] < 0)
                {
                    arrayValues[5, c] = -1;
                }
            }

            return arrayValues;
        }
    }
}
