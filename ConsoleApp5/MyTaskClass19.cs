using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class MyTaskClass19
    {
        private double _k19;
        private double _a19;
        private double _b19;
        private double _x19;
        private double _y19;

        public MyTaskClass19(double k19, double a19, double b19, double x19, double y19)
        {
            _k19 = k19;
            _a19 = a19;
            _b19 = b19;
            _x19 = x19;
            _y19 = y19;
        }

        public void D() 
        {
            Console.WriteLine($"D =  {_k19 - _a19 * Math.Sqrt(6) - Math.Cos((3 * _a19 * _b19)) / Math.Pow(Math.Sin((_a19 * Math.Asin(_x19) + Math.Log10(_y19))), 2)}");
        }
    }
}
