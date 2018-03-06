/*
*****************************************
* LinkedListQueue.cs           2018     *
*                                       *
* Entry point.  Demo Queue of T         *
* LinkedList                            *
*                                       *
* Jason Thatcher                        *
*****************************************
*/

using System;

namespace LinkedListQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            try {

                Console.WriteLine("Queue of string");
                LinkedListQueue<string> myQueue = new LinkedListQueue<string>();
                myQueue.Enqueue("First");
                myQueue.Enqueue("Second");
                myQueue.Enqueue("Third");
                myQueue.Enqueue("Fourth");
                myQueue.Enqueue("Fifth");

                Console.WriteLine("DEQUEUE:  Should be First In First Out (FIFO)");
                Console.WriteLine(myQueue.Dequeue());
                Console.WriteLine(myQueue.Dequeue());
                Console.WriteLine(myQueue.Dequeue());
                Console.WriteLine(myQueue.Dequeue());
                Console.WriteLine(myQueue.Dequeue());
                Console.WriteLine();
                Console.WriteLine("SHOULD BE EMPTY.  EXPECT ERROR TO BE THROWN");
                Console.WriteLine(myQueue.Dequeue());
            }

            catch (LinkedListQueueEmptyException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\t");

            try
            {
                Console.WriteLine("Queue of int");
                LinkedListQueue<int> myIntQueue = new LinkedListQueue<int>();
                myIntQueue.Enqueue(100);
                myIntQueue.Enqueue(200);
                myIntQueue.Enqueue(300);
                myIntQueue.Enqueue(400);
                myIntQueue.Enqueue(500);

                Console.WriteLine("DEQUEUE:  Should be First In First Out (FIFO)");
                Console.WriteLine(myIntQueue.Dequeue());
                Console.WriteLine(myIntQueue.Dequeue());
                Console.WriteLine(myIntQueue.Dequeue());
                Console.WriteLine(myIntQueue.Dequeue());
                Console.WriteLine(myIntQueue.Dequeue());
                Console.WriteLine();
                Console.WriteLine("SHOULD BE EMPTY.  EXPECT ERROR TO BE THROWN");
                Console.WriteLine(myIntQueue.Dequeue());
            }

            catch (LinkedListQueueEmptyException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }
}
