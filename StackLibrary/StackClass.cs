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
        //Add data onto the stack. 
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
        //Retreives data from stack. Information is not typed and
        //may need to be explicitly typecast by calling entity. 
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
        //Quick check to determine the if this node is the base node.
        //Naming and logic designed to make testing more intuitive.
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
