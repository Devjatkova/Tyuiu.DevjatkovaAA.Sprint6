using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint6.TaskReview.V23.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint6.TaskReview.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            int n1 = 0;
            int n2 = 10;
            int k = 0;
            int l = 4;
            int r = 2;
            int[,] array = new int[5, 5] { { 2, 5, 1, 2, 4 },
                                           { 4, 25, 1, 4, 16 },
                                           { 1, 2, 4, 3, 1 },
                                           { 1, 4, 16, 9, 1 },
                                           { 9, 3, 6, 7, 1 } };
            int res = ds.GetMatrix(array, n1, n2, r, k, l);
            int wait = 8;
            Assert.AreEqual(wait, res);
        }
    }
}
