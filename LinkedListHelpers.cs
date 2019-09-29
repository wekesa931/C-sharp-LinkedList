using System;

namespace LinkedList
{
    static class LinkedListHelpers
    {
      public static Node headNode;
      static LinkedListHelpers()
      {
        headNode = null;
      }

      public static Node AddToBeginning(int data)
        {
          if(headNode == null)
          {
            headNode = new Node(data);
          }
          else
          {
            Node temp = new Node(data);
            temp.next = headNode;
            headNode = temp;
          }
          return headNode;
        }
        public static void Print()
        {
          if(headNode != null)
          {
            headNode.Print();
          }
        }
        public static Node removeDuplicates(Node head)
        {
          if (head != null)
          {
            Console.WriteLine("i pass here");
            Node start = head;
            while (start != null)
            {
              if (start.next != null && start.data == start.next.data)
              {
                start.next = start.next.next;
              }
              else
              {
                start = start.next;
              }
            }
          }else{
            Console.WriteLine("else i pass here");
          }
          return head;
        }
    }
}