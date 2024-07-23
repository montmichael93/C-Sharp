using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Named_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameInput = "Michael";
            byte ageInput = 25;
            string addressInput = "1 Something Road";
            //arguments must be written in the same order as the parameters unless you do some shit like this
            PrintDetails(age: ageInput, name: nameInput, address: addressInput);
            //just use them in order, it is easier that way
            PrintDetails(nameInput, ageInput, addressInput);

            Console.ReadLine();
        }

        static void PrintDetails(string name, byte age, string address)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
        }
    }
}


