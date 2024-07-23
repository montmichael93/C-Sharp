using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Input_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("what is your name?: "); // this allows the user to write write input on the same line as the log
            string name = Console.ReadLine(); //returns the users input value from the console and reads that shit

            Console.Write("what is your age?: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            //to print multiple values on the same line, chain console writes together
            //Console.Write("Your Name is ");
            //Console.Write(name);
            //Console.Write(" and your age is ");
            //Console.Write(age);

            Console.WriteLine(); //will log a blank line
            Console.WriteLine("Your Name is " + name + " and you are " + age + " years old");


            // to concatenate the above



            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
