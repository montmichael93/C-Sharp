using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Threading; //to use on the entire file

namespace String_iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "C# is awesome!!!!";
            //char[]
            //Console.WriteLine(message[0]); //same way in JS/TS
            //Console.WriteLine(message[1]);


            Console.WriteLine(message.Contains("C"));

            Console.WriteLine();



            for (int i = 0; i < message.Length; i++) { 
                Console.Write(message[i]);
               
                System.Threading.Thread.Sleep(100); // 1000ms = 1 second

            }





            Console.ReadLine();
        }
    }
}
//inside the system threading library there is a sleep function