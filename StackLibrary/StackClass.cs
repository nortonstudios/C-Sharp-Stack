using System;

//This class holds the control methods for my stack data structure implementation.
namespace StackLibrary
{
    public class StackClass
    {

        public StackNode Head { get; set; }

        public static void Push( StackNode node)
        {


        }

        public static object Pop ()  ////START HERE
        {
            object payload = Head.Payload;
            Head = Head.NextNode;
            return payload;
        }


        public StackClass()
        {
        }
    }
}
