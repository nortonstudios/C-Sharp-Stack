using System;


namespace StackLibrary
{
    public class StackNode : IStackNode
    {
        public object Payload { get; private set; }
        public StackNode NextNode { get; private set; }

        public StackNode(object payload, StackNode next)
        {
            Payload = payload;
            NextNode = next;
        }
    }
}
