﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint6.Task7.V4.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint6.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutFileTask7V4.csv";
            int[,] res = ds.GetMatrix(path);

            int[,] wait =
                { { 19, 8, -15, 7, 12, 1, 19, 13, -10, -16 },
                  { 17, 9, 9, 4, 4, 4, 18, -5, -11, 14 },
                  { -11, -20, -3, -8, -12, -12, -19, -20, -20, 20 },
                  { 2, -1, -7, -20, 1, -8, 18, -6, 11, 20 },
                  { -5, -15, 6, -11, 7, -18, 8, 7, 11, 19 },
                  { -19, -1, -8, 15, -6, 7, -14, 2, 15, -13 },
                  { -18, -14, -10, 9, 15, 19, 16, 7, -7, -9 },
                  { -11, 18, -2, 11, 0, -20, 12, 15, 15, -2 },
                  { -2, -11, -15, 1, 14, 0, 7, 8, -8, 20 },
                  { -8, 19, 9, 16, -12, -6, 10, 3, -19, -10 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
