using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class MyTaskClass14
    {

        private double _x14;

        public MyTaskClass14(double x14)
        {
            _x14 = x14;
        }

        public void R()
        {
            Console.WriteLine($"R = {(Math.Sin(Math.Pow(Math.Pow(_x14, 2) + 4, 3)) + 4.3) / (Math.Pow(Math.Sin(Math.Pow(_x14, 4)), 3))}");
        }
    }
}
