using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhramovNA.Sprint6.Task2.V12.Lib
{
    public class DataService : ISprint6Task2V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((((2.0 * x + 6.0) / (Math.Cos(x) + x)) - 3.0), 2);

                if (Math.Cos(x) + x == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    valueArray[count] = y;
                }
                count++;
            }
            return valueArray;
        }
    }
}