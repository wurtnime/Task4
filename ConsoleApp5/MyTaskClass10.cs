using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass10
{

    private double _e10;
    private double _x10;
    private double _y10;

    public MyTaskClass10(double e10, double x10, double y10)
    {
        _e10 = e10;
        _x10 = x10;
        _y10 = y10;
    }

    public void U()
    {
        Console.WriteLine($"U = {(Math.Pow(Math.Pow(_e10, _x10), 3) + Math.Pow(Math.Cos(_x10 - 4), 2)) / (1 / Math.Tan(_x10) + 5.2 * _y10)}");
    }
}
