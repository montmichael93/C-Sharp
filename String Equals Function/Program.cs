using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Equals_Function
{
    internal class Program
    {
        static void Main(string[] args)

        {

            //Important Note, the reason why the == comparison operator is different from the .Equals() method is because,
            //at the lower level using == will compare the reference in the memory and that is what gets used out when you create the variables 
            //The example below shows why: it compares the output values instead of the values in the memory location

 

            string message = "Hello";
          

            char[] chars = { 'H', 'e', 'l', 'l', 'o' };
            object compare = new string(chars);


            //this returns same because the output value is the same
            if (message.Equals(compare))
            {
                Console.WriteLine("Same");
            }

            //error below is because in the memory location the values are different
            if (message == compare)
            {
                Console.WriteLine("Different");
            }




            string newCompare = "Hello";

            if (message.Equals(newCompare)) { 
                Console.WriteLine("Same");
            }




            Console.WriteLine();

            

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            if (!name.Equals(""))
            {
                Console.WriteLine("Your name is " + name);
            } else
            {
                Console.WriteLine("Invalid Name Input");
            } 






            Console.ReadLine();

        }
    }
}
