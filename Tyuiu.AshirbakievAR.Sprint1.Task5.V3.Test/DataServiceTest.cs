using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint1.Task5.V3.Lib;

namespace Tyuiu.AshirbakievAR.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();
            Assert.AreEqual(9, ds.Calculate(130985));
        }
    }
}
