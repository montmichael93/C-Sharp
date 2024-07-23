using System;//this is a library
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //same as
            System.Console.WriteLine("What up World!");
            Console.ReadLine(); //without this the console closes immediately since there is nothing else to do
        }
    }
}
