using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.FlyagID.Sprint4.Task7.V24.Lib
{
    public class DataService : ISprint4Task7V24
    {
        public int Calculate(int n, int m, string value)
        {
            int product = 1;
            bool hasEven = false;

            for (int i = 0; i < value.Length; i++)
            {
                int digit = value[i] - '0';

                if (digit % 2 == 0)
                {
                    product *= digit;
                    hasEven = true;
                }
            }

            return hasEven ? product : 0;
        }
    }
}
