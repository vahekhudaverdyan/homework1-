using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int n = Convert.ToInt32(Console.ReadLine());
            int first = 0;
            int second = 1;
            int next = 0;
            if (n == 0)
            {
                Console.WriteLine(first);
                return;
            }
            else if (n == 1)
            {
                Console.WriteLine(second);
                return;
            }
            
            for(int i = 2; i <= n; ++i)
            {
                next = first + second;
                first = second;
                second = next;
            }
            Console.WriteLine("fib index is: " + next);
        }
    }
}
