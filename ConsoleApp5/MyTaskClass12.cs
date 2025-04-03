using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass12
{

    private double _y12;
    private double _x12;
    private double _a12;

    public MyTaskClass12(double y12, double x12, double a12)
    {
        _y12 = y12;
        _x12 = x12;
        _a12 = a12;
    }

    public void G()
    {
        Console.WriteLine($"G = {(Math.Pow(Math.Cos(Math.Abs(_y12 + _x12)), 3) - (_x12 + _y12)) / ((1 / Math.Pow(Math.Tan(_x12 + _a12), 4)) * (Math.Pow(_x12, 5)))}");
    }
}
