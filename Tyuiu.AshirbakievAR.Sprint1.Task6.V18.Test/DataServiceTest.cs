using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint1.Task6.V18.Lib;

namespace Tyuiu.AshirbakievAR.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckNumberTest()
        {
            DataService ds = new DataService();
            string a = "123";
            Assert.AreEqual(true, ds.CheckNumber(a));
        }
    }
}
