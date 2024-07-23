using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            int num = 23;

            age++; //increment by one
            //age = age + 10;
            //same as
            //age += 10
            Console.WriteLine(age);
            age--; //decrement
            //age = age - 10;
            //same as 
            //age -= 10

            num /= 10; //is 2.3 but will truncate to 2

            string name = "Michael";
            name += " is watching Anime ^_^!!!!";

            //name -= "Michael"; //cant remove from string because compiler cant determine what is in the string or if i = t can be removed

            char ch = 'a';
            ch += 'b';//will take the Unicode value for both and add them together as integer variables
            // confirm Unicode values operations

            int i = 0;

            i++;
            //same as
            ++i;

            Console.WriteLine(age);
            Console.WriteLine(num);
            Console.WriteLine(name);
            Console.WriteLine(ch);
            Console.WriteLine(i);
            //Console.WriteLine(i++); //not valid
            Console.WriteLine(++i); //valid
            Console.ReadLine();
            
            //adding, subtracting or multiplying integers gets you an integer except dividing

        }
    }
}
