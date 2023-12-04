using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.DevjatkovaAA.Sprint6.Task2.V15.Lib
{
    public class DataService : ISprint6Task2V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (3*x + 1.2 == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    y = Math.Round((2 * Math.Sin(x)) * Math.Pow(3 * x + 1.2, -1) + Math.Cos(x) - 7 * x * 2, 2);
                    valueArray[count] = y;
                }
                count++;
            }
            return valueArray;
        }
    }
}
