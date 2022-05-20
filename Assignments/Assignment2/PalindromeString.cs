using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Assignment2
{
    internal class PalindromeString
    {
        static void Palindrome(String MyString)
        {
            int l = 0;
            int r = MyString.Length - 1;
            int flag = 0;

            while (r > l)
            {
                if (MyString[l] != MyString[r])
                {
                    flag = 1;
                    break;
                }
                l++;
                r--;
            }

            if (flag == 0)
            {
                Console.WriteLine(MyString + " is a Palindrome string.");
            }
            else
            {
                Console.WriteLine(MyString + " is not a Palindrome string.");
            }
        }

        static void Main(String[] args)
        {
            Console.WriteLine("Enter the string");
            string s=Console.ReadLine();
            Palindrome(s);
            //Palindrome("rubber");
            //Palindrome("malayalam");
        }
    }
}
