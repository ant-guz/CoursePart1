using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("----- Homework 3 of C# course ------");
            Console.WriteLine("");
            Console.WriteLine("");
             Console.WriteLine("1. Write a C# program to check two given integers and" +
                  " return true if one is negative and one is positive.");

              while (true)
              {
                  Console.WriteLine("Enter first number:");
                  string firstNumbStr = Console.ReadLine();
                  Console.WriteLine("Enter second number:");
                  string secondNumbStr = Console.ReadLine();

                  int firstNumb = converStringToInt(firstNumbStr);
                  Console.WriteLine($"firstNumb = {firstNumb}");
                  int secondNumb = converStringToInt(secondNumbStr);
                  Console.WriteLine($"secondNumb = {secondNumb}");

                  bool isOneOfNumbersNegative = methodOne(firstNumb, secondNumb);
                  if (isOneOfNumbersNegative)
                  {
                      Console.WriteLine("One of the numbers is a negative.");
                      break;
                  }
                  else
                  {
                      Console.WriteLine("Both of the numbers are negative or positive.");
                      break;
                  }

              }

              Console.WriteLine("2. Write a C# program to check the sum of the two given " +
                  "integers and return true if one of the integer is 20 or if their sum is 20.");

              while (true)
              {
                  Console.WriteLine("Enter first number:");
                  string firstNumbStr = Console.ReadLine();
                  Console.WriteLine("Enter second number:");
                  string secondNumbStr = Console.ReadLine();

                  int firstNumb = converStringToInt(firstNumbStr);
                  Console.WriteLine($"firstNumb = {firstNumb}");
                  int secondNumb = converStringToInt(secondNumbStr);
                  Console.WriteLine($"secondNumb = {secondNumb}");

                  bool isOneOfNumbersOrSum = methodTwo(firstNumb, secondNumb);
                  if (isOneOfNumbersOrSum)
                  {
                      Console.WriteLine("One of the numbers is a negative.");
                      break;
                  }
                  else
                  {
                      Console.WriteLine("Both of the numbers are negative or positive.");
                      break;
                  }

              }
              Console.WriteLine("3. Write a C# program to compute the sum of the " +
                  "first 500 prime numbers.");
              int countPrimeNumbers = 500;
              int sumPrimeNumbers = computeSumPrimeNumbers(countPrimeNumbers);
              Console.WriteLine($"Sum of the first 500 prime numbers = {sumPrimeNumbers}");
            

            Console.WriteLine("4. Write a C# program and compute the sum of the digits of an integer.");

                            Console.WriteLine("Enter number:");
                string numbStr = Console.ReadLine();
               
                int number = converStringToInt(numbStr);
                Console.WriteLine($"firstNumb = {number}");

            int sumDigits = sumDigitsInteger(number);
            Console.WriteLine($"Sum of the digits of an integer {number} = {sumDigits}");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("------> Method finished.");
            Console.WriteLine("-------------------------------");
        }

        private static int sumDigitsInteger(int number)
        {

            if (number < 10)
            {
                return number;
            }

            int digit = number % 10;
            int nextNumber = number / 10;

            return digit + sumDigitsInteger(nextNumber);

            throw new NotImplementedException();
        }

        private static int computeSumPrimeNumbers(int countPrimeNumbers)
        {
            int startNumber = 2;
            int count = 0;
            int sum = 0;

            while (count < countPrimeNumbers)
            {
                if (isPrimeNumb(startNumber))
                {
                    sum += startNumber;
                    count++;
                }
                startNumber++;
            }

            
            return sum;
            throw new NotImplementedException();
        }
        private static bool isPrimeNumb(int primeNumber)
        {
            for (int i = 2; i < primeNumber; i++)
            {
                if(primeNumber % i == 0)
                {
                    return false;
                }
            }
            return true;

        }

        private static bool methodTwo(int firstNumb, int secondNumb)
        {
            if (firstNumb == 20 || secondNumb == 20) {
                return true;
            }
            else {
                int sum = sumOfTwoNumbers(firstNumb, secondNumb);
                if (sum == 20) {
                    return true;
                }
            }
            return false;
        }

        private static bool methodOne(int firstNumb, int secondNumb)
        {
            return firstNumb * secondNumb >= 0 ? false : true;
           
        }

        static int sumOfTwoNumbers(int firstNumber, int secondNumber)
        {
            int resultSum = firstNumber + secondNumber;

            return resultSum;
        }

        static int converStringToInt(string numbAsString)
        {

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
       
    }
}