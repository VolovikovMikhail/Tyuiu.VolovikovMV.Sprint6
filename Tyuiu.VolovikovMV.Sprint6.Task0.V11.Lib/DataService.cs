using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VolovikovMV.Sprint6.Task0.V11.Lib
{
    public class DataService : ISprint6Task0V11
    {
        public double Calculate(int x)
        {
            return 1.6*Math.Pow(x,3) - 2.1*x*x + 7*x;
        }
    }
}
