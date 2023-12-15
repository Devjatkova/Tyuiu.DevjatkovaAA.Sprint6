using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.DevjatkovaAA.Sprint6.TaskReview.V23.Lib
{
    public class DataService
    {
        public int GetMatrix(int[,] array, int k, int l, int c)
        {
            int res = 1;

            for (int j = k; j <= l; j++)
            {
                if (array[c, j] % 2 == 0)
                {
                    res *= array[c, j];
                }
            }
            if (res == 1)
            {
                res = 0;
            }

            return res;
        }
    }
}
