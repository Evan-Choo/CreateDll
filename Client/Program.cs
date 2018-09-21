using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using CSDll;

namespace Client
{
    class Program
    {
        [DllImport("../../../Release/CppDll.dll", EntryPoint = "add")]
        public extern static int add(int a, int b);

        [DllImport("../../../Release/CppDll.dll", EntryPoint = "minus")]
        public extern static int minus(int a, int b);

        static void Main(string[] args)
        {
            Console.WriteLine("Using CppDll.dll to perform add(1, 2):");
            Console.WriteLine(add(1, 2));

            Console.WriteLine("Using CppDll.dll to perform minus(1, 2)");
            Console.WriteLine(minus(1, 2));

            Class1 class1 = new Class1();
            Console.WriteLine("Using CSDll.dll to perform max(1, 2)");
            Console.WriteLine(class1.getMax(1, 2));

            Console.WriteLine("Using CSDll.dll to perform min(1, 2)");
            Console.WriteLine(class1.getMin(1, 2));

            Console.ReadLine();
        }
    }
}
