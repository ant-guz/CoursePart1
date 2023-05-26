using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isTryAgain = true;
            Console.WriteLine("----- Homework 2 of C# course ------");
            Console.WriteLine("");
            Console.WriteLine("");
            sum(isTryAgain);

            isTryAgain = true;
            division(isTryAgain);

            exampleOperation();

            isTryAgain = true;
            swapNumbers(isTryAgain);

            isTryAgain = true;
            
            multiplicationNumbers(isTryAgain);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("------> Method finished.");
            Console.WriteLine("-------------------------------");
        }

        private static bool multiplicationNumbers(bool isTryAgain)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("5. Print the output of multiplication of three numbers which will be entered by the user.");
            Console.WriteLine("-------------------------------");

            do
            {
                Console.WriteLine("Enter first number:");
                string firstNumbStr = Console.ReadLine();
                bool isFirstNumb = isVarNumber(firstNumbStr);

                Console.WriteLine("Enter second number:");
                string secondNumbStr = Console.ReadLine();
                bool isSecondNumb = isVarNumber(secondNumbStr);

                Console.WriteLine("Enter third number:");
                string thirdNumbStr = Console.ReadLine();
                bool isThirdNumb = isVarNumber(thirdNumbStr);

                if (!isFirstNumb)
                {
                    Console.WriteLine($"{firstNumbStr} - is not integer");
                }
                if (!isSecondNumb)
                {
                    Console.WriteLine($"{secondNumbStr} - is not integer");
                }
                if (!isThirdNumb)
                {
                    Console.WriteLine($"{thirdNumbStr} - is not integer");
                }

                {

                    if (isFirstNumb && isSecondNumb && isThirdNumb)
                    {
                        int firstNumb = converStringToInt(firstNumbStr);
                        int secondNumb = converStringToInt(secondNumbStr);
                        int thirdNumb = converStringToInt(thirdNumbStr);
                        Console.WriteLine($"You entered numbers {firstNumb}, " +
                            $"{secondNumb} and {thirdNumb}. " +
                            $"Result of their multiplication = {firstNumb * secondNumb * thirdNumb}");

                        isTryAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                }

            } while (isTryAgain);
            return isTryAgain;
        }

        private static void swapNumbers(bool isTryAgain)
        {
            do
            {
                Console.WriteLine("Enter first number:");
                string firstNumbStr = Console.ReadLine();
                bool isFirstNumb = isVarNumber(firstNumbStr);

                Console.WriteLine("Enter second number:");
                string secondNumbStr = Console.ReadLine();
                bool isSecondNumb = isVarNumber(secondNumbStr);

                if (!isFirstNumb)
                {
                    Console.WriteLine($"{firstNumbStr} - is not integer");
                }
                if (!isSecondNumb)
                {
                    Console.WriteLine($"{secondNumbStr} - is not integer");
                }

                {

                    if (isFirstNumb && isSecondNumb)
                    {
                        Console.WriteLine($"First number you entered is {firstNumbStr}, second number you entered is {secondNumbStr}.");
                        string tmpString = firstNumbStr;
                        firstNumbStr = secondNumbStr;
                        secondNumbStr = tmpString;
                        Console.WriteLine($"Result after swap: first number = {firstNumbStr}, second number = {secondNumbStr}.");
                        isTryAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                }

            } while (isTryAgain);
        }

        private static void exampleOperation()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("3. Print the result of the specified operations ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Result of the operation (-1 + 4 * 6) = " + (-1 + 4 * 6));
            Console.WriteLine("Result of the operation ( 35+ 5 ) % 7 = " + (35 + 5) % 7);
            Console.WriteLine("Result of the operation 14 + -4 * 6 / 11 = " + (14 + (-4) * 6 / 11));
            Console.WriteLine("Result of the operation 2 + 15 / 6 * 1 - 7 % 2 = " + (2 + 15 / 6 * 1 - 7 % 2));

            Console.WriteLine("-------------------------------");
            Console.WriteLine("4. Swap two numbers");
            Console.WriteLine("-------------------------------");
        }

        private static void division(bool isTryAgain)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("2. Print the result of dividing two numbers");
            Console.WriteLine("-------------------------------");
            do
            {
                Console.WriteLine("Enter first number:");
                string firstNumbStr = Console.ReadLine();
                bool isFirstNumb = isVarNumber(firstNumbStr);

                Console.WriteLine("Enter second number:");
                string secondNumbStr = Console.ReadLine();
                bool isSecondNumb = isVarNumber(secondNumbStr);

                if (!isFirstNumb)
                {
                    Console.WriteLine($"{firstNumbStr} - is not integer");
                }
                if (!isSecondNumb)
                {
                    Console.WriteLine($"{secondNumbStr} - is not integer");
                }
                if (!firstNumbStr.Equals("0") && !secondNumbStr.Equals("0"))
                {

                    if (isFirstNumb && isSecondNumb)
                    {

                        int dividingIntegers = divisionOfTwoIntegers(converStringToInt(firstNumbStr), converStringToInt(secondNumbStr));
                        Console.WriteLine($"You entered numbers {firstNumbStr} and {secondNumbStr}. Their integer part of division is {dividingIntegers}");

                        double divisionDoubles = dividingOfTwoDoubles(converStringToDouble(firstNumbStr), converStringToDouble(secondNumbStr));
                        Console.WriteLine($"You entered numbers {firstNumbStr} and {secondNumbStr}. Result of their division is {divisionDoubles}");
                        isTryAgain = false;

                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                }
                else
                {
                    Console.WriteLine("Entered numbers can't be a 0. Try again!");
                }
            } while (isTryAgain);
        }

        private static void sum(bool isTryAgain)
        {

            do
            {
                Console.WriteLine("Enter first number:");
                string firstNumbStr = Console.ReadLine();
                bool isFirstNumb = isVarNumber(firstNumbStr);

                Console.WriteLine("Enter second number:");
                string secondNumbStr = Console.ReadLine();
                bool isSecondNumb = isVarNumber(secondNumbStr);

                if (!isFirstNumb)
                {
                    Console.WriteLine($"{firstNumbStr} - is not integer");
                }
                if (!isSecondNumb)
                {
                    Console.WriteLine($"{secondNumbStr} - is not integer");
                }
                if (isFirstNumb && isSecondNumb)
                {

                    int sum = sumOfTwoNumbers(converStringToInt(firstNumbStr), converStringToInt(secondNumbStr));
                    Console.WriteLine($"You entered numbers {firstNumbStr} and {secondNumbStr}. Their sum is {sum}");
                    isTryAgain = false;

                }
                else
                {
                    Console.WriteLine("Try again!");
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            } while (isTryAgain);
           
        }


        static int sumOfTwoNumbers(int firstNumber, int secondNumber) 
        {
            int resultSum = firstNumber + secondNumber;

            return resultSum;
        }
        static int divisionOfTwoIntegers(int firstNumber, int secondNumber)
        {
            int resultDividing = firstNumber / secondNumber;

            return resultDividing;
        }
        static double dividingOfTwoDoubles(double firstNumber, double secondNumber)
        {
            double resultDividing = firstNumber / secondNumber;

            return resultDividing;
        }


        static int converStringToInt(string numbAsString) {
            
            int.TryParse(numbAsString, out int result); 
            // TryParse во многих случаях бросает ексепшн.
            // Почему на этом этапе компилятор не заставляет перехватывать
            // или пробрасывать его дальше?
            return result;
        }

        static double converStringToDouble(string numbAsString)
        {
            double.TryParse(numbAsString, out double result);
      
            return result;
        }

        static bool isVarNumber(string a)
        {
            if (int.TryParse(a, out int value))
            {
                return true;
            }
            else { return false;
            }
        }
    }
}