using System;
using StackLibrary;

namespace PalindromeFinderConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            bool result;

            Console.Write("Enter a word to test: ");
            input = Console.ReadLine();

            PaliTools Tester = new PaliTools();


            result = Tester.IsPalindrome(input);

            Console.Clear();
            Console.WriteLine("\n\n");
            if (result == true)
            {
                Console.WriteLine("*{input}* is a palindrome!!");
                Console.ReadLine();
            }

            if (result == false)
            {
                Console.WriteLine("*{input}* is not a palindrome, sorry...");
                Console.ReadLine();
            }
        }
    }
}
