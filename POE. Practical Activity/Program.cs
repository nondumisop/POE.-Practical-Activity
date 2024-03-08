using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE.Practical_Activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it's a palindrome:");
            int number = int.Parse(Console.ReadLine());

            if (IsPalindrome(number))
            {
                Console.WriteLine($"{number} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{number} is not a palindrome.");
            }
        }

        static bool IsPalindrome(int num)
        {
            int originalNumber = num;
            int reversedNumber = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversedNumber = reversedNumber * 10 + digit;
                num /= 10;
            }

            return originalNumber == reversedNumber;
        }
    }
}
    
