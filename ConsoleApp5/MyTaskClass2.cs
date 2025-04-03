using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass2
{

    private double _c2;
    private double _x2;
    private double _t2;

    public MyTaskClass2(double c2, double x2, double t2)
    {
        _c2 = c2;
        _x2 = x2;
        _t2 = t2;
    }

    public void L()
    {
        Console.WriteLine($"L = {Math.Pow(1 / Math.Tan(_c2), 2) + (2 * Math.Pow(_x2, 2) + 5) / (Math.Sqrt(_c2 + _t2))}");
    }
}
