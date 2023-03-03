public class Stack<T>
{
    private class StackNode
    {
        public T data;
        public StackNode? next;

        public StackNode(T data)
        {
            this.data = data;
            next = null;
        }
    }
    private StackNode? top;

    public Stack()
    {
        top = null;
    }
    public Boolean isEmpty()
    {
        return top == null;
    }
    public void push(T data)
    {
        if (isEmpty())
        {
            top = new StackNode(data);
        }
        else
        {
            StackNode newTop = new StackNode(data);
            newTop.next = top;
            top = newTop;
        }
    }
    public T? peek()
    {
        if (top == null)
        {
            return default(T);
        }
        else
        {
            return top.data;
        }
    }
    public T? pop()
    {
        if (top == null)
        {
            return default(T);
        }
        StackNode? oldTop = top;
        top = top.next;
        return oldTop.data;
    }
}