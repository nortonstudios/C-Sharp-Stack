using System;

//This class holds the control methods for my stack data structure implementation.
namespace StackLibrary
{
    public class StackClass
    {
        //Fields and Props
        public IStackNode Head { get; set; } = null;

        //Methods
        public void Push( object payload)
        {
            Head = new StackNode(payload, Head.NextNode);
        }

        public object Pop() 
        {
            object payload = Head.Payload;
            Head = Head.NextNode;
            return payload;
        }

        //Constructor
        public StackClass()
        {

        } 
    }
}
