using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class MyTaskClass18
    {

        private double _y18;
        private double _t18;

        public MyTaskClass18(double y18, double t18)
        {
            _y18 = y18;
            _t18 = t18;
        }

        public void S()
        {
            Console.WriteLine($"S = {4.351 * Math.Pow(_y18, 3) + 2 * _t18 * Math.Log10(_t18)}");
        }
    }
}
