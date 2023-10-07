using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.AshirbakievAR.Sprint1.Task2.V14.Lib;

namespace Tyuiu.AshirbakievAR.Sprint1.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ConvertKelvinToCelsiusTest()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-272, ds.ConvertKelvinToCelsius(1));
        }
    }
}
