using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass26
{

    private double _x26;
    private double _y26;
    private double _e26;
    private double _k26;

    public MyTaskClass26(double x26, double y26, double e26, double k26)

    {
        _x26 = x26;
        _y26 = y26;
        _e26 = e26;
        _k26 = k26;

    }

    public void U()
    {
        Console.WriteLine($"U = {Math.Log10((Math.Pow(_x26, 3)) + _y26) - Math.Pow(_y26, 4) / Math.Pow(_e26, _y26) + 5.4 * Math.Pow(_k26, 3)}");
    }
}
