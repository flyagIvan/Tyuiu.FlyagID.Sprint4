using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint4.Task7.V24.Lib;

namespace Tyuiu.FlyagID.Sprint4.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckEvenDigitsProduct()
        {
            DataService ds = new DataService();

            int n = 5;
            int m = 3;
            string value = "651827384219648";

            int result = ds.Calculate(n, m, value);

            int expected = 1179648;

            Assert.AreEqual(expected, result);
        }
    }
}
