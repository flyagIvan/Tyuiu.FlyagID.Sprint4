using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FlyagID.Sprint4.Task6.V28.Lib;

namespace Tyuiu.FlyagID.Sprint4.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckWordsWithLengthFour()
        {
            DataService ds = new DataService();
            string[] array = { "Река", "Озеро", "Болото", "Океан", "Лужа", "Море" };

            string[] result = ds.Calculate(array);

            string[] expected = { "Река", "Лужа", "Море" };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
