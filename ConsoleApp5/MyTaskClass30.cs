using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass30
{

    private double _e30;
    private double _x30;

    public MyTaskClass30(double e30, double x30)
    {
        _e30 = e30;
        _x30 = x30;
    }

    public void K()
    {
        Console.WriteLine($"K = {Math.Sqrt(Math.Pow((3 + _x30), 6) - Math.Log10(_x30) / Math.Pow(_e30, 0) + Math.Asin(6) * Math.Pow(_x30, 2))}");
    }
}
