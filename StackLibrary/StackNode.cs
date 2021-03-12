using System;


namespace StackLibrary
{
    //Node object containing the information payload of the node and the next
    //node in the stack.
    //Non-typed to allow flexibilty in implementation.
    public class StackNode : IStackNode
    {
        //Properties
        public object Payload { get; private set; }
        public StackNode NextNode { get; private set; }

        //Constructor
        public StackNode(object payload, StackNode next)
        {
            Payload = payload;
            NextNode = next;
        }
    }
}
