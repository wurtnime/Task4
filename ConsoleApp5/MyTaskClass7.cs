using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass7
{

    private double _x7;
    private double _y7;
    private double _a7;

    public MyTaskClass7(double x7, double y7, double a7)
    {
        _x7 = x7;
        _y7 = y7;
        _a7 = a7;
    }

    public void D()
    {
        Console.WriteLine($"D = {(Math.Cos(Math.Pow(_x7, 3) + 6) - Math.Sin(_y7 - _a7)) / (Math.Log(Math.Pow(_x7, 4)) - 2 * Math.Pow(Math.Sin(_x7), 5))}"); ;
    }
}
