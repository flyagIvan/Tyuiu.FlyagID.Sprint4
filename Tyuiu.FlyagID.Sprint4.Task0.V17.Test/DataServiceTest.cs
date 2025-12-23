using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint4.Task0.V17.Lib;

namespace Tyuiu.FlyagID.Sprint4.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] array = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            int result = ds.GetSumEvenArrEl(array);

            int expected = 34;

            Assert.AreEqual(expected, result);
        }
    }
}
