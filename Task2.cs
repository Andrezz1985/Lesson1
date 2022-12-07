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
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if(num1>num2 && num1 > num3)
            {
                Console.WriteLine("Большее число " + num1);
            }else if(num2>num1 && num2>num3)
            {
                Console.WriteLine("Большее число " + num2);
            }
            else
            {
                Console.WriteLine("Большее число " + num3);
            }
        }
    }
}