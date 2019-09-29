using System;

namespace LinkedList
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] data = {44,55,44,55,55,66,66};

      Node head = null;
      foreach (int i in data)
      {
        head = LinkedListHelpers.AddToBeginning(i);
      }

      LinkedListHelpers.removeDuplicates(head);
      LinkedListHelpers.Print();
    }
  }

    class Node {
      public int data;
      public Node next;
      public Node(int nodeData)
      {
        data = nodeData;
        next = null;
      }
      public void Print()
      {
        Console.Write("|"+ data + "|=>");
        if(next != null)
        {
          next.Print();
        }
      }
    }
}
