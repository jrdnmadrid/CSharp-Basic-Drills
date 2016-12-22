using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneTwoFourEightFourteen;

namespace OneTwoFourEightFourteen
{
    class Program
    {
        internal static void Main(string[] args)
        {
            //Overloading (see OverLoading file for details)
            var OverLoading = new Overloading();
            Console.WriteLine(OverLoading.add(2, 2));
            var OverLoading2 = new Overloading();
            Console.WriteLine(OverLoading.add(2, 2, 2));

            //Overriding (see OverRiding file for details)
            var account = new Account();
            Console.WriteLine(account.balance());
            var amount = new Amount();
            Console.WriteLine(amount.balance());

            //Value Type explanation and using a struct in the Example class for a specific name value.
            int x = 1;
            int y = x;
            Console.WriteLine(x);
            Console.WriteLine(y);
            x = 2;
            Console.WriteLine(x);
            Console.WriteLine(y); //This returns 1 because Y saves the position in-memory of first x assigned (1). It is immutable

            //Reference type
            Example foo = new Example();
            Example faa = foo;
            //foo = new Example(); //If I uncomment this, faa.name will no longer display Jordan because it is referencing the first new object which is blank.  
            foo.Name = "Jordan";
            Console.WriteLine(foo.Name);
            Console.WriteLine(faa.Name); //Both of these should output Jordan
        }
    }
}
