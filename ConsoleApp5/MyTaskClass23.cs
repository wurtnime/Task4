using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass23
{

    private double _x23;
    private double _z23;
    private double _a23;
    private double _b23;

    public MyTaskClass23(double x23, double z23, double a23, double b23)
    {
        _x23 = x23;
        _z23 = z23;
        _a23 = a23;
        _b23 = b23;
    }

    public void F()
    {
        Console.WriteLine($"F = {Math.Sqrt(Math.Abs(_x23) + Math.Pow(Math.Cos(_x23), 3) + Math.Pow(_z23, 4)) / Math.Log10(_x23) - Math.Asin((_b23 * _x23 - _a23))}");
    }
}