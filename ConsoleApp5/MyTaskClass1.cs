using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass1
{
    private double _e1;
    private double _x1;
    private double _a1;
    private double _c1;

    public MyTaskClass1(double e1, double x1, double a1, double c1)
    {
        _e1 = e1;
        _x1 = x1;
        _a1 = a1;
        _c1 = c1;
    }

    public void L()
    {
        Console.WriteLine($"L = {(Math.Sqrt(Math.Pow(_e1, _x1) - Math.Pow(Math.Cos(Math.Pow(_x1, 2) * Math.Pow(_a1, 5)), 4) + Math.Pow(Math.Atan(_a1 - Math.Pow(_x1, 5)), 4) / (_e1 * Math.Sqrt(Math.Abs(_a1 + _x1 * Math.Pow(_c1, 4))))))}");
    }
}
