using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTwoFourEightFourteen
{
    //Yes I realize I should have the same cs name as the class. I did it this way so I could not confuse nesting classes. 
    public class Account
    {
        public int balance()
        {
            return 10;
        }
    }
    public sealed class Amount : Account
    {
        public new int balance()
        {
            return 500;
        }
    }

    // You receive a compile error if you try to use the below NewAmount class because you cannot inherit classes that are sealed. 
    // public class NewAmount : Amount
    // {
    //   return 500; 
    // }

}


