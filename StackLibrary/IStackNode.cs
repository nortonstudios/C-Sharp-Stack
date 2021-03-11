namespace StackLibrary
{
    public interface IStackNode
    {
        object Payload { get; }
        StackNode NextNode { get; }
    }
}