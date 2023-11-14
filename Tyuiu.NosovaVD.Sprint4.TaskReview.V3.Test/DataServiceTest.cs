using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosovaVD.Sprint4.TaskReview.V3.Lib;
namespace Tyuiu.NosovaVD.Sprint4.TaskReview.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string str = "27182818";
            int n = 4;
            int m = 2;
            int res = ds.Calculate(n, m, str);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
