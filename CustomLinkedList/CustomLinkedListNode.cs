namespace CustomLinkedList
{
    public class CustomLinkedListNode <T>
    {
        public CustomLinkedListNode<T> NextNode { get; set; }
        public CustomLinkedListNode<T> PreviousNode { get; set; }
        public T Data { get; set; }

        public CustomLinkedListNode(T data, CustomLinkedListNode<T> next, CustomLinkedListNode<T> previous)
        {
            this.Data = data;
            this.NextNode = next;
            this.PreviousNode = previous;
        }
    }
}