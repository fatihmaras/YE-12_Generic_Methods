using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_12_Generic_Methods
{
    internal class Program
    {
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            int a = 2, b = 3;
            Console.WriteLine($"a={a},b={b}");
            Swap<int>(ref a, ref b);
            Console.WriteLine($"a={a},b={b}");

            Console.WriteLine(new String('-', 15));

            char c1 = 'A', c2 = 'B';
            Console.WriteLine($"c1={c1},c2={c2}");
            Swap<char>(ref c1, ref c2);
            Console.WriteLine($"c1={c1},c2={c2}");

            Console.WriteLine(new String('-', 15));

            string n1 = "Ahmet", n2 = "Mehmet";
            Console.WriteLine($"n1={n1},n2={n2}");
            Swap<string>(ref n1, ref n2);
            Console.WriteLine($"n1={n1},n2={n2}");


            Console.ReadLine();
        }


    }
}
