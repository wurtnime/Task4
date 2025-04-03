using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass29
{

    private double _y29;
    private double _d29;
    private double _e29;
    private double _x29;

    public MyTaskClass29(double y29, double d29, double e29, double x29)
    {
        _y29 = y29;
        _d29 = d29;
        _e29 = e29;
        _x29 = x29;
    }

    public void R()
    {
        Console.WriteLine($"R = {Math.Pow(Math.Cos(_y29), 2) + 2.4 * _d29 / Math.Pow(_e29, _y29) + Math.Log10((Math.Pow(Math.Sin(_x29), 2) + 6))}");
    }
}
