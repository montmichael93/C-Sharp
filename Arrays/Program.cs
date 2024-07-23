using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];
            //assign number to indices
            //numbers[0] = 5;
            //numbers[1] = 10;
            //numbers[2] = 20;

            /*
            Console.WriteLine("Enter A Number: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A Number: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Your numbers are: ");
            Console.WriteLine();
           // Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");*/

            /*
            for (int i = 0; i < numbers.Length-1; i++)
            {
                Console.WriteLine("Enter A Number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($" {numbers[i]} ");
            }

            Console.WriteLine();

            foreach (int i in numbers)
            {
                Console.Write($" {numbers[i]} ");
            }*/



            const int angleCount = 3;

            int[] angles = new int[angleCount];

            for (int i = 0; i < angleCount; i++) {
                Console.WriteLine($"Enter angle {i + 1}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            int angleSum = 0;

            foreach (int angle in angles) { 
                angleSum += angle;
            }

            Console.WriteLine(angleSum);

            Console.WriteLine();

            Console.WriteLine(angleSum == 180 ? "valid" : "invalid");

            Console.ReadLine();
        }
    }
}

//arrays have static data, when a data of a specified length is created its length can not be increased or decreased
//can only modify the data inside