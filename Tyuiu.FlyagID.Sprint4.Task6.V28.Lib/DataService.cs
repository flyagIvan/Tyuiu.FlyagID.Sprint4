using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.FlyagID.Sprint4.Task6.V28.Lib
{
    public class DataService : ISprint4Task6V28
    {
        public string[] Calculate(string[] array)
        {
            return Array.FindAll(array, word => word.Length == 4);
        }
    }
}
