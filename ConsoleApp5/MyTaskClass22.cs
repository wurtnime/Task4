using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass22
{

    private double _x22;
    private double _y22;

    public MyTaskClass22(double x22, double y22)
    {
        _x22 = x22;
        _y22 = y22;
    }

    public void F()
    {
        Console.WriteLine($"F = {Math.Cos((Math.Pow(_x22, 2) + 2) + 3.5 * Math.Pow(_x22, 2) + 1 / Math.Pow(Math.Cos(_y22), 2))}");
    }
}
