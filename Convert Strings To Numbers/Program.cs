using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Strings_To_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textBigNumber = "90000000000";
            long bigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(bigNumber);

            string textNegative = "-55.2";
            double negative = Convert.ToDouble(textNegative);
            Console.WriteLine(negative);
            
            string textPercision = "5.000001";
            float percision = Convert.ToSingle(textPercision);
            Console.WriteLine(textPercision);

            string textMoney = "14.99";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);



            string textNumberWithChar = "24h";
            int NumberWithChar = Convert.ToInt32(textNumberWithChar);//this will give an error because there is a char in the string


            Console.WriteLine(NumberWithChar);

            Console.ReadLine();

        }
    }
}
