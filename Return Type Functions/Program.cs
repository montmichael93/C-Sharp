using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Type_Functions
{
    internal class Program
    {
        //this makes the variable global, which we do not like
        static string title = "This is the console title";

        static void Main(string[] args)
        {
            Console.Title = title;
            PrintIntro();

            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = ReadNumberFromConsole();
            }

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }

            int[] newNumbers = CreateRandomArray();

            foreach (var item in newNumbers)
            {
                Console.Write($"{item}");
            }

            Console.ReadLine();
        }

        static int[] CreateRandomArray()
        {
            int[] numbers = new int[3] { 0, 1, 2 };

            return numbers;
        }

        static int ReadNumberFromConsole()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string ReturnName()
        {
            return "Michael";
        }

        static byte ReturnAge()
        {
            return 22;
        }

        static void PrintIntro()
        {
            string name = ReturnName();
            byte age = ReturnAge();
            string outPut = $"Hello my name is {name} and my age is {age}";
            Console.WriteLine(outPut);
        }
    }
}
