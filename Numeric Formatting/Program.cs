using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//to get another country's currency you have to use glottalization library
using System.Globalization;

namespace Numeric_Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 1000D / 12.34D;

            Console.WriteLine(value);
            Console.WriteLine();
            Console.WriteLine(string.Format("{0} {1}", value, "second substring"));
            //will create a string and print 81.0372771474878 second substring
            Console.WriteLine();
            //Zero represents the first value //one represents the second value
            Console.WriteLine(string.Format("{0:can add space between 0.00} {1}" ,value, "<- this is the formatted value"));
            //will print: can add space between 81.04 <- this is the formatted value
            //this formatting rounds the value up by default
            Console.WriteLine();
            Console.WriteLine(string.Format("{0:0.000} ", value));
            Console.WriteLine();
            Console.WriteLine(string.Format("{0:0.000000} ", value));
            Console.WriteLine();
            Console.WriteLine(string.Format("{0:0.#} {1} ", value, "<-this removes all trailing zeros"));

       

            double money = 10D / 3D; ///3.333333333333

           // Console.WriteLine(string.Format(" $10 / $3 = ${0:0.00}", money));

            Console.WriteLine();

            //C# uses that capital C letter to convert to currency based on the computers date and time...holy shit
            Console.WriteLine(money.ToString("C"));     //$3.33  //will get currency in its native 
            Console.WriteLine(money.ToString("C0"));    //$3    //will only get you a while number
            Console.WriteLine(money.ToString("C1"));    //$3.3  //will give you one decimal place
            Console.WriteLine(money.ToString("C2"));    //$3.33 // mimics C


            Console.WriteLine();

            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB"))); //change to great British pounds
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-AU"))); //change to great Australian currency






            Console.ReadLine();
        }
    }
}

//to use another country's currency you have to a culture info to retrieve currency based on country code