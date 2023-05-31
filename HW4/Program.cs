using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Write a C# method to find the largest value from three integer values");
            int firstNumb, secondNumb, thirdNumb;
            firstNumb = 12;//int.Parse(Console.ReadLine());
            secondNumb = 15;// int.Parse(Console.ReadLine());
            thirdNumb = -2;// int.Parse(Console.ReadLine());

            FindMaxNumber(firstNumb, secondNumb, thirdNumb, out int maxNumb);
            Console.WriteLine($"The largest value is {maxNumb}");

            Console.WriteLine("2. Write a C# method to find the lowest value from three integer values.");
            FindMimNumber(firstNumb, secondNumb, thirdNumb, out int minNumb);
            Console.WriteLine($"The lowest value is {minNumb}");

            Console.WriteLine("3. Write a C# method to check the nearest value of 20 of two given integers " +
                "and return 0 if two numbers are same");

            CheckNearestTwenty(firstNumb, secondNumb, out int number);
            Console.WriteLine($"The nearest value of 20 is {number}");

            Console.WriteLine("4. Write a C# method to compute the sum of all the elements of an array of integers");
            GenerateArrayWithValue(10, out int[] resultArray);
            FindSumAllArrayElements(resultArray, out int sum, out string arrayStr);
            Console.WriteLine($"The sum of all the elements of an array [{arrayStr}] is {sum}");

            Console.WriteLine("5. Write a C# method to get the larger value from array");
            GenerateArrayWithValue(6, out int[] newArray);
            FindMaxNumberInArray(newArray, out string arrayString, out int maxNumbOfArray);
            Console.WriteLine($"The larger value from array  [{arrayString}] is {maxNumbOfArray}");
        }

        private static void FindMaxNumberInArray(int[] newArray, out string arrayString, out int maxNumbOfArray)
        {
            arrayString = "";
            maxNumbOfArray = 0;
            foreach (int element in newArray)
            {
                arrayString += element + " ";
               if (element > maxNumbOfArray)
                {
                    maxNumbOfArray = element;
                }

            }
        }

        private static void FindSumAllArrayElements(int[] resultArray, out int sum, out string arrayStr)
        {
            arrayStr = "";
            sum = 0;
            foreach (int element in resultArray)
            {
                arrayStr += element +" ";
                sum += element;

            }
        }

        private static void GenerateArrayWithValue(int arrayLength, out int[] resultArray)
        {
            resultArray = new int[arrayLength];
            Random rnd = new Random();
            
            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] = rnd.Next(0, 50);
            }
        }

        private static void CheckNearestTwenty(int firstNumb, int secondNumb, out int number)
        {
            const int twenty = 20;
            number = 0;
            int difference1 = twenty - firstNumb;
            int difference2 = twenty - secondNumb;
            
            if (difference1 == difference2)
            {
                number = 0;
            }
            else if(difference1 < difference2)
            {
                number = firstNumb;
            }
            else if (difference1 > difference2)
            {
                number = secondNumb;
            }

        }

        private static void FindMaxNumber(int firstNumb, int secondNumb, int thirdNumb, out int maxNumb) {
            maxNumb = firstNumb;
            if (maxNumb < secondNumb)
                maxNumb = secondNumb;
            if (maxNumb < thirdNumb)
                maxNumb = thirdNumb;
        }

        private static void FindMimNumber(int firstNumb, int secondNumb, int thirdNumb, out int minNumb)
        {
            minNumb = firstNumb;
            if (minNumb > secondNumb)
                minNumb = secondNumb;
            if (minNumb > thirdNumb)
                minNumb = thirdNumb;
        }
    }
}