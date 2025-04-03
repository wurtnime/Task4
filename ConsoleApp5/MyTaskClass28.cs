using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass28
{

    private double _x28;
    private double _z28;
    private double _y28;
    private double _c28;

    public MyTaskClass28(double x28, double z28, double t28, double c28)
    {
        _x28 = x28;
        _z28 = z28;
        _y28 = t28;
        _c28 = c28;
    }

    public void G()
    {
        Console.WriteLine($"G = {Math.Tan((Math.Pow(_x28, 4) - 6)) - Math.Pow(Math.Cos((_z28 + Math.Pow(_x28, 3) * _y28)), 3) / Math.Pow(Math.Cos(Math.Pow(_x28, 3) * Math.Pow(_c28, 2)), 2)}");
    }
}
