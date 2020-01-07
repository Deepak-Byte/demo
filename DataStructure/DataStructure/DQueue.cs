// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DQueue.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
  public class DNode
    {
        internal string data;
        internal DNode prev;
        internal DNode next;
        public DNode(string d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }
    class DQueue
    {
        public DNode head;
        public void InsertFirst( string data)
        {
            char[] arr = data.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                string str =Convert.ToString( arr[i]);
                DNode newNode = new DNode(str);

                newNode.next = head;
                newNode.prev = null;
                if (head != null)
                {
                    head.prev = newNode;
                }
                head = newNode;
                Console.WriteLine("Inserted Element is ->" + head.data);
            }
            
        }
        public void InsertEnd( string data)
        {
            DNode newNode = new DNode(data);
            if (head == null)
            {
                newNode.prev = null;
               head = newNode;
                return;
            }
            DNode lastNode = GetLastNode(head);
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }

        public DNode GetLastNode(DNode head)
        {
            DNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        
        public void InsertAfter(DNode prev_node, string data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given prevoius node cannot be null");
                return;
            }
            DNode newNode = new DNode(data);
            newNode.next = prev_node.next;
            prev_node.next = newNode;
            newNode.prev = prev_node;
            if (newNode.next != null)
            {
                newNode.next.prev = newNode;
            }
        }
        public void DeleteNodebyKey( string key)
        {
            DNode temp = head;
            if (temp != null && temp.data == key)
            {
               head = temp.next;
               head.prev = null;
                return;
            }
            while (temp != null && temp.data != key)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            if (temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            if (temp.prev != null)
            {
                temp.prev.next = temp.next;
            }
        }
    }
   
}
