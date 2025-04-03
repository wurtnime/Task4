using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class MyTaskClass13
    {

        private double _a13;
        private double _b13;
        private double _x13;

        public MyTaskClass13(double a13, double b13, double x13)
        {
            _a13 = a13;
            _b13 = b13;
            _x13 = x13;
        }

        public void R()
        {
            Console.WriteLine($"R = {(_a13) / (_x13 - _a13) + (Math.Pow(_b13, _x13) + Math.Pow(Math.Cos(_x13), 3)) / (Math.Pow(Math.Log(_a13), 3) + 4.5)}");
        }
    }
}
