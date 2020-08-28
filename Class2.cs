using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Net.Http.Headers;
using System.Text;

namespace ConsoleApp1
{
    class Class2
    {
        public double FindMax(double a, double b)
        {
            double resrult;
            if (a > b)
                resrult = a;
            else
                resrult = b;
            return resrult;
        }
        class Text
        {
            static void Main(string[] args)
            {
                double a,b;
                Console.WriteLine("Pls enter a yours favourite number");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Pls enter again");
                b = Convert.ToDouble(Console.ReadLine());
                double ret;
                Class2 n = new Class2();
                ret = n.FindMax(a, b);
                Console.WriteLine(/n"{0} IS MAX", ret);
                Console.ReadKey();
            }
        }
    }
}
