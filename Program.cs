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

public class Queue
{
    private Node front;
    private Node rear;

    public void Enqueue(int data)
    {
        Node newNode = new Node(data);
        if(front == null)
        {
            front = newNode;
            rear = newNode;
        }
        else
        {
            rear.next = newNode;

            rear = newNode;
        }
    }

    public int Dequeue()
    {
        if(front == null)
        {
            throw new InvalidOperationException("Queue is Empty");
        }
        int data = front.data;
        front = front.next;
        if(front == null)
        {
            (rear == null);
        }
        return data;
    }
    public int Peek()
    {
        if(front == null)
        {
            throw new InvalidOperationException("Stack is empty");

        }
        return front.data;
    }

    public bool IsEmpty()
    {
        return front == null;
    }
}

public class Program
{
    public static void Main()
    {
        Queue q = new Queue();
        q.Enqueue(56);
        q.Enqueue(30);
        q.Enqueue(70);


    }
}