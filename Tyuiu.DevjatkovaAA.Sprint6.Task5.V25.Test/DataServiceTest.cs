using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint6.Task5.V25.Lib;
using System.IO;

namespace Tyuiu.DevjatkovaAA.Sprint6.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = $@"C:\Users\ДНС\source\repos\Tyuiu.DevjatkovaAA.Sprint6\Tyuiu.DevjatkovaAA.Sprint6.Task5.V25\bin\Debug\InPutFileTask5V25.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
