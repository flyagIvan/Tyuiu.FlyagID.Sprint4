using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint4.Task5.V1.Lib;

namespace Tyuiu.FlyagID.Sprint4.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckReplacePositiveElements()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { -1,  2,  0 },
                {  5, -3,  4 },
                {  0, -2,  7 }
            };

            int[,] result = ds.Calculate(matrix);

            int[,] expected =
            {
                { -1, 1, 0 },
                {  1, -3, 1 },
                {  0, -2, 1 }
            };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
