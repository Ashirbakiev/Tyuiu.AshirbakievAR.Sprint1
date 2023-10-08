using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint1.Task7.V11.Lib;

namespace Tyuiu.AshirbakievAR.Sprint1.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.751, ds.Calculate(1, 2));
        }
    }
}
