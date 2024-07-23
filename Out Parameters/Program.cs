using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            test(out num);
            Console.WriteLine(num);
            List<string> shoppingList = new List<string>() { "coffee", "milk", "smokes" };
            shoppingList.IndexOf("Smokes");
            Console.WriteLine(FindInList("smokes", shoppingList, out int index));
            Console.ReadLine();
        }

        static bool FindInList(string s, List<string> list, out int index)
        {
            index = -1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(s.ToLower()))
                {
                    index = i;
                }
            }
            return index > -1;
        }

        static bool TryParse(string s, out int result)
        {
            result = 0;
            return true;
        }

        static bool test(out int num)
        {
            num = 5;
            return true;
        }
    }
}
