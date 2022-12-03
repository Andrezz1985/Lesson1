using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1>num2)
            {
                Console.WriteLine("Большее число "+ num1+ ",а меньшее число " +num2+".");
                
            }else if (num2>num1)
            {
                Console.WriteLine("Большее число "+ num2+ ",а меньшее число " +num1+".");
                
            }



        













        }
    }
}