using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint1.Task4.V26.Lib;

namespace Tyuiu.AshirbakievAR.Sprint1.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.0,ds.Calculate(0,0));
        }
    }
}
