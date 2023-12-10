using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.DevjatkovaAA.Sprint6.Task6.V5.Lib
{
    public class DataService : ISprint6Task6V5
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] word = line.Split(' ');
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i].Contains('l'))
                        {
                            resStr = resStr + " " + word[i];
                        }
                    }
                }
            }
            return resStr;
        }
    }
}
