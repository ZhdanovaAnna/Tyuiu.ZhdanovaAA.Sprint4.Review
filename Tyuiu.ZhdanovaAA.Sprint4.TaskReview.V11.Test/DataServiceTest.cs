using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint4.TaskReview.V11.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint4.TaskReview.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int rows = 4, colums = 2;
            int[,] mtrx = new int[rows, colums];
            string str = "56789012";

            int res = ds.Calculate(rows, colums, str);

            Assert.AreEqual(4, res);
        }
    }
}
