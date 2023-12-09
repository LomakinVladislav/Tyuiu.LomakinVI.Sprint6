using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.LomakinVI.Sprint6.Task6.V12.Lib
{
    public class DataService : ISprint6Task6V12
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string[] allWordsInLine;
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    allWordsInLine = line.Split();
                    foreach (string item in allWordsInLine)
                    {
                        if (item.Contains('w'))
                        {
                            resStr += item + " ";
                        }
                    }
                }
            }

            return resStr;
        }
    }
}
