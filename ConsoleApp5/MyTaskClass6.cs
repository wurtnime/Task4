using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass6
{

    private double _x6;
    private double _y6;
    private double _a6;
    private double _b6;

    public MyTaskClass6(double x6, double y6, double a6, double b6)
    {
        _x6 = x6;
        _y6 = y6;
        _a6 = a6;
        _b6 = b6;
    }

    public void K()
    {
        Console.WriteLine($"K = {(Math.Sqrt(_x6 + _b6 - _a6) + Math.Log(_y6)) / (1 / Math.Tan(_b6 + _a6))}");
    }
}
