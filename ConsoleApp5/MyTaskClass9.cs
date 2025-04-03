using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10;
public class MyTaskClass9
{
    private double _y9;
    private double _x9;
    private double _d9;
    private double _e9;

    public MyTaskClass9(double y9, double x9, double d9, double e9)
    {
        _y9 = y9;
        _x9 = x9;
        _d9 = d9;
        _e9 = e9;
    }

    public void R()
    {
        Console.WriteLine($"R = {(Math.Pow(Math.Cos(_y9), 3) + Math.Pow(2, _x9) * _d9) / (Math.Pow(_e9, _y9) + Math.Log(Math.Pow(Math.Sin(_x9), 2)) + 7.4)}");
    }
}
