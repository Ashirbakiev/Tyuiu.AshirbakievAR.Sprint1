using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint1.Task3.V11.Lib;

namespace Tyuiu.AshirbakievAR.Sprint1.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x1 = 3;
            double x2 = 7;
            double x3 = 0;
            double y1 = 2;
            double y2 = 5;
            double y3 = 0;
            Assert.AreEqual(0.5, ds.TriangleArea(x1,y1,x2,y2,x3,y3));
        }
    }
}
