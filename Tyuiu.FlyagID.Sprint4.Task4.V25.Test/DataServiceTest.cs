using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint4.Task4.V25.Lib;

namespace Tyuiu.FlyagID.Sprint4.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSumEvenElements()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 3, 2, 4, 4, 4 },
                { 2, 6, 6, 3, 2 },
                { 4, 2, 5, 5, 3 },
                { 5, 5, 6, 4, 3 },
                { 2, 6, 5, 6, 2 }
            };

            int result = ds.Calculate(matrix);

            int expected = 64;

            Assert.AreEqual(expected, result);
        }
    }
}
