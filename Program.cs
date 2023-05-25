using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Starting C# course - Lesson1 ------");
            Console.WriteLine("Enter your name:");
            string enteredName = Console.ReadLine();
            Console.WriteLine($"Hello, {enteredName}");
        }
    }
}