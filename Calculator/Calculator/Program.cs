
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

            //Operators
            Console.Write(" Enter one operator ( + , - , * , / ): ");
            string operatorSimbol;
            operatorSimbol = Console.ReadLine();

            //First Number
            Console.Write("Please, enter one number: ");
            string firstNumber;
            firstNumber = Console.ReadLine();

            //Second Number
            Console.Write("Now, please, enter another number: ");
            string secondNumber;
            secondNumber = Console.ReadLine();

            //Parse Conversion string-Integrer
            int firstNumberInt = int.Parse(firstNumber);
            int secondNumberInt = int.Parse(secondNumber);


            int result = 0;

            if (operatorSimbol == "+")
            {
               result = firstNumberInt + secondNumberInt;
            }

            else if (operatorSimbol == "-")
            {
               result = firstNumberInt - secondNumberInt;
            }

            else if (operatorSimbol == "*")
            {
               result = firstNumberInt * secondNumberInt;
            }

            else if (operatorSimbol == "/")
            {
               result = firstNumberInt / secondNumberInt;
            }
            

            Console.WriteLine("This is the result of your numbers:" + result);

            Console.ReadLine();

       
        }
    }
}
