using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass24
{

    private double _b24;
    private double _x24;
    private double _a24;
    private double _z24;

    public MyTaskClass24(double b24, double x24, double a24, double z24)
    {
        _b24 = b24;
        _x24 = x24;
        _a24 = a24;
        _z24 = z24;
    }

    public void f()
    {
        Console.WriteLine($"f = {(Math.Pow(Math.Cos(_b24), 7) * Math.Pow(_x24, 5)) - (Math.Pow(Math.Sin(_a24), 2) + Math.Cos(((Math.Pow(_x24, 3) + Math.Pow(_z24, 5) - Math.Pow(_a24, 2)) / Math.Pow(Math.Asin(_a24), 2)) + Math.Acos((Math.Pow(_x24, 7) - Math.Pow(_a24, 2)))))}");
    }
}
