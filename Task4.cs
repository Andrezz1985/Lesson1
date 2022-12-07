using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Введите число");
            int N = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            while (a <= N)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a);
                }
                a += 1;
            }

        }
    }
}
