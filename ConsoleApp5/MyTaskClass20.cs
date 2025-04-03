using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class MyTaskClass20
    {
        private double _y20;
        private double _x20;
        private double _b20;
        private double _c20;
        private double _a20;

        public MyTaskClass20(double y20, double x20, double b20, double c20, double a20)
        {
            _y20 = y20;
            _x20 = x20;
            _b20 = b20;
            _c20 = c20;
            _a20 = a20;
                
        }

        public void U()
        {
            Console.WriteLine($"U =  {Math.Pow(Math.Tan(_y20), 3) + Math.Pow(Math.Sin(_x20), 5) * Math.Sqrt(_b20 - _c20) / Math.Sqrt(_a20 - _b20 + _c20)}");
        }
    }
}
