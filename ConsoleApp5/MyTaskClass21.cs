using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class MyTaskClass21
    {
        private double _z21;
        private double _x21;
        private double _e21;
        private double _a21;

        public MyTaskClass21(double z21, double x21, double e21, double a21)
        { 
            _z21 = z21;
            _x21 = x21;
            _e21 = e21;
            _a21 = a21;

        }

        public void N()
        {
            Console.WriteLine($"N =  {Math.Pow(Math.Sqrt(_z21 + Math.Sqrt(_z21 * _x21)), 1 / 5) / Math.Pow(_e21, _x21) + Math.Pow(_a21, 5) * Math.Atan(_x21)}");
        }
    }
}
