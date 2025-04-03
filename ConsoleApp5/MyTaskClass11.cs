using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass11
{

    private double _e11;
    private double _y11;
    private double _x11;

    public MyTaskClass11(double e11, double y11, double x11)
    {
        _e11 = e11;
        _y11 = y11;
        _x11 = x11;
    }

    public void I()
    {
        Console.WriteLine($"I = {(2.33 * Math.Log(Math.Sqrt(1 + Math.Pow(Math.Cos(_y11), 2)))) / (Math.Pow(_e11, _y11) + Math.Pow(Math.Sin(_x11), 2))}");
    }
}
