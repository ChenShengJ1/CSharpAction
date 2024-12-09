namespace DataStructures.Stack;

public class SimpleStack
{
    public int Capacity { get; private set; }

    private int[] _stack;

    public int Size { get; private set; }

    public SimpleStack(int capacity = 10)
    {
        Capacity = capacity;
        _stack = new int[capacity];
        Size = 0;
    }

    public void Push(int val)
    {
        if (Size >= Capacity)
        {
            var newStack = new int[Capacity * 2];
            Array.Copy(_stack, newStack, Size);
            Capacity *= 2;
            _stack = newStack;
        }

        _stack[Size++] = val;
    }

    public int Pop()
    {
        CheckSize();
        return _stack[--Size];
    }

    public int Peek()
    {
        CheckSize();
        return _stack[Size - 1];
    }

    public bool IsEmpty()
    {
        return Size == 0;
    }

    public bool IsNotEmpty()
    {
        return !IsEmpty();
    }

    private void CheckSize()
    {
        if (Size == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
    }
}