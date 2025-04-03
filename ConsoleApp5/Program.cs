using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        /// Пол Палыча
     

        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №3");
            Console.WriteLine("1-30");
            int sw = Convert.ToInt32(Console.ReadLine());


            switch (sw)
            {
                case 1:
                    double e1, x1, a1, c1;

                    Console.WriteLine("Введите значение e");
                    e1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение x");
                    x1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение a");
                    a1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение c");
                    c1 = Convert.ToInt32(Console.ReadLine());

                    
                    MyTaskClass1 myTaskClass1 = new MyTaskClass1(e1, x1, a1, c1);
                    myTaskClass1.L();
                    break;

                case 2:
                    double c2, x2, t2;

                    Console.WriteLine("Введите значение c");
                    c2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение x");
                    x2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение t");
                    t2 = Convert.ToInt32(Console.ReadLine());

                    
                    MyTaskClass2 myTaskClass2 = new MyTaskClass2(c2, x2, t2);
                    myTaskClass2.L();
                    break;

                case 3:
                    double y3, h3;

                    Console.WriteLine("Введите значение y");
                    y3 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение h");
                    h3 = Convert.ToInt32(Console.ReadLine());

                    
                    MyTaskClass3 myTaskClass3 = new MyTaskClass3(y3, h3);
                    myTaskClass3.A();
                    break;

                case 4:
                    double y4, x4;

                    Console.WriteLine("Введите значение y");
                    y4 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение x");
                    x4 = Convert.ToInt32(Console.ReadLine());

                    
                    MyTaskClass4 myTaskClass4 = new MyTaskClass4(y4, x4);
                    myTaskClass4.F();
                    break;

                case 5:
                    double x5, z5, y5, c5;

                    Console.WriteLine("Введите значение x");
                    x5 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение z");
                    z5 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y5 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение c");
                    c5 = Convert.ToInt32(Console.ReadLine());

                    );
                    MyTaskClass5 myTaskClass5 = new MyTaskClass5(x5, z5, y5, c5);
                    myTaskClass5.G();
                    break;

                case 6:
                    double x6, y6, a6, b6;

                    Console.WriteLine("Введите значение x");
                    x6 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y6 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение a");
                    a6 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение b");
                    b6 = Convert.ToInt32(Console.ReadLine());

                    
                    MyTaskClass6 myTaskClass6 = new MyTaskClass6(x6 , y6, a6, b6);
                    myTaskClass6.K();
                    break;

                case 7:
                    double x7, y7, a7;

                    Console.WriteLine("Введите значение x");
                    x7 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y7 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение a");
                    a7 = Convert.ToInt32(Console.ReadLine());

                    
                    MyTaskClass7 myTaskClass7 = new MyTaskClass7(x7, y7, a7);
                    myTaskClass7.D();
                    break;

                case 8:
                    double a8, y8, c8, x8;

                    Console.WriteLine("Введите значение a");
                    a8 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y8 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение c");
                    c8 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение x");
                    x8 = Convert.ToInt32(Console.ReadLine());

                    
                    MyTaskClass8 myTaskClass8 = new MyTaskClass8(x8, y8, c8, x8);
                    myTaskClass8.P();
                    break;

                case 9:
                    double y9, x9, d9, e9;

                    Console.WriteLine("Введите значение y");
                    y9 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение x");
                    x9 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение d");
                    d9 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение e");
                    e9 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"R = {(Math.Pow(Math.Cos(y9), 3) + Math.Pow(2, x9) * d9) / (Math.Pow(e9, y9) + Math.Log(Math.Pow(Math.Sin(x9), 2)) + 7.4)}");
                    MyTaskClass9 myTaskClass9 = new MyTaskClass9(y9, x9, d9, e9);
                    myTaskClass9.R();
                    break;

                case 10:
                    double e10, x10, y10;

                    Console.WriteLine("Введите значение e");
                    e10 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение x");
                    x10 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y10 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"U = {(Math.Pow(Math.Pow(e10, x10), 3) + Math.Pow(Math.Cos(x10 - 4), 2)) / (1 / Math.Tan(x10) + 5.2 * y10)}");
                    MyTaskClass10 myTaskClass10 = new MyTaskClass10(e10, x10, y10);
                    myTaskClass10.U();
                    break;

                case 11:
                    double e11, y11, x11;

                    Console.WriteLine("Введите значение e");
                    e11 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y11 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение x");
                    x11 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"I = {(2.33 * Math.Log(Math.Sqrt(1 + Math.Pow(Math.Cos(y11), 2)))) / (Math.Pow(e11, y11) + Math.Pow(Math.Sin(x11), 2))}");
                    MyTaskClass11 myTaskClass11 = new MyTaskClass11(e11, x11, y11);
                    myTaskClass11.I();
                    break;

                case 12:
                    double y12, x12, a12;

                    Console.WriteLine("Введите значение y");
                    y12 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение x");
                    x12 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение a");
                    a12 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"G = {(Math.Pow(Math.Cos(Math.Abs(y12 + x12)), 3) - (x12 + y12)) / ((1 / Math.Pow(Math.Tan(x12 + a12), 4)) * (Math.Pow(x12, 5)))}");
                    MyTaskClass12 myTaskClass12 = new MyTaskClass12(y12, x12, a12);
                    myTaskClass12.G();
                    break;

                case 13:
                    double a13, b13, x13;

                    Console.WriteLine("Введите значение a");
                    a13 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение b");
                    b13 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение x");
                    x13 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"R = {(a13) / (x13 - a13) + (Math.Pow(b13, x13) + Math.Pow(Math.Cos(x13), 3)) / (Math.Pow(Math.Log(a13), 3) + 4.5)}");
                    MyTaskClass13 myTaskClass13 = new MyTaskClass13(a13, b13, x13);
                    myTaskClass13.R();
                    break;

                case 14:
                    double x14;

                    Console.WriteLine("Введите значение x");
                    x14 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"R = {(Math.Sin(Math.Pow(Math.Pow(x14, 2) + 4, 3)) + 4.3) / (Math.Pow(Math.Sin(Math.Pow(x14, 4)), 3))}");
                    MyTaskClass14 myTaskClass14 = new MyTaskClass14(x14);
                    myTaskClass14.R();
                    break;

                case 15:
                    double m15, y15;

                    Console.WriteLine("Введите значение m");
                    m15 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y15 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"N = {(Math.Pow(m15, 2) + 2.8 * m15 + 0.355) / (Math.Cos(2 * y15) + 3.6)}");
                    MyTaskClass15 myTaskClass15 = new MyTaskClass15(m15, y15);
                    myTaskClass15.N();
                    break;

                case 16:
                    double x16, y16, t16;

                    Console.WriteLine("Введите значение x");
                        x16 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y16 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение t");
                    t16 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"P = {Math.Pow(Math.Sin(x16), 3) + Math.Log10((2 * y16 + 3 * y16)) / t16 + Math.Sqrt(x16)}");
                    MyTaskClass16 myTaskClass16 = new MyTaskClass16(x16, y16, t16);
                    myTaskClass16.P();
                    break;

                case 17:
                    double x17, b17, a17, y17;

                    Console.WriteLine("Введите значение x");
                    x17 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение b");
                    b17 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение a");
                    a17 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y17 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"T = {Math.Sqrt(x17 + b17 - a17) + Math.Log10(y17) / Math.Atan((b17 + a17))}");
                    MyTaskClass17 myTaskClass17 = new MyTaskClass17(x17, b17, a17, y17);
                    myTaskClass17.T();
                    break;

                case 18:
                    double y18, t18;

                    Console.WriteLine("Введите значение y");
                    y18 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение t");
                    t18 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"S = {4.351 * Math.Pow(y18, 3) + 2 * t18 * Math.Log10(t18)}");
                    MyTaskClass18 myTaskClass18 = new MyTaskClass18(y18, t18);
                    myTaskClass18.S();
                    break;

                case 19:
                    double k19, a19, b19, x19, y19;
                    Console.WriteLine("Введите значение k");
                    k19 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение a");
                    a19 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение b");
                    b19 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение x");
                    x19 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y19 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"D = {k19 - a19 * Math.Sqrt(6) - Math.Cos((3 * a19 * b19)) / Math.Pow(Math.Sin((a19 * Math.Asin(x19) + Math.Log10(y19))), 2)}");
                    MyTaskClass19 myTaskClass19 = new MyTaskClass19(k19, a19, b19, x19, y19);
                    myTaskClass19.D();
                    break;

                case 20:
                    double y20, x20, b20, c20, a20;

                    Console.WriteLine("Введите значение y");
                    y20 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение x");
                    x20 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение b");
                    b20 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение c");
                    c20 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение a");
                    a20 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"U = {Math.Pow(Math.Tan(y20), 3) + Math.Pow(Math.Sin(x20), 5) * Math.Sqrt(b20 - c20) / Math.Sqrt(a20 - b20 + c20)}");
                    MyTaskClass20 myTaskClass20 = new MyTaskClass20(y20, x20, b20, c20, a20);
                    myTaskClass20.U();
                    break;

                case 21:
                    double z21, x21, e21, a21;

                    Console.WriteLine("Введите значение z");
                    z21 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение x");
                    x21 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение e");
                    e21 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение a");
                    a21 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"N = {Math.Pow(Math.Sqrt(z21 + Math.Sqrt(z21 * x21)), 1/5) / Math.Pow(e21, x21) + Math.Pow(a21, 5) * Math.Atan(x21)}");
                    MyTaskClass21 myTaskClass21 = new MyTaskClass21(z21, x21, e21, a21);
                    myTaskClass21.N();
                    break;

                case 22:
                    double x22, y22;

                    Console.WriteLine("Введите значение x");
                    x22 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y22 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"F = {Math.Cos((Math.Pow(x22, 2) + 2) + 3.5 * Math.Pow(x22, 2) + 1 / Math.Pow(Math.Cos(y22), 2))}");
                    MyTaskClass22 myTaskClass22 = new MyTaskClass22(x22, y22);
                    myTaskClass22.F();
                    break;

                case 23:
                    double x23, z23, a23, b23;

                    Console.WriteLine("Введите значение x");
                    x23 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение z");
                    z23 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение a");
                    a23 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение b");
                    b23 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"F = {Math.Sqrt(Math.Abs(x23) + Math.Pow(Math.Cos(x23), 3) + Math.Pow(z23, 4)) / Math.Log10(x23) - Math.Asin((b23 * x23 -a23))}");
                    MyTaskClass23 myTaskClass23 = new MyTaskClass23(x23, z23, a23, b23);
                    myTaskClass23.F();
                    break;

                case 24:
                    double b24, x24, a24, z24;

                    Console.WriteLine("Введите значение b");
                    b24 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение z");
                    z24 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение a");
                    a24 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение x");
                    x24 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"f = {(Math.Pow(Math.Cos(b24), 7) * Math.Pow(x24, 5)) - (Math.Pow(Math.Sin(a24), 2) + Math.Cos(((Math.Pow(x24, 3) + Math.Pow(z24, 5) - Math.Pow(a24, 2)) / Math.Pow(Math.Asin(a24), 2)) + Math.Acos((Math.Pow(x24, 7) - Math.Pow(a24, 2)))))}");
                    MyTaskClass24 myTaskClass24 = new MyTaskClass24(b24, x24, a24, z24);
                    myTaskClass24.f();
                    break;

                case 25:
                    double a25, y25, x25;

                    Console.WriteLine("Введите значение y");
                    y25 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение x");
                    x25 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение a");
                    a25 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"J = {Math.Pow(1 / Math.Tan(Math.Pow(a25, 3)), 3 + Math.Pow(Math.Atan(a25), 2)) / Math.Sqrt(Math.Pow(y25, Math.Tan(x25)))}");
                    MyTaskClass25 myTaskClass25 = new MyTaskClass25(a25, y25, x25);
                    myTaskClass25.J();
                    break;

                case 26:
                    double x26, y26, e26, k26;

                    Console.WriteLine("Введите значение y");
                    y26 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение x");
                    x26 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение e");
                    e26 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение k");
                    k26 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"U = {Math.Log10((Math.Pow(x26, 3) ) + y26) - Math.Pow(y26, 4) / Math.Pow(e26, y26) + 5.4 * Math.Pow(k26, 3)}");
                    MyTaskClass26 myTaskClass26 = new MyTaskClass26(x26, y26, e26, k26);
                    myTaskClass26.U();
                    break;

                case 27:
                    double a27, x27, c27, y27;

                    Console.WriteLine("Введите значение a");
                    a27 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение x");
                    x27 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение c");
                    c27 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y27 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"P = {Math.Pow(a27, 5) + Math.Acos((a27 + Math.Pow(x27, 3)) - Math.Pow(Math.Sin((y27 - c27)), 4) / Math.Pow(Math.Sin((x27 + y27)), 3) + Math.Abs(x27 - y27))}");
                    MyTaskClass27 myTaskClass27 = new MyTaskClass27(a27, x27, c27, y27);
                    myTaskClass27.P();
                    break;

                case 28:
                    double x28, z28, y28, c28;

                    Console.WriteLine("Введите значение x");
                    x28 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение z");
                    z28 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение y");
                    y28 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение c");
                    c28 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"G = {Math.Tan((Math.Pow(x28, 4) - 6)) - Math.Pow(Math.Cos((z28 + Math.Pow(x28, 3) * y28)), 3) / Math.Pow(Math.Cos(Math.Pow(x28, 3) * Math.Pow(c28, 2)) ,2)}");
                    MyTaskClass28 myTaskClass28 = new MyTaskClass28(x28, z28, y28, c28);
                    myTaskClass28.G();
                    break;

                case 29:
                    double y29, d29, e29, x29;

                    Console.WriteLine("Введите значение y");
                    y29 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение d");
                    d29 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение e");
                    e29 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение x");
                    x29 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"R = {Math.Pow(Math.Cos(y29), 2) + 2.4 * d29 / Math.Pow(e29, y29) + Math.Log10((Math.Pow(Math.Sin(x29), 2) + 6))}");
                    MyTaskClass29 myTaskClass29 = new MyTaskClass29(y29, d29, e29, x29);
                    myTaskClass29.R();
                    break;

                case 30:
                    double x30, e30;

                    Console.WriteLine("Введите значение x");
                    x30 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите значение e");
                    e30 = Convert.ToInt32(Console.ReadLine());

                    //Console.WriteLine($"K = {Math.Sqrt(Math.Pow((3 + x30), 6) - Math.Log10(x30) / Math.Pow(e30, 0) + Math.Asin(6) * Math.Pow(x30, 2))}");
                    MyTaskClass30 myTaskClass30 = new MyTaskClass30(x30, e30);
                    myTaskClass30.K();
                    break;

            }
        }
    }
}

