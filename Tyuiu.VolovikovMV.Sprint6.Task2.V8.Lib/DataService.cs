using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VolovikovMV.Sprint6.Task2.V8.Lib
{
    public class DataService : ISprint6Task2V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            int x = -5;
            for (int i = 0; i <= res.Length - 1; i++)
            {
                res[i] = Math.Round(Math.Cos(2 * x) + (Math.Sin(x) / (x + 2.5)) + 2 * x, 2);
                x++;
            }
            return res;
        }
    }
}
