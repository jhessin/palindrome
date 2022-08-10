using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to check for palindrome.");
            String input = Console.ReadLine();
            int value = int.Parse(input);
            Console.WriteLine("You entered " + value);
            if (checkNum(value))
            {
              Console.WriteLine("That is a palindrome!");
            }
            else
            {
              Console.WriteLine("That is NOT a palindrome");
            }

            do {
              value += 1;
            } while (!checkNum(value));

            Console.WriteLine("Your next Palindrome will occur at " + value);
        }

        static bool checkNum(int num)
        {
          String value = num.ToString();
          char[] charArray = value.ToCharArray();
          Array.Reverse(charArray);
          String reversed = new String(charArray);
          return value == reversed;
        }
    }
}
