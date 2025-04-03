using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass27
{

    private double _a27;
    private double _x27;
    private double _c27;
    private double _y27;

    public MyTaskClass27(double a27, double x27, double c27, double y27)
    {
        _a27 = a27;
        _x27 = x27;
        _c27 = c27;
        _y27 = y27;
    }

    public void P()
    {
        Console.WriteLine($"P = {Math.Pow(_a27, 5) + Math.Acos((_a27 + Math.Pow(_x27, 3)) - Math.Pow(Math.Sin((_y27 - _c27)), 4) / Math.Pow(Math.Sin((_x27 + _y27)), 3) + Math.Abs(_x27 - _y27))}");
    }
}
