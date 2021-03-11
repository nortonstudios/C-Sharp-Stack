using System;

//This class holds the control methods for my stack data structure implementation.
namespace StackLibrary
{
    public class StackClass
    {
        //Fields and Props
        public StackNode Head { get; set; } = null;

        public int StackSize { get; private set; } = 0;

        //Methods
        public void Push( object payload)
        {
            if (IsBase() == false)
            {
                Head = new StackNode(payload, Head);
            }
            else
            {
                Head = new StackNode(payload, null);
            }

            StackSize++;
        }

        public object Pop() 
        {
            if (IsBase() == false )
            {
                object payload = Head.Payload;
                Head = Head.NextNode;
                StackSize--;
                return payload;
            }
            else
            {
                throw new Exception("Bottom of stack reached, cannot pop anymore.");
            }

        }

        private bool IsBase()
        {
            if (Head == null)
            {
                return true;
            }
            return false;
        }

        //Constructor
        public StackClass()
        {

        } 
    }
}
