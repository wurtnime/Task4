using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class MyTaskClass15
    {

        private double _m15;
        private double _y15;

        public MyTaskClass15(double m15, double y15)
        {
            _m15 = m15;
            _y15 = y15;
        }

        public void N()
        {
            Console.WriteLine($"N = {(Math.Pow(_m15, 2) + 2.8 * _m15 + 0.355) / (Math.Cos(2 * _y15) + 3.6)}");
        }
    }
}
