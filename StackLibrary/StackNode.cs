using System;
namespace StackLibrary
{
    public class StackNode
    {
        public object Payload { get; set; }


        //Methods

        public object GetPayload()
        {
            return Payload;
        }

        //Constructor

        public StackNode(object payload)
        {
            Payload = payload;
        }
    }
}
