using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass5
{
    private double _x5;
    private double _z5;
    private double _y5;
    private double _c5;    

    public MyTaskClass5(double x5, double z5, double y5, double c5)
    {
        _x5 = x5;
        _z5 = z5;
        _y5 = y5;
        _c5 = c5;
    }

    public void G()
    {
        Console.WriteLine($"G = {(Math.Tan((Math.Pow(_x5, 4) - 6)) - Math.Pow(Math.Cos((_z5 + _x5 * _y5)), 3)) / (Math.Pow(Math.Cos(Math.Pow(_x5, 3) * Math.Pow(_c5, 2)), 4))}");
    }
}
