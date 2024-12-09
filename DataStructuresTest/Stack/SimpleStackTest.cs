namespace DataStructuresTest.Stack;

using DataStructures.Stack;

public class Tests
{

    private SimpleStack _stack;
    
    [SetUp]
    public void Setup()
    {
        _stack = new SimpleStack();
    }

    [Test]
    public void Test_Push()
    {
        _stack.Push(0);
        Assert.That(_stack.Peek(), Is.EqualTo(0));
        Assert.That(_stack.Size, Is.EqualTo(1));
    }

    [Test]
    public void Test_Push_Resize()
    {
        for (int i = 0; i < 11; i++)
        {
            _stack.Push(i);
        }
        Assert.That(_stack.Capacity, Is.EqualTo(20));
    }

    [Test]
    public void Test_Pop()
    {
        _stack.Push(1);
        Assert.That(_stack.Pop(), Is.EqualTo(1));
    }

    [Test]
    public void Test_Pop_isEmpty()
    {
        Assert.Throws<InvalidOperationException>(() => _stack.Pop());
    }
    
    [Test]
    public void Test_Peek()
    {
        _stack.Push(1);
        Assert.That(_stack.Peek(), Is.EqualTo(1));
    }
    
}