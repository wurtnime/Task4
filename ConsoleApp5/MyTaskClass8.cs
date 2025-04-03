using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass8
{

    private double _a8;
    private double _y8;
    private double _c8;
    private double _x8;

    public MyTaskClass8(double a8, double y8, double c8, double x8)
    {
        _a8 = a8;
        _y8 = y8;
        _c8 = c8;
        _x8 = x8;
    }

    public void P()
    {
        Console.WriteLine($"P = {(Math.Pow(_a8, 5) + Math.Pow(Math.Sin(_y8 - _c8), 4)) / (Math.Pow(Math.Sin(_x8 + _y8), 3) + Math.Abs(_x8 - _y8))}");
    }
}
