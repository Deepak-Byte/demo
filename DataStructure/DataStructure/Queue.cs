// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Queue.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// QueueNode class have the all Queue operations in linked 
    /// </summary>
    public class QueueNode
    {
        /// <summary>
        /// The key variable use as Node of Queue
        /// </summary>
        public int key;

        /// <summary>
        /// The next it Node of the Queue
        /// </summary>
        public QueueNode next;
                
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueNode"/> class.
        /// a new linked list node
        /// constructor to create 
        /// </summary>
        /// <param name="key">The key.</param>
        public QueueNode(int key)
        {
            this.key = key;
            this.next = null;
        }
    }

    /// <summary>
    ///  A class to represent a queue The queue, 
    /// front stores the front node of LL and 
    /// rear stores the last node of LL 
    /// </summary>
    public class Queue
    {
        /// <summary>
        /// The front is exit point of the queue
        /// the rear is the entry point of the queue
        /// </summary>
         private QueueNode front, rear;

        /// <summary>
        /// Initializes a new instance of the <see cref="Queue"/> class.
        /// </summary>
        public Queue()
        {
            this.front = this.rear = null;
        }

        /// <summary>
        /// EnsQueue the queue.
        /// </summary>
        /// <param name="key">The key.</param>
        public void EnQueue(int key)
        {
            QueueNode temp = new QueueNode(key);
            //// If queue is empty, then new 
            //// node is front and rear both
            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }

            //// Add the new node at the 
            //// end of queue and change rear

            this.rear.next = temp;
            this.rear = temp;
        }

        /// <summary>
        /// DeQueue the queue.
        /// Method to remove an key from queue. 
        /// </summary>
        /// <returns>QueueNode</returns>
        public QueueNode DeQueue()
        {
            //// If queue is empty, return NULL.

            if (this.front == null)
            {
                return null;
            }
            //// Store previous front and 
            //// move front one node ahead
            QueueNode temp = this.front;
            this.front = this.front.next;

            //// If front becomes NULL, 
            //// then change rear also as NULL 
            if (this.front == null)
            {
                this.rear = null;
            }

            return temp;
        }

        /// <summary>
        /// Displays this instance.
        /// display method is used display the all nodes
        /// </summary>
        public void Display()
        {
            if (this.front == null)
            {
                Console.WriteLine("\nQueue is Empty!!!\n");
            }
            else
            {
                QueueNode temp = this.front;
                while (temp.next != null)
                {
                    Console.Write(temp.key + " ");
                    temp = temp.next;
                }

                Console.WriteLine("{0}-->NULL\n", temp.key);
            }
        }
    }
}
