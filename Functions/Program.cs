using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class Test
    {
        //public means everything has access to it //static means you do not have to create an instance
        public static void someThing()
        {
            Console.WriteLine("Test");
        }
    }

    class NonStatic
    {
        public void NoStaticHere()
        {
            Console.WriteLine("This is NOT static");
        }
    }

    class Program
    {
        //the Main function must be included or else it won't compile
        static void Main()
        {
            //must get the function this way if function does not have the static key word
            NonStatic noStatic = new NonStatic();
            noStatic.NoStaticHere();

            Test.someThing();
            WelcomeMessage();
            Console.ReadLine();
        }

        //must specify the static keyword to access anywhere
        static void WelcomeMessage()
        {
            Console.WriteLine("Hola Mundo!");
        }
    }
}

//function and method are synonyms
//apparently isn't read from top down
