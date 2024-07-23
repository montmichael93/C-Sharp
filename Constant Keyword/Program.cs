using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
          const int vat = 20; //fun fact VAT is Value-Added Tax (VAT) in the UK it is 20%
          const double percentVAT = vat / 100D; //turn to decimal form

          int balance = 1000;
          //vat = 10; can not change the value

          Console.WriteLine(vat);
          Console.WriteLine(balance * (vat / 100D));//without the D at the end the decimal will be lost and decimals are important when it comes to percentages
          Console.WriteLine( balance * percentVAT);
          Console.ReadLine();
        }
    }
}
