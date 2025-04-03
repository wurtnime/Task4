using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass25
{

    private double _a25;
    private double _y25;
    private double _x25;

    public MyTaskClass25(double a25, double y25, double x25)

    {
        _a25 = a25;
        _y25 = y25;
        _x25 = x25;
          
    }

    public void J()
    {
        Console.WriteLine($"J = {Math.Pow(1 / Math.Tan(Math.Pow(_a25, 3)), 3 + Math.Pow(Math.Atan(_a25), 2)) / Math.Sqrt(Math.Pow(_y25, Math.Tan(_x25)))}");
    }
}
