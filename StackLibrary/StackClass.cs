using System;

//This class holds the control methods for my stack data structure implementation.
namespace StackLibrary
{
    public class StackClass
    {

        public StackNode Head { get; set; }

        public void Push( object payload)
        {
            //
        }

        public object Pop()  ////START HERE. 
        {
            new object payload = Head.GetPayload();
            Head = Head.NextNode;
            return payload;
        }


        public StackClass()
        {

        }
    }
}
