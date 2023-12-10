using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint6.Task6.V5.Lib;
using System.IO;

namespace Tyuiu.DevjatkovaAA.Sprint6.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            var path = @"C:\DataSprint5\InPutFileTask6V5.txt";
            var res = ds.CollectTextFromFile(path);
            string wait = " ulzPXa sMLuPzlvneiTo tfouGdncXlJ";
            Assert.AreEqual(wait, res);
        }
    }
}
