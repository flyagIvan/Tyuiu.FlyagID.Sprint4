using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint4.Task1.V18.Lib;

namespace Tyuiu.FlyagID.Sprint4.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSumOddElements()
        {
            DataService ds = new DataService();

            int[] array =
            {
                7, 6, 9, 8, 9, 7, 4, 7,
                8, 5, 6, 3, 9, 7, 9, 7
            };

            int result = ds.Calculate(array);

            int expected = 79;

            Assert.AreEqual(expected, result);
        }
    }
}
