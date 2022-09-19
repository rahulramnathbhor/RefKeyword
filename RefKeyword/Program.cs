using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefKeyword
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 150, b = 320;
            Swap(ref a, ref b); // call by ref / address
            Console.WriteLine($"a = {a}  b= {b}");
        }



    }
}
