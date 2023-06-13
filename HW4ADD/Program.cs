using System.Data.Common;

namespace HW4ADD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Write a program in C# Sharp to display a number in reverse order.");
            int inputNumber = 12345;
            ReverseNumber(inputNumber);
            Console.WriteLine("\n");
            Console.WriteLine("2.Write a C# Sharp program to display an alphabet pattern like A with an asterisk." +
                "Reversed string is:Display the pattern like 'A' with an asterisk");
            DisplayA();

            Console.WriteLine("\n");
            Console.WriteLine("3. Write a C# Sharp program to find the second largest element in an array.");
            int[] array = { 2, 9, 2, 4, 6 };
            FindSecondLargestNumber(array);

            Console.WriteLine("\n");
            Console.WriteLine("4. Write a C# Sharp program to check whether a triangle can be formed by " +
                "the given angles value");
            int a = 40;
            int b = 55;
            int c = 65;
            CheckTriangleCorrect(a, b, c);
            //a + b > c, b + c > a, a + c > b
        }

        private static void CheckTriangleCorrect(int a, int b, int c)
        {
            int sum = a + b + c;
            if (sum == 180)
            {
                Console.WriteLine("Triangle is correct");
            }
            else
            {
                Console.WriteLine("Triangle isn't correct");
            }
        }

        private static void FindSecondLargestNumber(int[] array)
        {
            string arrayStr = "";
            foreach (var item in array)
            {
                arrayStr += item + " ";
            }
            Console.WriteLine($"Start method 'FindSecondLargestNumber' with parameter array: {arrayStr}");

            int largestNum = 0;
            int secondLargestNum = 0; ;

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    largestNum = array[i];
                }
                else
                {
                    if (array[i] > largestNum)
                    {

                        largestNum = array[i];

                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] == largestNum)
                {
                    continue;
                }
                else
                {
                    if (secondLargestNum < array[i])
                    {
                        secondLargestNum = array[i];
                    }
                }
            }
            Console.WriteLine($"largestNum = {largestNum}");
            Console.WriteLine($"secondLargestNum = {secondLargestNum}");

        }

        private static void DisplayA()
        {
            for (int row = 0; row <= 7; row++)
            {
                for (int column = 0; column <= 7; column++)
                {
                    if (((column == 1 || column == 5) && row != 0) ||
                         ((row == 0 || row == 1 || row == 4 || row == 5) && column == 3))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }



        private static void ReverseNumber(int inputNumber)
        {
            string inputNumberStr = inputNumber.ToString();
            string outputNumberStr = "";
            for (int i = inputNumberStr.Length - 1; i > -1; i--)
            {
                outputNumberStr += inputNumberStr[i];
            }
            int outputNumber = int.Parse(outputNumberStr);
            Console.WriteLine($"reverse number = {outputNumber}");
        }
    }
}