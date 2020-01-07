// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Node
    {
       public int data;
       
        public Node next;
       public Node(int data)
        {
            this.data = data;
            this.next = null;

        }
        public Node(string stringdata)
        {
         
            this.next = null;
        }
    }
    public class LinkedList
    {
       public Node Head;
      

        public Node InsertAtBegining(int value)
        {
            Node temp = new Node(value);
            ////temp.data = value;
            if (Head == null)
            {
                Head = temp;
                return temp;
            }
            else {
                temp.next = Head;
                Head = temp;
                return Head; 
            }
        }
       

        public Node InsertAtLast(int value)
        {
            Node temp = new Node(value);
            if (Head == null)
            {
                Head = temp;
                return temp;
            }
            else {
                Node current = Head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = temp;
                return temp;
            }
        }
        

        public Node InsertAtPosition(int value, int position)
        {
            Node temp = new Node(value);
            Node current = Head;
            if (Head.next == null)
            {
                Console.WriteLine("Single Element Present in Linked List ");
            }
            else
            {
                for (int i = 0; i < position; i++)
                {
                    current = current.next;
                }
                Node need = current.next;
                temp.next = need;
                current.next = temp;
            }
            return temp;
        }


        public Node DeleteFirstNode()
        {
            Head = Head.next;
            Node temp=Head;
            temp = null;
            return temp;
        }

        public Node DeleteLastNode()
        {
            Node current = Head;
           
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = null;
            return current;
        }

        public Node DeleteAtPosition(int value)
        {
            Node current = Head;
            Node temp = null;
            while (current != null && current.data != value)
            {
                temp = current;
                current= current.next;
            }
            if (current == null)
            {
                Console.WriteLine("Element Not Available in Linked list");
            }
            temp.next = current.next;
            return temp;
        }
      

        public int FindLength()
        {
            Node current = Head;

            int count = 0;
            while (current.next != null)
            {
                count++;
                current = current.next;
            }
            return count;
        }

        public Node SearchNode(int value)
        {
            Node temp = new Node(value);

            while (temp != null)
            {
                if (temp.data == value)
                {
                    return temp;
                }
                else {
                    Console.WriteLine("Element not found");
                } 
            }
            return temp;
        }

        public  void PrintLinkedList()
        {
            Node temp = Head;
            while (temp != null)
            {
                Console.Write(temp.data);
                temp = temp.next;
                Console.Write("->");
            }
           
            
        }
       


            

    }
}
