using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass4
{
    private double _y4;
    private double _x4;

    public MyTaskClass4(double y4, double x4)
    {
        _y4 = y4;
        _x4 = x4;
    }

    public void F()
    {
        Console.WriteLine($"F = {(Math.Sqrt(Math.Pow(2 + _y4, 2) + Math.Pow(Math.Sqrt(Math.Sin(_y4 + 5)), 1 / 7))) / (Math.Log(_x4 + 1) - Math.Pow(_y4, 3))}");
    }
}
