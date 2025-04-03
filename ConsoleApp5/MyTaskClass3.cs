using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass3
{
    private double _y3;
    private double _h3;

    public MyTaskClass3(double y3, double h3)
    {
        _y3 = y3;
        _h3 = h3;
    }

    public void A()
    {
        Console.WriteLine((Math.Tan(Math.Pow(_y3, 3) - Math.Pow(_h3, 4)) + Math.Pow(_h3, 2)) / (Math.Pow(Math.Sin(_h3 + _y3), 3)));
    }
}
