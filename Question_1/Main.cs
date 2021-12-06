using System;

public class NthNodeFromLast
{
    public int data;
    public NthNodeFromLast next;
    public NthNodeFromLast(int d)
    {
        data = d;
        next = null;
    }
}

class LinkedList
{
    NthNodeFromLast head;

    public int GetNthNode(int index)
    {
        NthNodeFromLast current = head;
        int count = 0;

        while (current != null)
        {
             if(count == index)
             return current.data;
             count++;
             current = current.next;
        }
        return 0;
    }
    
    public void AddElement(int newData)
    {
        NthNodeFromLast newNode = new NthNodeFromLast(newData);
        newNode.next = head;
        head = newNode;
    }

    public static void Main(string[] args)
    {
        LinkedList list = new LinkedList();
        list.AddElement(1);   
        list.AddElement(20);
        list.AddElement(2);
        list.AddElement(7);
        list.AddElement(34);

        Console.WriteLine("Element at index 3 is: " + list.GetNthNode(3)); 
    }
}