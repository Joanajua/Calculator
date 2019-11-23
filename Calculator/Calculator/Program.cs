
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("THIS IS A CALCULATOR \n");

            Console.Write("Please, enter one number:");
            string firstNumber;
            firstNumber = Console.ReadLine();

            Console.Write("Now, please, enter another number:");
            string secondNumber;
            secondNumber = Console.ReadLine();

            int firstNumberInt = int.Parse(firstNumber);
            int secondNumberInt = int.Parse(secondNumber);

            int result = firstNumberInt + secondNumberInt;
            Console.WriteLine("This is the sume of your numbers:" + result);

            Console.ReadLine();

       
        }
    }
}
