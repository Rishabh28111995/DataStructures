using System;
using System.Collections;

public class Node
{
    public int data;
    public Node next;

    public Node(int data)
    {
        this.data = data;
        this.next = null;


    }
}

public class stack
{
    private Node top;

    public void Push(int data)
    {
        Node newNode = new Node(data);
        if(top == null)
        {
            top = newNode;
        }
        else
        {
            newNode.next = top;
            top = newNode;
        }
    }

    public int Pop()
    {
        if(top == null)
        {
            throw new InvalidOperationException("Stack is Empty");
        }
        int data = top.data;
        top = top.next;
        return data;
    }
    public int Peek()
    {
        if(top == null)
        {
            throw new InvalidOperationException("Stack is empty");

        }
        return top.data;
    }

    public bool IsEmpty()
    {
        return top == null;
    }
}

public class Program
{
    public static void Main()
    {
        Stack s = new Stack();
        s.Push(70);
        s.Push(30);
        s.Push(56);
        


    }
}
