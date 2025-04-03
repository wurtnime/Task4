using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class MyTaskClass16
    {

        private double _x16;
        private double _y16;
        private double _t16;

        public MyTaskClass16(double x16, double y16, double t16)
        {
            _x16 = x16;
            _y16 = y16;
            _t16 = t16;
        }

        public void P()
        {
            Console.WriteLine($"P = {Math.Pow(Math.Sin(_x16), 3) + Math.Log10((2 * _y16 + 3 * _y16)) / _t16 + Math.Sqrt(_x16)}");
        }
    }
}
