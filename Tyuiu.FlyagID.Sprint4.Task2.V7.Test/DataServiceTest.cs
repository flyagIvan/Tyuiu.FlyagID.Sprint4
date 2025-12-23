using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint4.Task2.V7.Lib;

namespace Tyuiu.FlyagID.Sprint4.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSumEvenElements()
        {
            DataService ds = new DataService();

            int[] array = { 4, 5, 6, 7, 8, 9, 4, 6, 5, 7, 8, 9 };

            int result = ds.Calculate(array);

   
            int expected = 36;

            Assert.AreEqual(expected, result);
        }
    }
}
