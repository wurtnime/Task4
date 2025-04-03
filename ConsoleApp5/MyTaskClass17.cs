using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class MyTaskClass17
    {

        private double _x17;
        private double _b17;
        private double _a17;
        private double _y17;

        public MyTaskClass17(double x17, double b17, double a17, double y17)
        {
            _x17 = x17;
            _b17 = b17;
            _a17 = a17;
            _y17 = y17;
        }

        public void T()
        {
            Console.WriteLine($"T = {Math.Sqrt(_x17 + _b17 - _a17) + Math.Log10(_y17) / Math.Atan((_b17 + _a17))}");
        }
    }
}
