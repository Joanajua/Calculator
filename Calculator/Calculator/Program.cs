
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
            string op;
            op = Console.ReadLine();

            //How many numbers?
            Console.Write(" How many numbers would you like to " + op + " ?: ");

            string Numbers;
            Numbers = Console.ReadLine();
            int numbersInt = int.Parse(Numbers);


            //Define an array that would be created with as much items as NumbersInt says.
            int[] numbersArray = new int[numbersInt];
            
            for(int indexArray = 0; indexArray < numbersInt; indexArray++)
            {
                Console.Write(" Please Enter number " + (indexArray + 1) + ": ");
                numbersArray[indexArray] = int.Parse(Console.ReadLine());
            }


            int result = numbersArray[0];
            //indexArray starts at value 1 because number 1 doesnt do any operation
            for (int indexArray = 1; indexArray < numbersInt; indexArray++)
            {
                if (op == "*")
                {
                    result = result * numbersArray[indexArray];
                }
                else if (op == "/")
                {
                    result = result / numbersArray[indexArray];
                }
                else if (op == "+")
                {
                    result = result + numbersArray[indexArray];
                }
                else if (op == "-")
                {
                    result = result - numbersArray[indexArray];
                }
            }

            Console.WriteLine(" The answer is: " + result);
            /*ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd
            
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

            if (op == "+")
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

         ddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddddd*/

            Console.ReadLine();

       
        }
    }
}
