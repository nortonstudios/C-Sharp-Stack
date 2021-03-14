using System;
namespace StackLibrary
{
    public class PaliTools
    {
        //Fields and props
       // public string TestString { get; set; }


        //Methods

        //Default test method is not case sensitive.
        public bool IsPalindrome(string testString)
        {
            return PalandromeTester(testString.ToLower());
        }

        //Case sensitive option.
        public bool IsPalindromeCaseSensitive(string testString)
        {
            return PalandromeTester(testString);
        }

        //Business logic of palindrome test class.
        //Called by visible methods to do the dirty work. 
        private bool PalandromeTester(string testString)
        { 
            int halfString = (int)(testString.Length / 2);
            StackClass Stack = new StackClass();

            for (int i = 0; i < halfString; i++)
            {
                Stack.Push(testString[i]);
            }

            string backHalf = testString.Substring(testString.Length - halfString, halfString);

            for (int i = 0; i < backHalf.Length; i++)
            {
                if (backHalf[i].Equals(Stack.Pop()) != true)
                {
                    return false;
                }

            }

            return true;        
        }


        //Constructors
        public PaliTools()
        {
        }
    }
}
