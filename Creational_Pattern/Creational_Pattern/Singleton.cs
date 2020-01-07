// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Singleton.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Ajay Lodale"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Creational_Pattern
{
    using System;

    /// <summary>
    /// this class have the singleton pattern 
    /// how to create a single instance of any class.
    /// sealed restrict the inheritance
    /// </summary>
   public sealed class Singleton
    {
        /// <summary>
        /// The object is use to store the instance to invoking the lock block single time
        /// </summary>
         private static Object obj = new object();

        /// <summary>
        /// The counter is checks only how much time it will create a instance of a class
        /// </summary>
        private static int counter = 0;

        /// <summary>
        /// The instance a variable to store the object of Singleton class inside the instance 
        /// </summary>
        private static Singleton instance = null;

        /// Lazy Initialization
       /// public static readonly Lazy<Singleton> instance = new Lazy<Singleton>(()=>new Singleton());
        /// <summary>
        /// Prevents a default instance of the <see cref="Singleton"/> class from being created.
        /// the private constructor ensures the object is not instantiated
        /// other than with in the class itself.
        /// </summary>
      private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value : {0}", counter.ToString());
        }
        
        /// <summary>
        /// Gets the get instance.
        /// public property is used to return only one instance of the class
        /// </summary>
        /// <value>
        /// The get instance.
        /// </value>
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    //// Both employee andstudent reaising each other in multi threaded inviorment
                    //// lock insure only one class succed to enter this code block other will wait till the first one completed
                    //// double-checked locking (also known as "double-checked locking optimization"[1]) is a software design pattern used to reduce the overhead of acquiring a lock by testing the locking criterion (the "lock hint") 
                    ////before acquiring the lock. Locking occurs only if the locking criterion check indicates that locking is required.
                    //// https://en.wikipedia.org/wiki/Double-checked_locking
                    lock (obj)
                    {
                        //// if the no objectis created that time only it will run or we can say create a object
                        //// No object is created so it will create a object
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }

                return instance;
            }
        }

        /// <summary>
        /// Prints the details.
        /// public method is used to invoke with Singleton instance.
        /// </summary>
        /// <param name="message">The message.</param>
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}