using System;
using System.Collections.Generic; //used for dictionarys
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        { //a dictionary without unique keys will give an error at run time
            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                { 1, "Michael" },
                { 2, "Pichael" },
                { 3, "Thompson" }
            };

            names.Add(4, "Rick");
            names.Add(5, "plumbus");
            names.Add(6, "Linkler");

            for (int i = 0; i < names.Count; i++)
            { //invalid can only get elements by keys
                //Console.WriteLine(names[i]);

                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");

                Console.WriteLine(names.ElementAt(i));
            }

            foreach (KeyValuePair<int, string> item in names)
            {
                Console.WriteLine();
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Dictionary<string, string> teachers = new Dictionary<string, string>()
            {
                { "Math", "Aba" },
                { "Science", "Test" }
            };

            Console.WriteLine(teachers["Math"]);

            if (teachers.TryGetValue("Math", out string teacher)) //similar to try parse
            {
                Console.WriteLine(teacher);

                teachers["Math"] = "Joe"; //change the value
            }
            else
            {
                Console.WriteLine("Math teacher not found");
            }

            if (teachers.ContainsKey("Math"))
            {
                teachers.Remove("Math");
            }

            for (int i = 0; i < teachers.Count; i++)
            {
                KeyValuePair<string, string> pair = teachers.ElementAt(i);

                Console.WriteLine(teachers.ElementAt(i));
            }

            Console.ReadLine();
        }
    }
}
//keys must be unique and can not be null
//
